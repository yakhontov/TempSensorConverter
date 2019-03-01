using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace TC
{
    abstract class TempTable
    {
        /// <summary>Максимальная температура в таблице</summary>
        protected double HighTemp;
        /// <summary>Табличное значение при максимальной температуре в таблице. Используется для проверки правильности таблицы при содании экземпляра классае</summary>
        protected double HighVal;
        /// <summary>Табличное значение при 0°С. Используется для проверки правильности таблицы при содании экземпляра класса</summary>
        protected double ZeroVal;
        /// <summary>Минимальная температура в таблице</summary>
        protected double LowTemp;
        /// <summary>Табличное значение при минимальной температуре в таблице. Используется для проверки правильности таблицы при содании экземпляра класса</summary>
        protected double LowVal;

        /// <summary>
        /// Нам придется искасть ближайшие два значения, поэтому используем список вместо массива
        /// Значения будут отсортированы - можно использовать бинарный поиск
        /// </summary>
        public List<double> TEMF = new List<double>();

        /// <summary>
        /// Заполнение элементов таблицы в производном классе
        /// 
        /// </summary>
        /// <param name="lowTemp">Минимальная температура в таблице</param>
        /// <param name="lowVal">Табличное значение при минимальной температуре в таблице. Используется для проверки правильности таблицы при содании экземпляра класса</param>
        /// <param name="highTemp">Максимальная температура в таблице</param>
        /// <param name="highVal">Табличное значение при максимальной температуре в таблице. Используется для проверки правильности таблицы при содании экземпляра классае</param>
        /// <param name="zeroVal">Табличное значение при 0°С. Используется для проверки правильности таблицы при содании экземпляра класса</param>
        /// <param name="tableData">Массив с данными таблицы</param>
        /// <param name="sortedFrom">При создании таблицы для некоторых элементов (например термопары типа B) не выполняется условие сортировки списка. Этим параметром можно указать начиная с какого элемента таблицы будет проверяться сорировка</param>
        public void CreateTable(double lowTemp, double lowVal, double highTemp, double highVal, double zeroVal, double[] tableData, int sortedFrom = 0)
        {
            HighTemp = highTemp;
            HighVal = highVal;
            ZeroVal = zeroVal;
            LowTemp = lowTemp;
            LowVal = lowVal;

            TEMF.AddRange(tableData);

            CheckTable(sortedFrom);
        }

        /// <summary>
        /// Поскольку мы делаем вид, что пишем сверхнадежное приложение, которое не должно содержать ошибок
        /// И прочая дичь, то эта функция будет проверять правильность задания элементов списка и его параметров
        /// 1. Сортировка по возрастанию
        /// 2. Количество элементов
        /// 3. Может еще что-то
        /// </summary>
        /// <returns>Если таблица содержит ошибки, выбрасывает исключение</returns>
        protected void CheckTable(int sortedFrom)
        {
            // Проверка правильности задания данных о границах температуры
            if (LowTemp > HighTemp)
                throw new ArgumentException("Некорректные данные границ температуры");

            if(!(LowVal <= ZeroVal && ZeroVal <= HighVal))
                throw new ArgumentException("Некорректные данные границ элементов таблицы");

            // Начальное и конечное значения температуры должны быть целыми числами
            if (!(LowTemp == Math.Round(LowTemp) && HighTemp == Math.Round(HighTemp)))
                throw new ArgumentException("Границы температуры должны быть целыми числами");

            if(LowTemp > 0)
                throw new ArgumentException("Нижняя граница температуры должна быть не выше 0°С");

            if (HighTemp < 0)
                throw new ArgumentException("Верхняя граница температуры должна быть не ниже 0°С");

            if (TEMF.Count != (int)(HighTemp - LowTemp) + 1)
                throw new ArgumentException("Количество элементов таблицы не соответствует границам температуры");

            if (TEMF[0] != LowVal)
                throw new ArgumentException("Первый элемент таблицы не равен заданному");

            if(TEMF[TEMF.Count - 1] != HighVal)
                throw new ArgumentException("Последний элемент таблицы не равен заданному");

            if (GetValbyС(0) != ZeroVal)
                throw new ArgumentException("Элемент таблицы в нулевой точке не равен заданному");

            // Как минимум для темопары типа B эта проверка не верна
            // Бинарный поиск тоже при этом не будет работать корректно. Ну да ладно
            if (sortedFrom > -1)
                for (int i = sortedFrom; i < TEMF.Count - 1; i++)
                    if (TEMF[i] > TEMF[i + 1])
                        throw new ArgumentException("Элементы таблицы не отсортированы по возрастанию");
        }

        public double Scale(double x, double x0, double x1, double y0, double y1)
        {
            double k = (y1 - y0) / (x1 - x0);
            return (x - x0) * k + y0;
        }

        /// <summary>
        /// Для данной термопары получить термоЭДС в миливольтах по заданной температуре в градусах Цельсия
        /// </summary>
        /// <param name="tempC">температура, для которой нужно найти термоЭДС</param>
        /// <returns>Значение термоЭДС в миливольтах для заданной температуры.
        /// Если преобразование невозможно (температура выходит за границы для данной термопары), возвращает NaN</returns>
        public double GetValbyС(double tempC)
        {
            if (TEMF.Count == 0 || tempC < LowTemp || tempC > HighTemp || double.IsNaN(tempC))
                return double.NaN;

            if(tempC == Math.Round(tempC))
                return TEMF[(int)(Math.Round(tempC) - LowTemp)];
            else
                return Scale(tempC, Math.Floor(tempC), Math.Ceiling(tempC),
                    TEMF[(int)(Math.Floor(tempC) - LowTemp)],
                    TEMF[(int)(Math.Ceiling(tempC) - LowTemp)] );
        }

        /// <summary>
        /// Для данной термопары получить термоЭДС в миливольтах по заданной температуре в градусах Кельвина
        /// </summary>
        /// <param name="tempT">температура, для которой нужно найти термоЭДС</param>
        /// <returns>Значение термоЭДС в миливольтах для заданной температуры.
        /// Если преобразование невозможно (температура выходит за границы для данной термопары), возвращает NaN</returns>
        public double GetValbyT(double tempT) { return GetValbyС(tempT - 273.15); }

        /// <summary>
        /// Для данной термопары получить температуру в градусах Цельсия по заданной термоЭДС в миливольтах
        /// </summary>
        /// <param name="value">Табличное значение, для которого нужно найти температуру</param>
        /// <returns>Значение температуры в градусах Цельсия для заданной термоЭДС в миливольтах.
        /// Если преобразование невозможно (термоЭДС выходит за границы для данной термопары), возвращает NaN</returns>
        public double GetTempC(double value)
        {
            if (TEMF.Count == 0 || value < LowVal || value > HighVal || double.IsNaN(value))
                return double.NaN;

            int i = TEMF.BinarySearch(value);
            double temp;

            if (i < 0) // Точное соответствие не найдено
            {
                double x0, x1, y0, y1;
                // BinarySearch не обнаружил в точности соответствующее значение, поэтому вернул индекс бОльшего значения в дополнительном коде
                // Переводим в нормальный индекс. 
                i = ~i;

                y0 = i - 1 + LowTemp; // Приводим индекс к градусам Цельсия, хотя для масштабирования это можно и не делать
                y1 = i + LowTemp;

                x0 = TEMF[i - 1];
                x1 = TEMF[i];

                temp = Scale(value, x0, x1, y0, y1);
            }
            else
                temp = (double)i + LowTemp;

            return temp;
        }

        /// <summary>
        /// Для данной термопары получить температуру в градусах Кельвина по заданной термоЭДС в миливольтах
        /// </summary>
        /// <param name="mV">термоЭДС, для которой нужно найти температуру</param>
        /// <returns>Значение температуры в градусах Кельвина для заданной термоЭДС в миливольтах.
        /// Если преобразование невозможно (термоЭДС выходит за границы для данной термопары), возвращает NaN</returns>
        public double GetTempT(double mV) { return GetTempC(mV) + 273.15; }
    }
}
