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
            this.mthCalendar = new System.Windows.Forms.MonthCalendar();
            this.lstReport = new System.Windows.Forms.ListBox();
            this.lblGenerateDailyReport = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMonthly = new System.Windows.Forms.TabPage();
            this.tabDaily = new System.Windows.Forms.TabPage();
            this.btnBack = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mthCalendar
            // 
            this.mthCalendar.Location = new System.Drawing.Point(112, 178);
            this.mthCalendar.Name = "mthCalendar";
            this.mthCalendar.TabIndex = 4;
            // 
            // lstReport
            // 
            this.lstReport.FormattingEnabled = true;
            this.lstReport.ItemHeight = 16;
            this.lstReport.Location = new System.Drawing.Point(509, 157);
            this.lstReport.Name = "lstReport";
            this.lstReport.Size = new System.Drawing.Size(367, 228);
            this.lstReport.TabIndex = 5;
            // 
            // lblGenerateDailyReport
            // 
            this.lblGenerateDailyReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerateDailyReport.Location = new System.Drawing.Point(312, 80);
            this.lblGenerateDailyReport.Name = "lblGenerateDailyReport";
            this.lblGenerateDailyReport.Size = new System.Drawing.Size(228, 23);
            this.lblGenerateDailyReport.TabIndex = 6;
            this.lblGenerateDailyReport.Text = "Generate Daily Report";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Lime;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.Location = new System.Drawing.Point(365, 419);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(117, 52);
            this.btnConfirm.TabIndex = 20;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDaily);
            this.tabControl1.Controls.Add(this.tabMonthly);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(109, 30);
            this.tabControl1.TabIndex = 22;
            // 
            // tabMonthly
            // 
            this.tabMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMonthly.Location = new System.Drawing.Point(4, 25);
            this.tabMonthly.Name = "tabMonthly";
            this.tabMonthly.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonthly.Size = new System.Drawing.Size(101, 1);
            this.tabMonthly.TabIndex = 1;
            this.tabMonthly.Text = "Monthly";
            this.tabMonthly.ToolTipText = "Monthly";
            this.tabMonthly.UseVisualStyleBackColor = true;
            // 
            // tabDaily
            // 
            this.tabDaily.BackColor = System.Drawing.Color.White;
            this.tabDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDaily.Location = new System.Drawing.Point(4, 25);
            this.tabDaily.Name = "tabDaily";
            this.tabDaily.Padding = new System.Windows.Forms.Padding(3);
            this.tabDaily.Size = new System.Drawing.Size(101, 1);
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
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnBack.Location = new System.Drawing.Point(856, 435);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 62);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // GenerateDailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 495);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblGenerateDailyReport);
            this.Controls.Add(this.lstReport);
            this.Controls.Add(this.mthCalendar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GenerateDailyReport";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MonthCalendar mthCalendar;
        private System.Windows.Forms.ListBox lstReport;
        private System.Windows.Forms.Label lblGenerateDailyReport;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMonthly;
        private System.Windows.Forms.TabPage tabDaily;
    }
}

