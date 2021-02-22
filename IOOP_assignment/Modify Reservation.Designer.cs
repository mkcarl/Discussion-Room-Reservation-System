
namespace IOOP_assignment
{
    partial class FormModify
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
            this.comboTimeNewModify = new System.Windows.Forms.ComboBox();
            this.radAmberNewModify = new System.Windows.Forms.RadioButton();
            this.radBlackThornNewModify = new System.Windows.Forms.RadioButton();
            this.radCedarNewModify = new System.Windows.Forms.RadioButton();
            this.radDaphneNewModify = new System.Windows.Forms.RadioButton();
            this.btnCancelModify = new System.Windows.Forms.Button();
            this.btnConfirmModification = new System.Windows.Forms.Button();
            this.mthCalendarNewModify = new System.Windows.Forms.MonthCalendar();
            this.comboPeopleNewModify = new System.Windows.Forms.ComboBox();
            this.lblTitleNewModify = new System.Windows.Forms.Label();
            this.lblNoPeopleCurrentModify = new System.Windows.Forms.Label();
            this.lblCurrentTitleModify = new System.Windows.Forms.Label();
            this.lblDateCurrentModify = new System.Windows.Forms.Label();
            this.lblTimeCurrentModify = new System.Windows.Forms.Label();
            this.lblRoomCurrentModify = new System.Windows.Forms.Label();
            this.btnBackModify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboTimeNewModify
            // 
            this.comboTimeNewModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTimeNewModify.FormattingEnabled = true;
            this.comboTimeNewModify.Items.AddRange(new object[] {
            "8:00 am",
            "9:00 am",
            "10:00 am",
            "11:00 am",
            "12:00 pm",
            "1:00 pm",
            "2:00 pm",
            "3:00 pm",
            "4:00 pm",
            "5:00 pm",
            "6:00 pm",
            "7:00 pm",
            ""});
            this.comboTimeNewModify.Location = new System.Drawing.Point(640, 156);
            this.comboTimeNewModify.Name = "comboTimeNewModify";
            this.comboTimeNewModify.Size = new System.Drawing.Size(224, 33);
            this.comboTimeNewModify.TabIndex = 3;
            this.comboTimeNewModify.Text = "-Select a Time-";
            this.comboTimeNewModify.SelectedIndexChanged += new System.EventHandler(this.comboTimeNewModify_SelectedIndexChanged);
            // 
            // radAmberNewModify
            // 
            this.radAmberNewModify.AutoSize = true;
            this.radAmberNewModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radAmberNewModify.Location = new System.Drawing.Point(645, 203);
            this.radAmberNewModify.Name = "radAmberNewModify";
            this.radAmberNewModify.Size = new System.Drawing.Size(85, 28);
            this.radAmberNewModify.TabIndex = 4;
            this.radAmberNewModify.TabStop = true;
            this.radAmberNewModify.Text = "Amber";
            this.radAmberNewModify.UseVisualStyleBackColor = true;
            this.radAmberNewModify.CheckedChanged += new System.EventHandler(this.radAmberNewModify_CheckedChanged);
            // 
            // radBlackThornNewModify
            // 
            this.radBlackThornNewModify.AutoSize = true;
            this.radBlackThornNewModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radBlackThornNewModify.Location = new System.Drawing.Point(645, 243);
            this.radBlackThornNewModify.Name = "radBlackThornNewModify";
            this.radBlackThornNewModify.Size = new System.Drawing.Size(124, 28);
            this.radBlackThornNewModify.TabIndex = 5;
            this.radBlackThornNewModify.TabStop = true;
            this.radBlackThornNewModify.Text = "BlackThorn";
            this.radBlackThornNewModify.UseVisualStyleBackColor = true;
            this.radBlackThornNewModify.CheckedChanged += new System.EventHandler(this.radBlackThornNewModify_CheckedChanged);
            // 
            // radCedarNewModify
            // 
            this.radCedarNewModify.AutoSize = true;
            this.radCedarNewModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radCedarNewModify.Location = new System.Drawing.Point(645, 283);
            this.radCedarNewModify.Name = "radCedarNewModify";
            this.radCedarNewModify.Size = new System.Drawing.Size(79, 28);
            this.radCedarNewModify.TabIndex = 6;
            this.radCedarNewModify.TabStop = true;
            this.radCedarNewModify.Text = "Cedar";
            this.radCedarNewModify.UseVisualStyleBackColor = true;
            this.radCedarNewModify.CheckedChanged += new System.EventHandler(this.radCedarNewModify_CheckedChanged);
            // 
            // radDaphneNewModify
            // 
            this.radDaphneNewModify.AutoSize = true;
            this.radDaphneNewModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radDaphneNewModify.Location = new System.Drawing.Point(645, 323);
            this.radDaphneNewModify.Name = "radDaphneNewModify";
            this.radDaphneNewModify.Size = new System.Drawing.Size(95, 28);
            this.radDaphneNewModify.TabIndex = 7;
            this.radDaphneNewModify.TabStop = true;
            this.radDaphneNewModify.Text = "Daphne";
            this.radDaphneNewModify.UseVisualStyleBackColor = true;
            this.radDaphneNewModify.CheckedChanged += new System.EventHandler(this.radDaphneNewModify_CheckedChanged);
            // 
            // btnCancelModify
            // 
            this.btnCancelModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelModify.Location = new System.Drawing.Point(372, 367);
            this.btnCancelModify.Name = "btnCancelModify";
            this.btnCancelModify.Size = new System.Drawing.Size(185, 49);
            this.btnCancelModify.TabIndex = 8;
            this.btnCancelModify.Text = "Cancel Booking";
            this.btnCancelModify.UseVisualStyleBackColor = true;
            this.btnCancelModify.Click += new System.EventHandler(this.btnResetModify_Click);
            // 
            // btnConfirmModification
            // 
            this.btnConfirmModification.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmModification.Location = new System.Drawing.Point(609, 367);
            this.btnConfirmModification.Name = "btnConfirmModification";
            this.btnConfirmModification.Size = new System.Drawing.Size(219, 49);
            this.btnConfirmModification.TabIndex = 9;
            this.btnConfirmModification.Text = "Confirm Modification";
            this.btnConfirmModification.UseVisualStyleBackColor = true;
            this.btnConfirmModification.Click += new System.EventHandler(this.btnConfirmModification_Click);
            // 
            // mthCalendarNewModify
            // 
            this.mthCalendarNewModify.Location = new System.Drawing.Point(366, 113);
            this.mthCalendarNewModify.MaxSelectionCount = 1;
            this.mthCalendarNewModify.Name = "mthCalendarNewModify";
            this.mthCalendarNewModify.TabIndex = 17;
            this.mthCalendarNewModify.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mthCalendarNewModify_DateChanged);
            // 
            // comboPeopleNewModify
            // 
            this.comboPeopleNewModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPeopleNewModify.FormattingEnabled = true;
            this.comboPeopleNewModify.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboPeopleNewModify.Location = new System.Drawing.Point(640, 111);
            this.comboPeopleNewModify.Name = "comboPeopleNewModify";
            this.comboPeopleNewModify.Size = new System.Drawing.Size(224, 33);
            this.comboPeopleNewModify.TabIndex = 19;
            this.comboPeopleNewModify.Text = "-Number of People-";
            this.comboPeopleNewModify.SelectedIndexChanged += new System.EventHandler(this.comboPeopleNewModify_SelectedIndexChanged);
            // 
            // lblTitleNewModify
            // 
            this.lblTitleNewModify.AutoSize = true;
            this.lblTitleNewModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitleNewModify.Location = new System.Drawing.Point(366, 69);
            this.lblTitleNewModify.Name = "lblTitleNewModify";
            this.lblTitleNewModify.Size = new System.Drawing.Size(216, 26);
            this.lblTitleNewModify.TabIndex = 20;
            this.lblTitleNewModify.Text = "Modify Reservation";
            // 
            // lblNoPeopleCurrentModify
            // 
            this.lblNoPeopleCurrentModify.AutoSize = true;
            this.lblNoPeopleCurrentModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblNoPeopleCurrentModify.Location = new System.Drawing.Point(58, 205);
            this.lblNoPeopleCurrentModify.Name = "lblNoPeopleCurrentModify";
            this.lblNoPeopleCurrentModify.Size = new System.Drawing.Size(188, 26);
            this.lblNoPeopleCurrentModify.TabIndex = 11;
            this.lblNoPeopleCurrentModify.Text = "Number of People";
            // 
            // lblCurrentTitleModify
            // 
            this.lblCurrentTitleModify.AutoSize = true;
            this.lblCurrentTitleModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblCurrentTitleModify.Location = new System.Drawing.Point(58, 69);
            this.lblCurrentTitleModify.Name = "lblCurrentTitleModify";
            this.lblCurrentTitleModify.Size = new System.Drawing.Size(225, 26);
            this.lblCurrentTitleModify.TabIndex = 12;
            this.lblCurrentTitleModify.Text = "Current Reservation";
            // 
            // lblDateCurrentModify
            // 
            this.lblDateCurrentModify.AutoSize = true;
            this.lblDateCurrentModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblDateCurrentModify.Location = new System.Drawing.Point(58, 113);
            this.lblDateCurrentModify.Name = "lblDateCurrentModify";
            this.lblDateCurrentModify.Size = new System.Drawing.Size(64, 26);
            this.lblDateCurrentModify.TabIndex = 13;
            this.lblDateCurrentModify.Text = "Date ";
            // 
            // lblTimeCurrentModify
            // 
            this.lblTimeCurrentModify.AutoSize = true;
            this.lblTimeCurrentModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTimeCurrentModify.Location = new System.Drawing.Point(58, 159);
            this.lblTimeCurrentModify.Name = "lblTimeCurrentModify";
            this.lblTimeCurrentModify.Size = new System.Drawing.Size(60, 26);
            this.lblTimeCurrentModify.TabIndex = 14;
            this.lblTimeCurrentModify.Text = "Time";
            // 
            // lblRoomCurrentModify
            // 
            this.lblRoomCurrentModify.AutoSize = true;
            this.lblRoomCurrentModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblRoomCurrentModify.Location = new System.Drawing.Point(58, 251);
            this.lblRoomCurrentModify.Name = "lblRoomCurrentModify";
            this.lblRoomCurrentModify.Size = new System.Drawing.Size(71, 26);
            this.lblRoomCurrentModify.TabIndex = 15;
            this.lblRoomCurrentModify.Text = "Room";
            // 
            // btnBackModify
            // 
            this.btnBackModify.BackgroundImage = global::IOOP_assignment.Properties.Resources.back_button_6_921315;
            this.btnBackModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBackModify.FlatAppearance.BorderSize = 0;
            this.btnBackModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackModify.Location = new System.Drawing.Point(882, 439);
            this.btnBackModify.Name = "btnBackModify";
            this.btnBackModify.Size = new System.Drawing.Size(50, 50);
            this.btnBackModify.TabIndex = 16;
            this.btnBackModify.UseVisualStyleBackColor = true;
            this.btnBackModify.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.lblTitleNewModify);
            this.Controls.Add(this.comboPeopleNewModify);
            this.Controls.Add(this.mthCalendarNewModify);
            this.Controls.Add(this.btnBackModify);
            this.Controls.Add(this.lblRoomCurrentModify);
            this.Controls.Add(this.lblTimeCurrentModify);
            this.Controls.Add(this.lblDateCurrentModify);
            this.Controls.Add(this.lblCurrentTitleModify);
            this.Controls.Add(this.lblNoPeopleCurrentModify);
            this.Controls.Add(this.btnConfirmModification);
            this.Controls.Add(this.btnCancelModify);
            this.Controls.Add(this.radDaphneNewModify);
            this.Controls.Add(this.radCedarNewModify);
            this.Controls.Add(this.radBlackThornNewModify);
            this.Controls.Add(this.radAmberNewModify);
            this.Controls.Add(this.comboTimeNewModify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Reservation";
            this.Load += new System.EventHandler(this.FormModify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radAmberNewModify;
        private System.Windows.Forms.RadioButton radBlackThornNewModify;
        private System.Windows.Forms.RadioButton radCedarNewModify;
        private System.Windows.Forms.RadioButton radDaphneNewModify;
        private System.Windows.Forms.Button btnCancelModify;
        private System.Windows.Forms.Button btnConfirmModification;
        private System.Windows.Forms.Button btnBackModify;
        private System.Windows.Forms.MonthCalendar mthCalendarNewModify;
        private System.Windows.Forms.ComboBox comboPeopleNewModify;
        private System.Windows.Forms.Label lblTitleNewModify;
        private System.Windows.Forms.Label lblNoPeopleCurrentModify;
        private System.Windows.Forms.Label lblCurrentTitleModify;
        private System.Windows.Forms.Label lblDateCurrentModify;
        private System.Windows.Forms.Label lblTimeCurrentModify;
        private System.Windows.Forms.Label lblRoomCurrentModify;
        private System.Windows.Forms.ComboBox comboTimeNewModify;
    }
}