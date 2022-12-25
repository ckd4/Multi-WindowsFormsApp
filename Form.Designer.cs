
namespace WindowsFormsApp
{
    partial class Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.BloknotSM = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertDate = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertTime = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.saveTS = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTS = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Swap = new System.Windows.Forms.Button();
            this.FromTB = new System.Windows.Forms.TextBox();
            this.ToTB = new System.Windows.Forms.TextBox();
            this.ConvertBt = new System.Windows.Forms.Button();
            this.ToCB = new System.Windows.Forms.ComboBox();
            this.FromCB = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PassListBox = new System.Windows.Forms.CheckedListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.NoteP = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbWR = new System.Windows.Forms.CheckBox();
            this.Copy = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.textBoxRND = new System.Windows.Forms.TextBox();
            this.Numb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Till = new System.Windows.Forms.NumericUpDown();
            this.From = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelCount = new System.Windows.Forms.Label();
            this.btnRes = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Till)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.From)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem1,
            this.BloknotSM,
            this.Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit});
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.выходToolStripMenuItem1.Text = "Файл";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.Exit.Size = new System.Drawing.Size(151, 22);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // BloknotSM
            // 
            this.BloknotSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InsertDate,
            this.InsertTime,
            this.saveToolStripMenuItem,
            this.saveTS,
            this.loadTS});
            this.BloknotSM.Name = "BloknotSM";
            this.BloknotSM.Size = new System.Drawing.Size(65, 20);
            this.BloknotSM.Text = "Блокнот";
            // 
            // InsertDate
            // 
            this.InsertDate.Name = "InsertDate";
            this.InsertDate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.InsertDate.Size = new System.Drawing.Size(195, 22);
            this.InsertDate.Text = "Вставить дату";
            this.InsertDate.Click += new System.EventHandler(this.InsertDate_Click);
            // 
            // InsertTime
            // 
            this.InsertTime.Name = "InsertTime";
            this.InsertTime.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.InsertTime.Size = new System.Drawing.Size(195, 22);
            this.InsertTime.Text = "Вставить время";
            this.InsertTime.Click += new System.EventHandler(this.InsertTime_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(192, 6);
            // 
            // saveTS
            // 
            this.saveTS.Name = "saveTS";
            this.saveTS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.saveTS.Size = new System.Drawing.Size(195, 22);
            this.saveTS.Text = "Save";
            this.saveTS.Click += new System.EventHandler(this.saveTS_Click);
            // 
            // loadTS
            // 
            this.loadTS.Name = "loadTS";
            this.loadTS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.loadTS.Size = new System.Drawing.Size(195, 22);
            this.loadTS.Text = "Load";
            this.loadTS.Click += new System.EventHandler(this.loadTS_Click);
            // 
            // Help
            // 
            this.Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About});
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(68, 20);
            this.Help.Text = "Помощь";
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(180, 22);
            this.About.Text = "О программе";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.comboBox1);
            this.tabPage5.Controls.Add(this.Swap);
            this.tabPage5.Controls.Add(this.FromTB);
            this.tabPage5.Controls.Add(this.ToTB);
            this.tabPage5.Controls.Add(this.ConvertBt);
            this.tabPage5.Controls.Add(this.ToCB);
            this.tabPage5.Controls.Add(this.FromCB);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(792, 400);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Converter";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "длина",
            "вес"});
            this.comboBox1.Location = new System.Drawing.Point(284, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "длина";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Swap
            // 
            this.Swap.Location = new System.Drawing.Point(89, 12);
            this.Swap.Name = "Swap";
            this.Swap.Size = new System.Drawing.Size(75, 23);
            this.Swap.TabIndex = 5;
            this.Swap.Text = "<=>";
            this.Swap.UseVisualStyleBackColor = true;
            this.Swap.Click += new System.EventHandler(this.Swap_Click);
            // 
            // FromTB
            // 
            this.FromTB.Location = new System.Drawing.Point(8, 38);
            this.FromTB.Name = "FromTB";
            this.FromTB.Size = new System.Drawing.Size(75, 20);
            this.FromTB.TabIndex = 4;
            this.FromTB.Text = "1";
            // 
            // ToTB
            // 
            this.ToTB.Location = new System.Drawing.Point(170, 38);
            this.ToTB.Name = "ToTB";
            this.ToTB.Size = new System.Drawing.Size(75, 20);
            this.ToTB.TabIndex = 3;
            // 
            // ConvertBt
            // 
            this.ConvertBt.Location = new System.Drawing.Point(89, 38);
            this.ConvertBt.Name = "ConvertBt";
            this.ConvertBt.Size = new System.Drawing.Size(75, 20);
            this.ConvertBt.TabIndex = 2;
            this.ConvertBt.Text = "Convert";
            this.ConvertBt.UseVisualStyleBackColor = true;
            this.ConvertBt.Click += new System.EventHandler(this.ConvertBt_Click);
            // 
            // ToCB
            // 
            this.ToCB.FormattingEnabled = true;
            this.ToCB.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.ToCB.Location = new System.Drawing.Point(170, 14);
            this.ToCB.Name = "ToCB";
            this.ToCB.Size = new System.Drawing.Size(75, 21);
            this.ToCB.TabIndex = 1;
            this.ToCB.Text = "mm";
            // 
            // FromCB
            // 
            this.FromCB.FormattingEnabled = true;
            this.FromCB.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.FromCB.Location = new System.Drawing.Point(8, 14);
            this.FromCB.Name = "FromCB";
            this.FromCB.Size = new System.Drawing.Size(75, 21);
            this.FromCB.TabIndex = 0;
            this.FromCB.Text = "mm";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.numericUpDown1);
            this.tabPage4.Controls.Add(this.PasswordTB);
            this.tabPage4.Controls.Add(this.Generate);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.PassListBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Passwords";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(216, 25);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(108, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(3, 70);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(207, 20);
            this.PasswordTB.TabIndex = 4;
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(216, 51);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(108, 39);
            this.Generate.TabIndex = 3;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(213, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Длина пароля";
            // 
            // PassListBox
            // 
            this.PassListBox.CheckOnClick = true;
            this.PassListBox.FormattingEnabled = true;
            this.PassListBox.Items.AddRange(new object[] {
            "Цифры",
            "Прописные буквы",
            "Строчные буквы",
            "Спец. Символы %, *, ?, #, (,  ), $, ^, &, !, @"});
            this.PassListBox.Location = new System.Drawing.Point(0, 0);
            this.PassListBox.Name = "PassListBox";
            this.PassListBox.Size = new System.Drawing.Size(210, 64);
            this.PassListBox.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.NoteP);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Блокнот";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // NoteP
            // 
            this.NoteP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoteP.Location = new System.Drawing.Point(0, 0);
            this.NoteP.Name = "NoteP";
            this.NoteP.Size = new System.Drawing.Size(792, 400);
            this.NoteP.TabIndex = 0;
            this.NoteP.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbWR);
            this.tabPage2.Controls.Add(this.Copy);
            this.tabPage2.Controls.Add(this.Clear);
            this.tabPage2.Controls.Add(this.textBoxRND);
            this.tabPage2.Controls.Add(this.Numb);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.Till);
            this.tabPage2.Controls.Add(this.From);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Генератор";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbWR
            // 
            this.cbWR.AutoSize = true;
            this.cbWR.Location = new System.Drawing.Point(389, 23);
            this.cbWR.Name = "cbWR";
            this.cbWR.Size = new System.Drawing.Size(101, 17);
            this.cbWR.TabIndex = 9;
            this.cbWR.Text = "Without Repeat";
            this.cbWR.UseVisualStyleBackColor = true;
            // 
            // Copy
            // 
            this.Copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Copy.Location = new System.Drawing.Point(118, 134);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(75, 33);
            this.Copy.TabIndex = 8;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(118, 95);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 33);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // textBoxRND
            // 
            this.textBoxRND.Location = new System.Drawing.Point(199, 22);
            this.textBoxRND.Multiline = true;
            this.textBoxRND.Name = "textBoxRND";
            this.textBoxRND.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRND.Size = new System.Drawing.Size(183, 146);
            this.textBoxRND.TabIndex = 6;
            // 
            // Numb
            // 
            this.Numb.AutoSize = true;
            this.Numb.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Numb.Location = new System.Drawing.Point(-4, 94);
            this.Numb.Name = "Numb";
            this.Numb.Size = new System.Drawing.Size(68, 73);
            this.Numb.TabIndex = 5;
            this.Numb.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Till";
            // 
            // Till
            // 
            this.Till.Location = new System.Drawing.Point(52, 57);
            this.Till.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Till.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.Till.Name = "Till";
            this.Till.Size = new System.Drawing.Size(48, 20);
            this.Till.TabIndex = 3;
            this.Till.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // From
            // 
            this.From.Location = new System.Drawing.Point(52, 23);
            this.From.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.From.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(48, 20);
            this.From.TabIndex = 2;
            this.From.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(106, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelCount);
            this.tabPage1.Controls.Add(this.btnRes);
            this.tabPage1.Controls.Add(this.buttonMin);
            this.tabPage1.Controls.Add(this.buttonPlus);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Счетчик";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(68, 57);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(20, 24);
            this.labelCount.TabIndex = 3;
            this.labelCount.Text = "0";
            // 
            // btnRes
            // 
            this.btnRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRes.Location = new System.Drawing.Point(138, 52);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(85, 29);
            this.btnRes.TabIndex = 2;
            this.btnRes.Text = "Reset";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMin.Location = new System.Drawing.Point(33, 97);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(85, 29);
            this.buttonMin.TabIndex = 1;
            this.buttonMin.Text = " -";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(33, 15);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(85, 29);
            this.buttonPlus.TabIndex = 0;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form";
            this.Text = "16 лаба";
            this.Load += new System.EventHandler(this.Прога_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Till)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.From)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label Numb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Till;
        private System.Windows.Forms.NumericUpDown From;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxRND;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.CheckBox cbWR;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox NoteP;
        private System.Windows.Forms.ToolStripMenuItem BloknotSM;
        private System.Windows.Forms.ToolStripMenuItem InsertDate;
        private System.Windows.Forms.ToolStripMenuItem InsertTime;
        private System.Windows.Forms.ToolStripSeparator saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTS;
        private System.Windows.Forms.ToolStripMenuItem loadTS;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckedListBox PassListBox;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button ConvertBt;
        private System.Windows.Forms.ComboBox ToCB;
        private System.Windows.Forms.ComboBox FromCB;
        private System.Windows.Forms.TextBox FromTB;
        private System.Windows.Forms.TextBox ToTB;
        private System.Windows.Forms.Button Swap;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

