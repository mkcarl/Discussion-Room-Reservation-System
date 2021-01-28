
namespace IOOP_assignment
{
    partial class GenerateMonthlyReport
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lstMonthlyReport = new System.Windows.Forms.ListBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblGenerateReport = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDaily = new System.Windows.Forms.TabPage();
            this.tabMonthly = new System.Windows.Forms.TabPage();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLeftArrow = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnJan = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Lime;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.Location = new System.Drawing.Point(535, 505);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(129, 52);
            this.btnConfirm.TabIndex = 19;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMessage.Location = new System.Drawing.Point(439, 570);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(336, 32);
            this.lblMessage.TabIndex = 20;
            // 
            // lstMonthlyReport
            // 
            this.lstMonthlyReport.FormattingEnabled = true;
            this.lstMonthlyReport.ItemHeight = 16;
            this.lstMonthlyReport.Location = new System.Drawing.Point(753, 164);
            this.lstMonthlyReport.Name = "lstMonthlyReport";
            this.lstMonthlyReport.Size = new System.Drawing.Size(432, 276);
            this.lstMonthlyReport.TabIndex = 21;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(234, 164);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(56, 25);
            this.lblYear.TabIndex = 22;
            this.lblYear.Text = "2021";
            // 
            // lblGenerateReport
            // 
            this.lblGenerateReport.AutoSize = true;
            this.lblGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerateReport.Location = new System.Drawing.Point(453, 66);
            this.lblGenerateReport.Name = "lblGenerateReport";
            this.lblGenerateReport.Size = new System.Drawing.Size(229, 25);
            this.lblGenerateReport.TabIndex = 23;
            this.lblGenerateReport.Text = "Generate Monthly Report";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDaily);
            this.tabControl1.Controls.Add(this.tabMonthly);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(110, 26);
            this.tabControl1.TabIndex = 36;
            // 
            // tabDaily
            // 
            this.tabDaily.BackColor = System.Drawing.Color.White;
            this.tabDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDaily.Location = new System.Drawing.Point(4, 25);
            this.tabDaily.Name = "tabDaily";
            this.tabDaily.Padding = new System.Windows.Forms.Padding(3);
            this.tabDaily.Size = new System.Drawing.Size(102, 0);
            this.tabDaily.TabIndex = 0;
            this.tabDaily.Text = "Daily";
            this.tabDaily.ToolTipText = "Daily";
            // 
            // tabMonthly
            // 
            this.tabMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMonthly.Location = new System.Drawing.Point(4, 25);
            this.tabMonthly.Name = "tabMonthly";
            this.tabMonthly.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonthly.Size = new System.Drawing.Size(128, 0);
            this.tabMonthly.TabIndex = 1;
            this.tabMonthly.Text = "Monthly";
            this.tabMonthly.ToolTipText = "Monthly";
            this.tabMonthly.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.BackgroundImage = global::IOOP_assignment.Properties.Resources.Jan;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Location = new System.Drawing.Point(399, 392);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(56, 57);
            this.button12.TabIndex = 35;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.BackgroundImage = global::IOOP_assignment.Properties.Resources.Jan;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Location = new System.Drawing.Point(286, 392);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(56, 57);
            this.button11.TabIndex = 34;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.BackgroundImage = global::IOOP_assignment.Properties.Resources.Jan;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Location = new System.Drawing.Point(179, 392);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(56, 57);
            this.button10.TabIndex = 33;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::IOOP_assignment.Properties.Resources.Jan;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Location = new System.Drawing.Point(80, 392);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 57);
            this.button9.TabIndex = 32;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::IOOP_assignment.Properties.Resources.Jan;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(80, 308);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 57);
            this.button8.TabIndex = 31;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::IOOP_assignment.Properties.Resources.Jan;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(179, 308);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 57);
            this.button7.TabIndex = 30;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::IOOP_assignment.Properties.Resources.Jan;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(286, 308);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 57);
            this.button6.TabIndex = 29;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::IOOP_assignment.Properties.Resources.Apr;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(399, 229);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 57);
            this.button5.TabIndex = 28;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::IOOP_assignment.Properties.Resources.Mar;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(286, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 57);
            this.button4.TabIndex = 27;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::IOOP_assignment.Properties.Resources.Jan;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(399, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 57);
            this.button3.TabIndex = 26;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::IOOP_assignment.Properties.Resources.Feb;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(179, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 57);
            this.button2.TabIndex = 25;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = global::IOOP_assignment.Properties.Resources.right;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(296, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 32);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnLeftArrow
            // 
            this.btnLeftArrow.BackColor = System.Drawing.SystemColors.Control;
            this.btnLeftArrow.BackgroundImage = global::IOOP_assignment.Properties.Resources.left3;
            this.btnLeftArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLeftArrow.FlatAppearance.BorderSize = 0;
            this.btnLeftArrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeftArrow.Location = new System.Drawing.Point(174, 164);
            this.btnLeftArrow.Name = "btnLeftArrow";
            this.btnLeftArrow.Size = new System.Drawing.Size(54, 32);
            this.btnLeftArrow.TabIndex = 17;
            this.btnLeftArrow.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Aquamarine;
            this.btnBack.BackgroundImage = global::IOOP_assignment.Properties.Resources.back1;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnBack.Location = new System.Drawing.Point(1166, 617);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 61);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnJan
            // 
            this.btnJan.BackgroundImage = global::IOOP_assignment.Properties.Resources.Jan;
            this.btnJan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnJan.FlatAppearance.BorderSize = 0;
            this.btnJan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJan.Location = new System.Drawing.Point(80, 229);
            this.btnJan.Name = "btnJan";
            this.btnJan.Size = new System.Drawing.Size(56, 57);
            this.btnJan.TabIndex = 0;
            this.btnJan.UseVisualStyleBackColor = true;
            // 
            // GenerateMonthlyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblGenerateReport);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lstMonthlyReport);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnLeftArrow);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnJan);
            this.Name = "GenerateMonthlyReport";
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJan;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ListBox lstMonthlyReport;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblGenerateReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDaily;
        private System.Windows.Forms.TabPage tabMonthly;
        private System.Windows.Forms.Button btnLeftArrow;
    }
}