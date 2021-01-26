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
            this.btnDaily = new System.Windows.Forms.Button();
            this.btnMonthly = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.mthCalendar = new System.Windows.Forms.MonthCalendar();
            this.lstReport = new System.Windows.Forms.ListBox();
            this.lblGenerateDailyReport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDaily
            // 
            this.btnDaily.Location = new System.Drawing.Point(-1, 0);
            this.btnDaily.Name = "btnDaily";
            this.btnDaily.Size = new System.Drawing.Size(100, 53);
            this.btnDaily.TabIndex = 0;
            this.btnDaily.Text = "Daily";
            this.btnDaily.UseVisualStyleBackColor = true;
            // 
            // btnMonthly
            // 
            this.btnMonthly.Location = new System.Drawing.Point(96, 0);
            this.btnMonthly.Name = "btnMonthly";
            this.btnMonthly.Size = new System.Drawing.Size(100, 53);
            this.btnMonthly.TabIndex = 1;
            this.btnMonthly.Text = "Monthly";
            this.btnMonthly.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::IOOP_assignment.Properties.Resources.back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBack.Location = new System.Drawing.Point(1163, 612);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 61);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Location = new System.Drawing.Point(463, 480);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(148, 47);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // mthCalendar
            // 
            this.mthCalendar.Location = new System.Drawing.Point(232, 171);
            this.mthCalendar.Name = "mthCalendar";
            this.mthCalendar.TabIndex = 4;
            // 
            // lstReport
            // 
            this.lstReport.FormattingEnabled = true;
            this.lstReport.ItemHeight = 16;
            this.lstReport.Location = new System.Drawing.Point(647, 145);
            this.lstReport.Name = "lstReport";
            this.lstReport.Size = new System.Drawing.Size(509, 276);
            this.lstReport.TabIndex = 5;
            // 
            // lblGenerateDailyReport
            // 
            this.lblGenerateDailyReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerateDailyReport.Location = new System.Drawing.Point(458, 78);
            this.lblGenerateDailyReport.Name = "lblGenerateDailyReport";
            this.lblGenerateDailyReport.Size = new System.Drawing.Size(219, 23);
            this.lblGenerateDailyReport.TabIndex = 6;
            this.lblGenerateDailyReport.Text = "Generate Daily Report";
            // 
            // GenerateDailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.lblGenerateDailyReport);
            this.Controls.Add(this.lstReport);
            this.Controls.Add(this.mthCalendar);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMonthly);
            this.Controls.Add(this.btnDaily);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GenerateDailyReport";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDaily;
        private System.Windows.Forms.Button btnMonthly;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.MonthCalendar mthCalendar;
        private System.Windows.Forms.ListBox lstReport;
        private System.Windows.Forms.Label lblGenerateDailyReport;
    }
}

