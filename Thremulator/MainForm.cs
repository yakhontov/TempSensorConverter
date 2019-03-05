using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
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

            pt1TextBox.Tag = new RtdPt1();
            pt2TextBox.Tag = new RtdPt2();
            cu1TextBox.Tag = new RtdCu1();
            cu2TextBox.Tag = new RtdCu2();
            niTextBox.Tag = new RtdNi();

            //thermocoupleTempTextBox_TextChanged(tTextBox, null);
            //tRTextBox_TextChanged(tR6TextBox, null);

            /*
            foreach (TabPage t in tabControl1.TabPages)
                foreach (Control c in t.Controls)
                    if (c.TabIndex == Properties.Settings.Default.FocusedControl)
                    {
                        //tabPage2.Show();
                        tabControl1.SelectTab(t);
                        c.Select();
                        return;
                    }
             */
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.FocusedControl = ActiveControl.TabIndex;
            Properties.Settings.Default.Save();
        }

        ///////////////////////////////////////////////////////////////////////////////
        /// Первая вкладка термопар с общей температурой
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
                    tb.Text = (double.IsNaN(temc)) ? ("—") : (temc.ToString("F3"));
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
            temp1TextBox.Text = (double.IsNaN(temperature)) ? ("—") : (temperature.ToString("F2"));
        }

        ///////////////////////////////////////////////////////////////////////////////
        /// Вторая вкладка термопар с общей термоЭДС
        ///////////////////////////////////////////////////////////////////////////////
        private void thermocoupleTemp2TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox senderBox = (TextBox)sender;
            if (!senderBox.Focused)
                return;

            if (!double.TryParse(senderBox.Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out double temperature))
                temperature = double.NaN;

            double temc = ((TempTable)senderBox.Tag).GetValbyС(temperature);
            temc2TextBox.Text = (double.IsNaN(temc)) ? ("—") : (temc.ToString("F3"));
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
                    tb.Text = (double.IsNaN(temperature)) ? ("—") : (temperature.ToString("F2"));
                }
        }

        ///////////////////////////////////////////////////////////////////////////////
        /// Вкладка термосопротивлений
        ///////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Изменение температуры либо сопротивления R0
        /// </summary>
        private void tRTextBox_TextChanged(object sender, EventArgs e)
        {
            double temp, R0, R;
            if (!double.TryParse(tR6TextBox.Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out temp))
                temp = double.NaN;
            if (!double.TryParse(r0TextBox.Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out R0))
                R0 = double.NaN;

            foreach (Control c in tabPage2.Controls)
                if (c is TextBox && c.Tag is TempTable)
                {
                    TextBox tb = (TextBox)c;
                    Rtd r = (Rtd)tb.Tag;
                    if (!tb.Focused)
                    {
                        R = r.GetRbyС(R0, temp);
                        if (double.IsNaN(temp) || double.IsNaN(R0))
                            tb.Text = "—";
                        else
                            tb.Text = R.ToString("F2");
                    }
                }
        }

        /// <summary>
        /// Изменение сопротивления R
        /// </summary>
        private void rRTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Focused)
            {
                double v, temp, R0;
                if (!double.TryParse(r0TextBox.Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out R0))
                    R0 = double.NaN;
                if (!double.TryParse(tb.Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out v))
                    v = double.NaN;
                temp = ((Rtd)tb.Tag).GetTempC(R0, v);
                if (double.IsNaN(temp))
                    tR6TextBox.Text = "—";
                else
                    tR6TextBox.Text = temp.ToString("F2");
            }
        }
    }
}
