namespace TC
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tTTextBox = new System.Windows.Forms.TextBox();
            this.kTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.jTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.niTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cu2TextBox = new System.Windows.Forms.TextBox();
            this.cu1TextBox = new System.Windows.Forms.TextBox();
            this.pt2TextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pt1TextBox = new System.Windows.Forms.TextBox();
            this.r0TextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tRTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tTTextBox
            // 
            this.tTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TC.Properties.Settings.Default, "TcTemp", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tTTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tTTextBox.Location = new System.Drawing.Point(6, 19);
            this.tTTextBox.Name = "tTTextBox";
            this.tTTextBox.Size = new System.Drawing.Size(144, 38);
            this.tTTextBox.TabIndex = 2;
            this.tTTextBox.Text = global::TC.Properties.Settings.Default.TcTemp;
            this.tTTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tTTextBox.TextChanged += new System.EventHandler(this.TtTextBox_TextChanged);
            // 
            // kTextBox
            // 
            this.kTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kTextBox.Location = new System.Drawing.Point(204, 19);
            this.kTextBox.Name = "kTextBox";
            this.kTextBox.Size = new System.Drawing.Size(172, 38);
            this.kTextBox.TabIndex = 3;
            this.kTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kTextBox.TextChanged += new System.EventHandler(this.temcTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "Temperature, °C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = " Seebeck effect, mV";
            // 
            // bTextBox
            // 
            this.bTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bTextBox.Location = new System.Drawing.Point(204, 63);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(172, 38);
            this.bTextBox.TabIndex = 4;
            this.bTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bTextBox.TextChanged += new System.EventHandler(this.temcTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(169, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 29);
            this.label4.TabIndex = 100;
            this.label4.Text = "K";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(169, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 29);
            this.label5.TabIndex = 100;
            this.label5.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(169, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 29);
            this.label3.TabIndex = 100;
            this.label3.Text = "E";
            // 
            // eTextBox
            // 
            this.eTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eTextBox.Location = new System.Drawing.Point(204, 107);
            this.eTextBox.Name = "eTextBox";
            this.eTextBox.Size = new System.Drawing.Size(172, 38);
            this.eTextBox.TabIndex = 5;
            this.eTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.eTextBox.TextChanged += new System.EventHandler(this.temcTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(169, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 29);
            this.label6.TabIndex = 100;
            this.label6.Text = "J";
            // 
            // jTextBox
            // 
            this.jTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jTextBox.Location = new System.Drawing.Point(204, 151);
            this.jTextBox.Name = "jTextBox";
            this.jTextBox.Size = new System.Drawing.Size(172, 38);
            this.jTextBox.TabIndex = 6;
            this.jTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.jTextBox.TextChanged += new System.EventHandler(this.temcTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(169, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 29);
            this.label7.TabIndex = 100;
            this.label7.Text = "N";
            // 
            // nTextBox
            // 
            this.nTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nTextBox.Location = new System.Drawing.Point(204, 195);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(172, 38);
            this.nTextBox.TabIndex = 7;
            this.nTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nTextBox.TextChanged += new System.EventHandler(this.temcTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(169, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 29);
            this.label8.TabIndex = 100;
            this.label8.Text = "R";
            // 
            // rTextBox
            // 
            this.rTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rTextBox.Location = new System.Drawing.Point(204, 239);
            this.rTextBox.Name = "rTextBox";
            this.rTextBox.Size = new System.Drawing.Size(172, 38);
            this.rTextBox.TabIndex = 8;
            this.rTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rTextBox.TextChanged += new System.EventHandler(this.temcTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(169, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 29);
            this.label9.TabIndex = 100;
            this.label9.Text = "S";
            // 
            // sTextBox
            // 
            this.sTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sTextBox.Location = new System.Drawing.Point(204, 283);
            this.sTextBox.Name = "sTextBox";
            this.sTextBox.Size = new System.Drawing.Size(172, 38);
            this.sTextBox.TabIndex = 9;
            this.sTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sTextBox.TextChanged += new System.EventHandler(this.temcTextBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(169, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 29);
            this.label10.TabIndex = 100;
            this.label10.Text = "T";
            // 
            // tTextBox
            // 
            this.tTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tTextBox.Location = new System.Drawing.Point(204, 327);
            this.tTextBox.Name = "tTextBox";
            this.tTextBox.Size = new System.Drawing.Size(172, 38);
            this.tTextBox.TabIndex = 10;
            this.tTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tTextBox.TextChanged += new System.EventHandler(this.temcTextBox_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(390, 398);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.tTTextBox);
            this.tabPage1.Controls.Add(this.tTextBox);
            this.tabPage1.Controls.Add(this.kTextBox);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.sTextBox);
            this.tabPage1.Controls.Add(this.bTextBox);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.rTextBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.eTextBox);
            this.tabPage1.Controls.Add(this.nTextBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.jTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(382, 372);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thermocouple";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.niTextBox);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.cu2TextBox);
            this.tabPage2.Controls.Add(this.cu1TextBox);
            this.tabPage2.Controls.Add(this.pt2TextBox);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.pt1TextBox);
            this.tabPage2.Controls.Add(this.r0TextBox);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.tRTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(382, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RTD";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(4, 292);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(187, 26);
            this.label18.TabIndex = 100;
            this.label18.Text = "Cu a=0.00426°C⁻¹";
            // 
            // niTextBox
            // 
            this.niTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.niTextBox.Location = new System.Drawing.Point(204, 327);
            this.niTextBox.Name = "niTextBox";
            this.niTextBox.Size = new System.Drawing.Size(172, 38);
            this.niTextBox.TabIndex = 17;
            this.niTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.niTextBox.TextChanged += new System.EventHandler(this.rRTextBox_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(201, 135);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 13);
            this.label17.TabIndex = 100;
            this.label17.Text = "Resistance, Ohm";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(6, 336);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(180, 26);
            this.label14.TabIndex = 100;
            this.label14.Text = "Ni a=0,00617°C⁻¹";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(4, 251);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(187, 26);
            this.label13.TabIndex = 100;
            this.label13.Text = "Cu a=0.00428°C⁻¹";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(6, 204);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(180, 26);
            this.label15.TabIndex = 100;
            this.label15.Text = "Pt a=0.00391°C⁻¹";
            // 
            // cu2TextBox
            // 
            this.cu2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cu2TextBox.Location = new System.Drawing.Point(204, 283);
            this.cu2TextBox.Name = "cu2TextBox";
            this.cu2TextBox.Size = new System.Drawing.Size(172, 38);
            this.cu2TextBox.TabIndex = 16;
            this.cu2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cu2TextBox.TextChanged += new System.EventHandler(this.rRTextBox_TextChanged);
            // 
            // cu1TextBox
            // 
            this.cu1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cu1TextBox.Location = new System.Drawing.Point(204, 239);
            this.cu1TextBox.Name = "cu1TextBox";
            this.cu1TextBox.Size = new System.Drawing.Size(172, 38);
            this.cu1TextBox.TabIndex = 15;
            this.cu1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cu1TextBox.TextChanged += new System.EventHandler(this.rRTextBox_TextChanged);
            // 
            // pt2TextBox
            // 
            this.pt2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pt2TextBox.Location = new System.Drawing.Point(204, 195);
            this.pt2TextBox.Name = "pt2TextBox";
            this.pt2TextBox.Size = new System.Drawing.Size(172, 38);
            this.pt2TextBox.TabIndex = 14;
            this.pt2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pt2TextBox.TextChanged += new System.EventHandler(this.rRTextBox_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(6, 160);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(180, 26);
            this.label16.TabIndex = 100;
            this.label16.Text = "Pt a=0.00385°C⁻¹";
            // 
            // pt1TextBox
            // 
            this.pt1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pt1TextBox.Location = new System.Drawing.Point(204, 151);
            this.pt1TextBox.Name = "pt1TextBox";
            this.pt1TextBox.Size = new System.Drawing.Size(172, 38);
            this.pt1TextBox.TabIndex = 13;
            this.pt1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pt1TextBox.TextChanged += new System.EventHandler(this.rRTextBox_TextChanged);
            // 
            // r0TextBox
            // 
            this.r0TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TC.Properties.Settings.Default, "RtdResistance", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.r0TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r0TextBox.Location = new System.Drawing.Point(204, 19);
            this.r0TextBox.Name = "r0TextBox";
            this.r0TextBox.Size = new System.Drawing.Size(172, 38);
            this.r0TextBox.TabIndex = 12;
            this.r0TextBox.Text = global::TC.Properties.Settings.Default.RtdResistance;
            this.r0TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.r0TextBox.TextChanged += new System.EventHandler(this.tRTextBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(201, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 13);
            this.label12.TabIndex = 100;
            this.label12.Text = "Nominal resistance, Ohm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 100;
            this.label11.Text = "Temperature, °C";
            // 
            // tRTextBox
            // 
            this.tRTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TC.Properties.Settings.Default, "RtdTemp", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tRTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tRTextBox.Location = new System.Drawing.Point(6, 19);
            this.tRTextBox.Name = "tRTextBox";
            this.tRTextBox.Size = new System.Drawing.Size(144, 38);
            this.tRTextBox.TabIndex = 11;
            this.tRTextBox.Text = global::TC.Properties.Settings.Default.RtdTemp;
            this.tRTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tRTextBox.TextChanged += new System.EventHandler(this.tRTextBox_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(382, 372);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TC.Properties.Resources.image;
            this.pictureBox2.Location = new System.Drawing.Point(-4, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(383, 262);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(129, 13);
            this.label19.TabIndex = 100;
            this.label19.Text = "We are working hard on it";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 406);
            this.Controls.Add(this.tabControl1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::TC.Properties.Settings.Default, "Location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::TC.Properties.Settings.Default.Location;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Thermulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tTTextBox;
        private System.Windows.Forms.TextBox kTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox eTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox jTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox rTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox r0TextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tRTextBox;
        private System.Windows.Forms.TextBox cu2TextBox;
        private System.Windows.Forms.TextBox cu1TextBox;
        private System.Windows.Forms.TextBox pt2TextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox pt1TextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox niTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label19;
    }
}

