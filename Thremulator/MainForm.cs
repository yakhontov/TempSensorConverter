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
            kTextBox.Tag = new ThermocoupleK();
            bTextBox.Tag = new ThermocoupleB();
            eTextBox.Tag = new ThermocoupleE();
            jTextBox.Tag = new ThermocoupleJ();
            nTextBox.Tag = new ThermocoupleN();
            rTextBox.Tag = new ThermocoupleR();
            sTextBox.Tag = new ThermocoupleS();
            tTextBox.Tag = new ThermocoupleT();

            pt1TextBox.Tag = new RtdPt1();
            pt2TextBox.Tag = new RtdPt2();
            cu1TextBox.Tag = new RtdCu1();
            cu2TextBox.Tag = new RtdCu2();
            niTextBox.Tag = new RtdNi();

            TtTextBox_TextChanged(tTextBox, null);
            tRTextBox_TextChanged(tRTextBox, null);

            foreach (TabPage t in tabControl1.TabPages)
                foreach (Control c in t.Controls)
                    if (c.TabIndex == Properties.Settings.Default.FocusedControl)
                    {
                        //tabPage2.Show();
                        tabControl1.SelectTab(t);
                        c.Select();
                        return;
                    }
        }

        private void TtTextBox_TextChanged(object sender, EventArgs e)
        {
            double temp, temc;
            if (!double.TryParse(tTTextBox.Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out temp))
                temp = double.NaN;

            foreach(Control c in tabPage1.Controls)
                if(c is TextBox && c.Tag is TempTable)
                {
                    TextBox tb = (TextBox)c;
                    TempTable tc = (TempTable)tb.Tag;
                    if (!tb.Focused)
                    {
                        temc = tc.GetValbyС(temp);
                        if(double.IsNaN(temc))
                            tb.Text = "—";
                        else
                            tb.Text = temc.ToString("F3");
                    }
                }
        }

        private void temcTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Focused)
            {
                double v, temp;
                if (!double.TryParse(tb.Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out v))
                    v = double.NaN;
                temp = ((TempTable)tb.Tag).GetTempC(v);
                if (double.IsNaN(temp))
                    tTTextBox.Text = "—";
                else
                    tTTextBox.Text = temp.ToString("F2");
            }
        }

        /// <summary>
        /// Изменение температуры либо сопротивления R0
        /// </summary>
        private void tRTextBox_TextChanged(object sender, EventArgs e)
        {
            double temp, R0, R;
            if (!double.TryParse(tRTextBox.Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out temp))
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
                    tRTextBox.Text = "—";
                else
                    tRTextBox.Text = temp.ToString("F2");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.FocusedControl = ActiveControl.TabIndex;
            Properties.Settings.Default.Save();
        }
    }
}
