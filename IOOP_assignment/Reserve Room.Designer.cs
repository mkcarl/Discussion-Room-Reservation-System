
namespace IOOP_assignment
{
    partial class FormReserve
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
            this.components = new System.ComponentModel.Container();
            this.radDaphneReserve = new System.Windows.Forms.RadioButton();
            this.radCedarReserve = new System.Windows.Forms.RadioButton();
            this.radBlackThornReserve = new System.Windows.Forms.RadioButton();
            this.radAmberReseve = new System.Windows.Forms.RadioButton();
            this.comboTimeReserve = new System.Windows.Forms.ComboBox();
            this.comboPeopleReserve = new System.Windows.Forms.ComboBox();
            this.lblPeopleReserve = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.confirmToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.comboDurationReserve = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBackReserve = new System.Windows.Forms.Button();
            this.btnConfirmReservation = new System.Windows.Forms.Button();
            this.monthCalendarReserve = new IOOP_assignment.MyMonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picUserUser = new System.Windows.Forms.PictureBox();
            this.lblTitleUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserUser)).BeginInit();
            this.SuspendLayout();
            // 
            // radDaphneReserve
            // 
            this.radDaphneReserve.AutoSize = true;
            this.radDaphneReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDaphneReserve.Location = new System.Drawing.Point(649, 170);
            this.radDaphneReserve.Name = "radDaphneReserve";
            this.radDaphneReserve.Size = new System.Drawing.Size(106, 30);
            this.radDaphneReserve.TabIndex = 15;
            this.radDaphneReserve.TabStop = true;
            this.radDaphneReserve.Text = "Daphne";
            this.radDaphneReserve.UseVisualStyleBackColor = true;
            this.radDaphneReserve.CheckedChanged += new System.EventHandler(this.radDaphneReserve_CheckedChanged);
            // 
            // radCedarReserve
            // 
            this.radCedarReserve.AutoSize = true;
            this.radCedarReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCedarReserve.Location = new System.Drawing.Point(649, 135);
            this.radCedarReserve.Name = "radCedarReserve";
            this.radCedarReserve.Size = new System.Drawing.Size(89, 30);
            this.radCedarReserve.TabIndex = 14;
            this.radCedarReserve.TabStop = true;
            this.radCedarReserve.Text = "Cedar";
            this.radCedarReserve.UseVisualStyleBackColor = true;
            this.radCedarReserve.CheckedChanged += new System.EventHandler(this.radCedarReserve_CheckedChanged);
            // 
            // radBlackThornReserve
            // 
            this.radBlackThornReserve.AutoSize = true;
            this.radBlackThornReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlackThornReserve.Location = new System.Drawing.Point(491, 170);
            this.radBlackThornReserve.Name = "radBlackThornReserve";
            this.radBlackThornReserve.Size = new System.Drawing.Size(139, 30);
            this.radBlackThornReserve.TabIndex = 13;
            this.radBlackThornReserve.TabStop = true;
            this.radBlackThornReserve.Text = "BlackThorn";
            this.radBlackThornReserve.UseVisualStyleBackColor = true;
            this.radBlackThornReserve.CheckedChanged += new System.EventHandler(this.radBlackThornReserve_CheckedChanged);
            // 
            // radAmberReseve
            // 
            this.radAmberReseve.AutoSize = true;
            this.radAmberReseve.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAmberReseve.Location = new System.Drawing.Point(491, 135);
            this.radAmberReseve.Name = "radAmberReseve";
            this.radAmberReseve.Size = new System.Drawing.Size(95, 30);
            this.radAmberReseve.TabIndex = 12;
            this.radAmberReseve.TabStop = true;
            this.radAmberReseve.Text = "Amber";
            this.radAmberReseve.UseVisualStyleBackColor = true;
            this.radAmberReseve.CheckedChanged += new System.EventHandler(this.radAmberReseve_CheckedChanged);
            // 
            // comboTimeReserve
            // 
            this.comboTimeReserve.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTimeReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTimeReserve.FormattingEnabled = true;
            this.comboTimeReserve.Location = new System.Drawing.Point(491, 341);
            this.comboTimeReserve.Name = "comboTimeReserve";
            this.comboTimeReserve.Size = new System.Drawing.Size(303, 33);
            this.comboTimeReserve.TabIndex = 11;
            this.comboTimeReserve.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboPeopleReserve
            // 
            this.comboPeopleReserve.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPeopleReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPeopleReserve.FormattingEnabled = true;
            this.comboPeopleReserve.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboPeopleReserve.Location = new System.Drawing.Point(491, 95);
            this.comboPeopleReserve.Name = "comboPeopleReserve";
            this.comboPeopleReserve.Size = new System.Drawing.Size(195, 33);
            this.comboPeopleReserve.TabIndex = 10;
            this.comboPeopleReserve.SelectedIndexChanged += new System.EventHandler(this.comboPeopleReserve_SelectedIndexChanged);
            // 
            // lblPeopleReserve
            // 
            this.lblPeopleReserve.AutoSize = true;
            this.lblPeopleReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeopleReserve.Location = new System.Drawing.Point(486, 66);
            this.lblPeopleReserve.Name = "lblPeopleReserve";
            this.lblPeopleReserve.Size = new System.Drawing.Size(204, 26);
            this.lblPeopleReserve.TabIndex = 9;
            this.lblPeopleReserve.Text = "Number of People";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1123, 620);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 49);
            this.button3.TabIndex = 17;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // confirmToolTip
            // 
            this.confirmToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.confirmToolTip.ToolTipTitle = "Confirm Reservation";
            // 
            // comboDurationReserve
            // 
            this.comboDurationReserve.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDurationReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDurationReserve.FormattingEnabled = true;
            this.comboDurationReserve.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboDurationReserve.Location = new System.Drawing.Point(491, 258);
            this.comboDurationReserve.Name = "comboDurationReserve";
            this.comboDurationReserve.Size = new System.Drawing.Size(303, 33);
            this.comboDurationReserve.TabIndex = 19;
            this.comboDurationReserve.SelectedIndexChanged += new System.EventHandler(this.comboDurationReserve_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::IOOP_assignment.Properties.Resources.duration;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(460, 230);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::IOOP_assignment.Properties.Resources.time;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(460, 313);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::IOOP_assignment.Properties.Resources.people_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(460, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnBackReserve
            // 
            this.btnBackReserve.BackgroundImage = global::IOOP_assignment.Properties.Resources.back_button_6_921315;
            this.btnBackReserve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBackReserve.FlatAppearance.BorderSize = 0;
            this.btnBackReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackReserve.Location = new System.Drawing.Point(882, 439);
            this.btnBackReserve.Name = "btnBackReserve";
            this.btnBackReserve.Size = new System.Drawing.Size(50, 50);
            this.btnBackReserve.TabIndex = 25;
            this.btnBackReserve.UseVisualStyleBackColor = true;
            this.btnBackReserve.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnConfirmReservation
            // 
            this.btnConfirmReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmReservation.Location = new System.Drawing.Point(532, 410);
            this.btnConfirmReservation.Name = "btnConfirmReservation";
            this.btnConfirmReservation.Size = new System.Drawing.Size(219, 49);
            this.btnConfirmReservation.TabIndex = 24;
            this.btnConfirmReservation.Text = "Confirm Reservation";
            this.btnConfirmReservation.UseVisualStyleBackColor = true;
            this.btnConfirmReservation.Click += new System.EventHandler(this.btnConfirmReservation_Click);
            // 
            // monthCalendarReserve
            // 
            this.monthCalendarReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendarReserve.Location = new System.Drawing.Point(77, 122);
            this.monthCalendarReserve.Name = "monthCalendarReserve";
            this.monthCalendarReserve.TabIndex = 26;
            this.monthCalendarReserve.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarReserve_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "Duration (hr)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(491, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "Time";
            // 
            // picUserUser
            // 
            this.picUserUser.Image = global::IOOP_assignment.Properties.Resources.add1;
            this.picUserUser.Location = new System.Drawing.Point(57, 39);
            this.picUserUser.Name = "picUserUser";
            this.picUserUser.Size = new System.Drawing.Size(75, 78);
            this.picUserUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserUser.TabIndex = 30;
            this.picUserUser.TabStop = false;
            // 
            // lblTitleUser
            // 
            this.lblTitleUser.AutoSize = true;
            this.lblTitleUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblTitleUser.Location = new System.Drawing.Point(138, 56);
            this.lblTitleUser.Name = "lblTitleUser";
            this.lblTitleUser.Size = new System.Drawing.Size(254, 36);
            this.lblTitleUser.TabIndex = 29;
            this.lblTitleUser.Text = "Make Reservation";
            // 
            // FormReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.picUserUser);
            this.Controls.Add(this.lblTitleUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendarReserve);
            this.Controls.Add(this.btnBackReserve);
            this.Controls.Add(this.btnConfirmReservation);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboDurationReserve);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.radDaphneReserve);
            this.Controls.Add(this.radCedarReserve);
            this.Controls.Add(this.radBlackThornReserve);
            this.Controls.Add(this.radAmberReseve);
            this.Controls.Add(this.comboTimeReserve);
            this.Controls.Add(this.comboPeopleReserve);
            this.Controls.Add(this.lblPeopleReserve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReserve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserve Room";
            this.Load += new System.EventHandler(this.FormReserve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radDaphneReserve;
        private System.Windows.Forms.RadioButton radCedarReserve;
        private System.Windows.Forms.RadioButton radBlackThornReserve;
        private System.Windows.Forms.RadioButton radAmberReseve;
        private System.Windows.Forms.ComboBox comboTimeReserve;
        private System.Windows.Forms.ComboBox comboPeopleReserve;
        private System.Windows.Forms.Label lblPeopleReserve;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip confirmToolTip;
        private System.Windows.Forms.ComboBox comboDurationReserve;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnBackReserve;
        private System.Windows.Forms.Button btnConfirmReservation;
        private MyMonthCalendar monthCalendarReserve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picUserUser;
        private System.Windows.Forms.Label lblTitleUser;
    }
}