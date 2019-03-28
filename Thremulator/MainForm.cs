using System;
using System.Globalization;
using System.Windows.Forms;

namespace TC
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            k2TextBox.Tag = k1TextBox.Tag = new ThermocoupleK();
            b2TextBox.Tag = b1TextBox.Tag = new ThermocoupleB();
            e2TextBox.Tag = e1TextBox.Tag = new ThermocoupleE();
            j2TextBox.Tag = j1TextBox.Tag = new ThermocoupleJ();
            n2TextBox.Tag = n1TextBox.Tag = new ThermocoupleN();
            r2TextBox.Tag = r1TextBox.Tag = new ThermocoupleR();
            s2TextBox.Tag = s1TextBox.Tag = new ThermocoupleS();
            t2TextBox.Tag = t1TextBox.Tag = new ThermocoupleT();

            pt14TextBox.Tag = pt13TextBox.Tag = new RtdPt1();
            pt24TextBox.Tag = pt23TextBox.Tag = new RtdPt2();
            cu14TextBox.Tag = cu13TextBox.Tag = new RtdCu1();
            cu24TextBox.Tag = cu23TextBox.Tag = new RtdCu2();
            ni4TextBox.Tag = ni3TextBox.Tag = new RtdNi();

            thermocoupleTemp1TextBox_TextChanged(temp1TextBox, null);
            temc2TextBox_TextChanged(temc2TextBox, null);
            temp3TextBox_TextChanged(null, null);
            r4TextBox_TextChanged(null, null);

            foreach (Control c in tabControl1.SelectedTab.Controls)
                if(c.TabIndex == Properties.Settings.Default.FocusedControl)
                {
                    c.Select();
                    break;
                }

            versionLabel.Text = "Version " + Application.ProductVersion;

            // Программа автоматически сохраняет значения при выходе и загружает при запуске,
            // но в целях упрощения использования этот функционал отключен и при запуске загружаются дефолтные значения
            // Если потребуется его включить, нужно закомментировать следующую строку:
            LoadDefaultValues();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.FocusedControl = ActiveControl.TabIndex;
            Properties.Settings.Default.Save();
        }

        private void LoadDefaultValues()
        {
            System.Drawing.Point location = Properties.Settings.Default.Location;
            Properties.Settings.Default.Reset();
            Location = location;
        }

        ///////////////////////////////////////////////////////////////////////////////
        /// Первая вкладка: термопары с общей температурой
        ///////////////////////////////////////////////////////////////////////////////
        private void thermocoupleTemp1TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(((TextBox)sender).Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out double temperature))
                temperature = double.NaN;

            foreach(Control c in tabPage1.Controls)
                if (c is TextBox && !c.Focused && c.Tag is TempTable) 
                {
                    TextBox tb = (TextBox)c;
                    double temc = ((TempTable)tb.Tag).GetValbyС(temperature);
                    tb.Text = (double.IsNaN(temc)) ? ("—") : (temc.ToString("F3", CultureInfo.InvariantCulture));
                }
         }

        private void temc1TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox senderBox = (TextBox)sender;
            if (!senderBox.Focused)
                return;

            if (!double.TryParse(senderBox.Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out double temc))
                temc = double.NaN;

            double temperature = ((TempTable)senderBox.Tag).GetTempC(temc);
            temp1TextBox.Text = (double.IsNaN(temperature)) ? ("—") : (temperature.ToString("F2", CultureInfo.InvariantCulture));
        }

        ///////////////////////////////////////////////////////////////////////////////
        /// Вторая вкладка: термопары с общей термоЭДС
        ///////////////////////////////////////////////////////////////////////////////
        private void thermocoupleTemp2TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox senderBox = (TextBox)sender;
            if (!senderBox.Focused)
                return;

            if (!double.TryParse(senderBox.Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out double temperature))
                temperature = double.NaN;

            double temc = ((TempTable)senderBox.Tag).GetValbyС(temperature);
            temc2TextBox.Text = (double.IsNaN(temc)) ? ("—") : (temc.ToString("F3", CultureInfo.InvariantCulture));
        }

        private void temc2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(((TextBox)sender).Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out double temc))
                temc = double.NaN;

            foreach (Control c in tabPage4.Controls)
                if (c is TextBox && !c.Focused && c.Tag is TempTable)
                {
                    TextBox tb = (TextBox)c;
                    double temperature = ((TempTable)tb.Tag).GetTempC(temc);
                    tb.Text = (double.IsNaN(temperature)) ? ("—") : (temperature.ToString("F2", CultureInfo.InvariantCulture));
                }
        }

        ///////////////////////////////////////////////////////////////////////////////
        /// Третья вкладка: термосопротивления с общей температурой
        ///////////////////////////////////////////////////////////////////////////////
        private void temp3TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(temp3TextBox.Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out double temperature))
                temperature = double.NaN;
            if (!double.TryParse(r03TextBox.Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out double R0))
                R0 = double.NaN;

            foreach (Control c in tabPage2.Controls)
                if (c is TextBox && !c.Focused && c.Tag is TempTable)
                {
                    TextBox tb = (TextBox)c;
                    double R = ((Rtd)tb.Tag).GetRbyС(R0, temperature);
                    tb.Text = (double.IsNaN(R)) ? ("—") : (R.ToString("F2", CultureInfo.InvariantCulture));
                }
        }

        private void r3TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox senderBox = (TextBox)sender;
            if (!senderBox.Focused)
                return;

            if (!double.TryParse(r03TextBox.Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out double R0))
                R0 = double.NaN;
            if (!double.TryParse(senderBox.Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out double U))
                U = double.NaN;

            double R = ((Rtd)senderBox.Tag).GetTempC(R0, U);
            temp3TextBox.Text = (double.IsNaN(R)) ? ("—") : (R.ToString("F2", CultureInfo.InvariantCulture));
        }

        ///////////////////////////////////////////////////////////////////////////////
        /// Четвертая вкладка: термосопротивления с общим сопротивлением
        ///////////////////////////////////////////////////////////////////////////////
        private void temp4TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox senderBox = (TextBox)sender;
            if (!senderBox.Focused)
                return;

            if (!double.TryParse(r04TextBox.Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out double R0))
                R0 = double.NaN;
            if (!double.TryParse(senderBox.Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out double temperature))
                temperature = double.NaN;

            double R = ((Rtd)senderBox.Tag).GetRbyС(R0, temperature);
            res4TextBox.Text = (double.IsNaN(R)) ? ("—") : (R.ToString("F2", CultureInfo.InvariantCulture));
        }

        private void r4TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(res4TextBox.Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out double res))
                res = double.NaN;
            if (!double.TryParse(r04TextBox.Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out double R0))
                R0 = double.NaN;

            foreach (Control c in tabPage5.Controls)
                if (c is TextBox && !c.Focused && c.Tag is TempTable)
                {
                    TextBox tb = (TextBox)c;
                    double R = ((Rtd)tb.Tag).GetTempC(R0, res);
                    tb.Text = (double.IsNaN(R)) ? ("—") : (R.ToString("F2", CultureInfo.InvariantCulture));
                }
        }
    }
}
