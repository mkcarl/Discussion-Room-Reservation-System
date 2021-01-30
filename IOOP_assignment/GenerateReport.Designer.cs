namespace IOOP_assignment
{
    partial class GenerateDailyReport
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblGenerateDailyReport = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mthCalendar = new System.Windows.Forms.MonthCalendar();
            this.lstReport = new System.Windows.Forms.ListBox();
            this.tabMonthly = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.lblGenerateReport = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.btnJan = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btnLeftArrow = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lstMonthlyReport = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabDaily.SuspendLayout();
            this.tabMonthly.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDaily);
            this.tabControl1.Controls.Add(this.tabMonthly);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(946, 495);
            this.tabControl1.TabIndex = 22;
            // 
            // tabDaily
            // 
            this.tabDaily.BackColor = System.Drawing.Color.White;
            this.tabDaily.Controls.Add(this.btnBack);
            this.tabDaily.Controls.Add(this.lblGenerateDailyReport);
            this.tabDaily.Controls.Add(this.button1);
            this.tabDaily.Controls.Add(this.mthCalendar);
            this.tabDaily.Controls.Add(this.lstReport);
            this.tabDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDaily.Location = new System.Drawing.Point(4, 25);
            this.tabDaily.Name = "tabDaily";
            this.tabDaily.Padding = new System.Windows.Forms.Padding(3);
            this.tabDaily.Size = new System.Drawing.Size(938, 466);
            this.tabDaily.TabIndex = 0;
            this.tabDaily.Text = "Daily";
            this.tabDaily.ToolTipText = "Daily";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Aquamarine;
            this.btnBack.BackgroundImage = global::IOOP_assignment.Properties.Resources.back1;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnBack.Location = new System.Drawing.Point(850, 409);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 56);
            this.btnBack.TabIndex = 48;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // lblGenerateDailyReport
            // 
            this.lblGenerateDailyReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerateDailyReport.Location = new System.Drawing.Point(268, 24);
            this.lblGenerateDailyReport.Name = "lblGenerateDailyReport";
            this.lblGenerateDailyReport.Size = new System.Drawing.Size(324, 37);
            this.lblGenerateDailyReport.TabIndex = 46;
            this.lblGenerateDailyReport.Text = "Generate Daily Report";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(354, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 45);
            this.button1.TabIndex = 47;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // mthCalendar
            // 
            this.mthCalendar.Location = new System.Drawing.Point(61, 135);
            this.mthCalendar.Name = "mthCalendar";
            this.mthCalendar.TabIndex = 44;
            // 
            // lstReport
            // 
            this.lstReport.FormattingEnabled = true;
            this.lstReport.ItemHeight = 25;
            this.lstReport.Location = new System.Drawing.Point(507, 100);
            this.lstReport.Name = "lstReport";
            this.lstReport.Size = new System.Drawing.Size(407, 254);
            this.lstReport.TabIndex = 45;
            // 
            // tabMonthly
            // 
            this.tabMonthly.Controls.Add(this.button9);
            this.tabMonthly.Controls.Add(this.lblGenerateReport);
            this.tabMonthly.Controls.Add(this.button12);
            this.tabMonthly.Controls.Add(this.btnJan);
            this.tabMonthly.Controls.Add(this.button11);
            this.tabMonthly.Controls.Add(this.btnLeftArrow);
            this.tabMonthly.Controls.Add(this.button13);
            this.tabMonthly.Controls.Add(this.lblMessage);
            this.tabMonthly.Controls.Add(this.button3);
            this.tabMonthly.Controls.Add(this.lstMonthlyReport);
            this.tabMonthly.Controls.Add(this.button6);
            this.tabMonthly.Controls.Add(this.lblYear);
            this.tabMonthly.Controls.Add(this.button7);
            this.tabMonthly.Controls.Add(this.button14);
            this.tabMonthly.Controls.Add(this.button8);
            this.tabMonthly.Controls.Add(this.button10);
            this.tabMonthly.Controls.Add(this.button2);
            this.tabMonthly.Controls.Add(this.button4);
            this.tabMonthly.Controls.Add(this.btnConfirm);
            this.tabMonthly.Controls.Add(this.button5);
            this.tabMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMonthly.Location = new System.Drawing.Point(4, 25);
            this.tabMonthly.Name = "tabMonthly";
            this.tabMonthly.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonthly.Size = new System.Drawing.Size(938, 466);
            this.tabMonthly.TabIndex = 1;
            this.tabMonthly.Text = "Monthly";
            this.tabMonthly.ToolTipText = "Monthly";
            this.tabMonthly.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::IOOP_assignment.Properties.Resources.Sep;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(18, 305);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(55, 46);
            this.button9.TabIndex = 71;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // lblGenerateReport
            // 
            this.lblGenerateReport.AutoSize = true;
            this.lblGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerateReport.Location = new System.Drawing.Point(268, 15);
            this.lblGenerateReport.Name = "lblGenerateReport";
            this.lblGenerateReport.Size = new System.Drawing.Size(356, 32);
            this.lblGenerateReport.TabIndex = 57;
            this.lblGenerateReport.Text = "Generate Monthly Report";
            // 
            // button12
            // 
            this.button12.BackgroundImage = global::IOOP_assignment.Properties.Resources.Oct;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(111, 305);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(55, 46);
            this.button12.TabIndex = 70;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // btnJan
            // 
            this.btnJan.BackgroundImage = global::IOOP_assignment.Properties.Resources.Jan;
            this.btnJan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnJan.FlatAppearance.BorderSize = 0;
            this.btnJan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJan.Location = new System.Drawing.Point(18, 142);
            this.btnJan.Name = "btnJan";
            this.btnJan.Size = new System.Drawing.Size(55, 46);
            this.btnJan.TabIndex = 52;
            this.btnJan.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.BackgroundImage = global::IOOP_assignment.Properties.Resources.Nov;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(209, 305);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(55, 46);
            this.button11.TabIndex = 69;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // btnLeftArrow
            // 
            this.btnLeftArrow.BackColor = System.Drawing.SystemColors.Control;
            this.btnLeftArrow.BackgroundImage = global::IOOP_assignment.Properties.Resources.left3;
            this.btnLeftArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLeftArrow.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLeftArrow.FlatAppearance.BorderSize = 0;
            this.btnLeftArrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeftArrow.Location = new System.Drawing.Point(112, 85);
            this.btnLeftArrow.Name = "btnLeftArrow";
            this.btnLeftArrow.Size = new System.Drawing.Size(54, 26);
            this.btnLeftArrow.TabIndex = 53;
            this.btnLeftArrow.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackgroundImage = global::IOOP_assignment.Properties.Resources.Dec;
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(308, 305);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(55, 46);
            this.button13.TabIndex = 68;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMessage.Location = new System.Drawing.Point(257, 442);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(336, 23);
            this.lblMessage.TabIndex = 54;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::IOOP_assignment.Properties.Resources.Aug;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(308, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 46);
            this.button3.TabIndex = 67;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lstMonthlyReport
            // 
            this.lstMonthlyReport.FormattingEnabled = true;
            this.lstMonthlyReport.ItemHeight = 25;
            this.lstMonthlyReport.Location = new System.Drawing.Point(530, 94);
            this.lstMonthlyReport.Name = "lstMonthlyReport";
            this.lstMonthlyReport.Size = new System.Drawing.Size(375, 229);
            this.lstMonthlyReport.TabIndex = 55;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::IOOP_assignment.Properties.Resources.July1;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(209, 221);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 46);
            this.button6.TabIndex = 66;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(170, 85);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(56, 25);
            this.lblYear.TabIndex = 56;
            this.lblYear.Text = "2021";
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::IOOP_assignment.Properties.Resources.Jun;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(111, 221);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 46);
            this.button7.TabIndex = 65;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.Control;
            this.button14.BackgroundImage = global::IOOP_assignment.Properties.Resources.right;
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.Location = new System.Drawing.Point(225, 85);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(54, 26);
            this.button14.TabIndex = 58;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::IOOP_assignment.Properties.Resources.May;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(18, 221);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 46);
            this.button8.TabIndex = 64;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.BackgroundImage = global::IOOP_assignment.Properties.Resources.Feb;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(111, 142);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(55, 46);
            this.button10.TabIndex = 59;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aquamarine;
            this.button2.BackgroundImage = global::IOOP_assignment.Properties.Resources.back1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(851, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 56);
            this.button2.TabIndex = 63;
            this.button2.Text = "Back";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::IOOP_assignment.Properties.Resources.Mar;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(209, 142);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 46);
            this.button4.TabIndex = 60;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Lime;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.Location = new System.Drawing.Point(362, 393);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(139, 46);
            this.btnConfirm.TabIndex = 62;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::IOOP_assignment.Properties.Resources.Apr;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(308, 142);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 46);
            this.button5.TabIndex = 61;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // GenerateDailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GenerateDailyReport";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabDaily.ResumeLayout(false);
            this.tabMonthly.ResumeLayout(false);
            this.tabMonthly.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMonthly;
        private System.Windows.Forms.TabPage tabDaily;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblGenerateDailyReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar mthCalendar;
        private System.Windows.Forms.ListBox lstReport;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label lblGenerateReport;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btnJan;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnLeftArrow;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lstMonthlyReport;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button button5;
    }
}

