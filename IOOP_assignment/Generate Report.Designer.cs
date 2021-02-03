﻿namespace IOOP_assignment
{
    partial class Form_Generate_Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDaily = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblGenerateDailyReport = new System.Windows.Forms.Label();
            this.mthCalendar = new System.Windows.Forms.MonthCalendar();
            this.lstReport = new System.Windows.Forms.ListBox();
            this.tabMonthly = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblGenerateReport = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnJan = new System.Windows.Forms.Button();
            this.btnSep = new System.Windows.Forms.Button();
            this.btnOct = new System.Windows.Forms.Button();
            this.btnNov = new System.Windows.Forms.Button();
            this.btnLeftArrow = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.btnAug = new System.Windows.Forms.Button();
            this.lstMonthlyReport = new System.Windows.Forms.ListBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnJul = new System.Windows.Forms.Button();
            this.btnJun = new System.Windows.Forms.Button();
            this.btnRightArrow = new System.Windows.Forms.Button();
            this.btnMay = new System.Windows.Forms.Button();
            this.btnFeb = new System.Windows.Forms.Button();
            this.btnMar = new System.Windows.Forms.Button();
            this.btnApr = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabDaily.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabMonthly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDaily);
            this.tabControl1.Controls.Add(this.tabMonthly);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1259, 617);
            this.tabControl1.TabIndex = 22;
            // 
            // tabDaily
            // 
            this.tabDaily.BackColor = System.Drawing.Color.White;
            this.tabDaily.Controls.Add(this.pictureBox1);
            this.tabDaily.Controls.Add(this.btnBack);
            this.tabDaily.Controls.Add(this.btnEmail);
            this.tabDaily.Controls.Add(this.btnSave);
            this.tabDaily.Controls.Add(this.lblGenerateDailyReport);
            this.tabDaily.Controls.Add(this.mthCalendar);
            this.tabDaily.Controls.Add(this.lstReport);
            this.tabDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDaily.Location = new System.Drawing.Point(4, 25);
            this.tabDaily.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDaily.Name = "tabDaily";
            this.tabDaily.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDaily.Size = new System.Drawing.Size(1251, 588);
            this.tabDaily.TabIndex = 0;
            this.tabDaily.Text = "Daily";
            this.tabDaily.ToolTipText = "Daily";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::IOOP_assignment.Properties.Resources.daily_report;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(381, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 66);
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::IOOP_assignment.Properties.Resources.back2;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(1157, 526);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 55);
            this.btnBack.TabIndex = 76;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmail.Location = new System.Drawing.Point(597, 460);
            this.btnEmail.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(203, 43);
            this.btnEmail.TabIndex = 75;
            this.btnEmail.Text = "Send to Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(313, 460);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(167, 43);
            this.btnSave.TabIndex = 74;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblGenerateDailyReport
            // 
            this.lblGenerateDailyReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerateDailyReport.Location = new System.Drawing.Point(459, 25);
            this.lblGenerateDailyReport.Name = "lblGenerateDailyReport";
            this.lblGenerateDailyReport.Size = new System.Drawing.Size(367, 37);
            this.lblGenerateDailyReport.TabIndex = 46;
            this.lblGenerateDailyReport.Text = "Generate Daily Report";
            // 
            // mthCalendar
            // 
            this.mthCalendar.Location = new System.Drawing.Point(117, 156);
            this.mthCalendar.Name = "mthCalendar";
            this.mthCalendar.TabIndex = 44;
            // 
            // lstReport
            // 
            this.lstReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstReport.FormattingEnabled = true;
            this.lstReport.ItemHeight = 25;
            this.lstReport.Location = new System.Drawing.Point(597, 108);
            this.lstReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstReport.Name = "lstReport";
            this.lstReport.Size = new System.Drawing.Size(589, 252);
            this.lstReport.TabIndex = 45;
            // 
            // tabMonthly
            // 
            this.tabMonthly.Controls.Add(this.button3);
            this.tabMonthly.Controls.Add(this.button2);
            this.tabMonthly.Controls.Add(this.pictureBox2);
            this.tabMonthly.Controls.Add(this.button1);
            this.tabMonthly.Controls.Add(this.lblGenerateReport);
            this.tabMonthly.Controls.Add(this.lblMessage);
            this.tabMonthly.Controls.Add(this.btnJan);
            this.tabMonthly.Controls.Add(this.btnSep);
            this.tabMonthly.Controls.Add(this.btnOct);
            this.tabMonthly.Controls.Add(this.btnNov);
            this.tabMonthly.Controls.Add(this.btnLeftArrow);
            this.tabMonthly.Controls.Add(this.btnDec);
            this.tabMonthly.Controls.Add(this.btnAug);
            this.tabMonthly.Controls.Add(this.lstMonthlyReport);
            this.tabMonthly.Controls.Add(this.lblYear);
            this.tabMonthly.Controls.Add(this.btnJul);
            this.tabMonthly.Controls.Add(this.btnJun);
            this.tabMonthly.Controls.Add(this.btnRightArrow);
            this.tabMonthly.Controls.Add(this.btnMay);
            this.tabMonthly.Controls.Add(this.btnFeb);
            this.tabMonthly.Controls.Add(this.btnMar);
            this.tabMonthly.Controls.Add(this.btnApr);
            this.tabMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMonthly.Location = new System.Drawing.Point(4, 25);
            this.tabMonthly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMonthly.Name = "tabMonthly";
            this.tabMonthly.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMonthly.Size = new System.Drawing.Size(1251, 588);
            this.tabMonthly.TabIndex = 1;
            this.tabMonthly.Text = "Monthly";
            this.tabMonthly.ToolTipText = "Monthly";
            this.tabMonthly.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(597, 460);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 43);
            this.button3.TabIndex = 76;
            this.button3.Text = "Send to Email";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(313, 460);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 43);
            this.button2.TabIndex = 75;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::IOOP_assignment.Properties.Resources.daily_report;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(380, 7);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 66);
            this.pictureBox2.TabIndex = 78;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::IOOP_assignment.Properties.Resources.back2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1157, 526);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 55);
            this.button1.TabIndex = 77;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblGenerateReport
            // 
            this.lblGenerateReport.AutoSize = true;
            this.lblGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerateReport.Location = new System.Drawing.Point(459, 21);
            this.lblGenerateReport.Name = "lblGenerateReport";
            this.lblGenerateReport.Size = new System.Drawing.Size(372, 36);
            this.lblGenerateReport.TabIndex = 57;
            this.lblGenerateReport.Text = "Generate Monthly Report";
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMessage.Location = new System.Drawing.Point(385, 526);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(335, 23);
            this.lblMessage.TabIndex = 54;
            // 
            // btnJan
            // 
            this.btnJan.BackgroundImage = global::IOOP_assignment.Properties.Resources.Jan;
            this.btnJan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnJan.FlatAppearance.BorderSize = 0;
            this.btnJan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJan.Location = new System.Drawing.Point(55, 172);
            this.btnJan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJan.Name = "btnJan";
            this.btnJan.Size = new System.Drawing.Size(107, 69);
            this.btnJan.TabIndex = 72;
            this.btnJan.UseVisualStyleBackColor = true;
            // 
            // btnSep
            // 
            this.btnSep.BackgroundImage = global::IOOP_assignment.Properties.Resources.Sep;
            this.btnSep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSep.FlatAppearance.BorderSize = 0;
            this.btnSep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSep.Location = new System.Drawing.Point(55, 337);
            this.btnSep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSep.Name = "btnSep";
            this.btnSep.Size = new System.Drawing.Size(107, 69);
            this.btnSep.TabIndex = 71;
            this.btnSep.UseVisualStyleBackColor = true;
            // 
            // btnOct
            // 
            this.btnOct.BackgroundImage = global::IOOP_assignment.Properties.Resources.Oct;
            this.btnOct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOct.FlatAppearance.BorderSize = 0;
            this.btnOct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOct.Location = new System.Drawing.Point(164, 337);
            this.btnOct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOct.Name = "btnOct";
            this.btnOct.Size = new System.Drawing.Size(107, 69);
            this.btnOct.TabIndex = 70;
            this.btnOct.UseVisualStyleBackColor = true;
            // 
            // btnNov
            // 
            this.btnNov.BackgroundImage = global::IOOP_assignment.Properties.Resources.Nov;
            this.btnNov.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNov.FlatAppearance.BorderSize = 0;
            this.btnNov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNov.Location = new System.Drawing.Point(272, 337);
            this.btnNov.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNov.Name = "btnNov";
            this.btnNov.Size = new System.Drawing.Size(107, 69);
            this.btnNov.TabIndex = 69;
            this.btnNov.UseVisualStyleBackColor = true;
            // 
            // btnLeftArrow
            // 
            this.btnLeftArrow.BackColor = System.Drawing.SystemColors.Control;
            this.btnLeftArrow.BackgroundImage = global::IOOP_assignment.Properties.Resources.left_arrow;
            this.btnLeftArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeftArrow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLeftArrow.FlatAppearance.BorderSize = 0;
            this.btnLeftArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftArrow.Location = new System.Drawing.Point(156, 110);
            this.btnLeftArrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeftArrow.Name = "btnLeftArrow";
            this.btnLeftArrow.Size = new System.Drawing.Size(53, 26);
            this.btnLeftArrow.TabIndex = 53;
            this.btnLeftArrow.UseVisualStyleBackColor = false;
            this.btnLeftArrow.Click += new System.EventHandler(this.btnLeftArrow_Click);
            // 
            // btnDec
            // 
            this.btnDec.BackgroundImage = global::IOOP_assignment.Properties.Resources.Dec;
            this.btnDec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDec.FlatAppearance.BorderSize = 0;
            this.btnDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDec.Location = new System.Drawing.Point(385, 337);
            this.btnDec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(107, 69);
            this.btnDec.TabIndex = 68;
            this.btnDec.UseVisualStyleBackColor = true;
            // 
            // btnAug
            // 
            this.btnAug.BackgroundImage = global::IOOP_assignment.Properties.Resources.Aug;
            this.btnAug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAug.FlatAppearance.BorderSize = 0;
            this.btnAug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAug.Location = new System.Drawing.Point(383, 252);
            this.btnAug.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAug.Name = "btnAug";
            this.btnAug.Size = new System.Drawing.Size(107, 69);
            this.btnAug.TabIndex = 67;
            this.btnAug.UseVisualStyleBackColor = true;
            // 
            // lstMonthlyReport
            // 
            this.lstMonthlyReport.FormattingEnabled = true;
            this.lstMonthlyReport.ItemHeight = 25;
            this.lstMonthlyReport.Location = new System.Drawing.Point(688, 123);
            this.lstMonthlyReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstMonthlyReport.Name = "lstMonthlyReport";
            this.lstMonthlyReport.Size = new System.Drawing.Size(515, 254);
            this.lstMonthlyReport.TabIndex = 55;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(224, 110);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(69, 29);
            this.lblYear.TabIndex = 56;
            this.lblYear.Text = "2021";
            // 
            // btnJul
            // 
            this.btnJul.BackgroundImage = global::IOOP_assignment.Properties.Resources.July1;
            this.btnJul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnJul.FlatAppearance.BorderSize = 0;
            this.btnJul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJul.Location = new System.Drawing.Point(272, 252);
            this.btnJul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJul.Name = "btnJul";
            this.btnJul.Size = new System.Drawing.Size(107, 69);
            this.btnJul.TabIndex = 66;
            this.btnJul.UseVisualStyleBackColor = true;
            // 
            // btnJun
            // 
            this.btnJun.BackgroundImage = global::IOOP_assignment.Properties.Resources.Jun;
            this.btnJun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnJun.FlatAppearance.BorderSize = 0;
            this.btnJun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJun.Location = new System.Drawing.Point(163, 252);
            this.btnJun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJun.Name = "btnJun";
            this.btnJun.Size = new System.Drawing.Size(107, 69);
            this.btnJun.TabIndex = 65;
            this.btnJun.UseVisualStyleBackColor = true;
            // 
            // btnRightArrow
            // 
            this.btnRightArrow.BackColor = System.Drawing.SystemColors.Control;
            this.btnRightArrow.BackgroundImage = global::IOOP_assignment.Properties.Resources.right;
            this.btnRightArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRightArrow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRightArrow.FlatAppearance.BorderSize = 0;
            this.btnRightArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRightArrow.Location = new System.Drawing.Point(309, 110);
            this.btnRightArrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRightArrow.Name = "btnRightArrow";
            this.btnRightArrow.Size = new System.Drawing.Size(53, 26);
            this.btnRightArrow.TabIndex = 58;
            this.btnRightArrow.UseVisualStyleBackColor = false;
            // 
            // btnMay
            // 
            this.btnMay.BackgroundImage = global::IOOP_assignment.Properties.Resources.May;
            this.btnMay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMay.FlatAppearance.BorderSize = 0;
            this.btnMay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMay.Location = new System.Drawing.Point(55, 252);
            this.btnMay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMay.Name = "btnMay";
            this.btnMay.Size = new System.Drawing.Size(107, 69);
            this.btnMay.TabIndex = 64;
            this.btnMay.UseVisualStyleBackColor = true;
            // 
            // btnFeb
            // 
            this.btnFeb.BackgroundImage = global::IOOP_assignment.Properties.Resources.Feb;
            this.btnFeb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFeb.FlatAppearance.BorderSize = 0;
            this.btnFeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeb.Location = new System.Drawing.Point(163, 172);
            this.btnFeb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeb.Name = "btnFeb";
            this.btnFeb.Size = new System.Drawing.Size(107, 69);
            this.btnFeb.TabIndex = 59;
            this.btnFeb.UseVisualStyleBackColor = true;
            // 
            // btnMar
            // 
            this.btnMar.BackgroundImage = global::IOOP_assignment.Properties.Resources.Mar;
            this.btnMar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMar.FlatAppearance.BorderSize = 0;
            this.btnMar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMar.Location = new System.Drawing.Point(272, 172);
            this.btnMar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMar.Name = "btnMar";
            this.btnMar.Size = new System.Drawing.Size(107, 69);
            this.btnMar.TabIndex = 60;
            this.btnMar.UseVisualStyleBackColor = true;
            // 
            // btnApr
            // 
            this.btnApr.BackgroundImage = global::IOOP_assignment.Properties.Resources.Apr;
            this.btnApr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnApr.FlatAppearance.BorderSize = 0;
            this.btnApr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApr.Location = new System.Drawing.Point(384, 172);
            this.btnApr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApr.Name = "btnApr";
            this.btnApr.Size = new System.Drawing.Size(107, 69);
            this.btnApr.TabIndex = 61;
            this.btnApr.UseVisualStyleBackColor = true;
            // 
            // Form_Generate_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 617);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Generate_Report";
            this.Text = "Generate Report";
            this.Load += new System.EventHandler(this.Generate_Report_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDaily.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabMonthly.ResumeLayout(false);
            this.tabMonthly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMonthly;
        private System.Windows.Forms.TabPage tabDaily;
        private System.Windows.Forms.Label lblGenerateDailyReport;
        private System.Windows.Forms.MonthCalendar mthCalendar;
        private System.Windows.Forms.ListBox lstReport;
        private System.Windows.Forms.Button btnSep;
        private System.Windows.Forms.Label lblGenerateReport;
        private System.Windows.Forms.Button btnOct;
        private System.Windows.Forms.Button btnNov;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnAug;
        private System.Windows.Forms.ListBox lstMonthlyReport;
        private System.Windows.Forms.Button btnJul;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnJun;
        private System.Windows.Forms.Button btnRightArrow;
        private System.Windows.Forms.Button btnMay;
        private System.Windows.Forms.Button btnFeb;
        private System.Windows.Forms.Button btnMar;
        private System.Windows.Forms.Button btnApr;
        private System.Windows.Forms.Button btnJan;
        private System.Windows.Forms.Button btnLeftArrow;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

