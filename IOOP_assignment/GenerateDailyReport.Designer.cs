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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMonthly = new System.Windows.Forms.TabPage();
            this.tabDaily = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mthCalendar
            // 
            this.mthCalendar.Location = new System.Drawing.Point(67, 165);
            this.mthCalendar.Name = "mthCalendar";
            this.mthCalendar.TabIndex = 4;
            // 
            // lstReport
            // 
            this.lstReport.FormattingEnabled = true;
            this.lstReport.ItemHeight = 16;
            this.lstReport.Location = new System.Drawing.Point(513, 130);
            this.lstReport.Name = "lstReport";
            this.lstReport.Size = new System.Drawing.Size(407, 260);
            this.lstReport.TabIndex = 5;
            // 
            // lblGenerateDailyReport
            // 
            this.lblGenerateDailyReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerateDailyReport.Location = new System.Drawing.Point(310, 55);
            this.lblGenerateDailyReport.Name = "lblGenerateDailyReport";
            this.lblGenerateDailyReport.Size = new System.Drawing.Size(228, 23);
            this.lblGenerateDailyReport.TabIndex = 6;
            this.lblGenerateDailyReport.Text = "Generate Daily Report";
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(360, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 45);
            this.button1.TabIndex = 42;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
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
            this.btnBack.Location = new System.Drawing.Point(856, 439);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 56);
            this.btnBack.TabIndex = 43;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // GenerateDailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMonthly;
        private System.Windows.Forms.TabPage tabDaily;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBack;
    }
}

