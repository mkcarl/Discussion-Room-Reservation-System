
namespace IOOP_assignment
{
    partial class formLibrarianHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLibrarianHomepage));
            this.lblPrompt_LHomepage = new System.Windows.Forms.Label();
            this.lblWelcome_LHomepage = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnGenerateReport_LHomepage = new System.Windows.Forms.Button();
            this.btnStudentRequest_LHomepage = new System.Windows.Forms.Button();
            this.btnLogout_LHomepage = new System.Windows.Forms.Button();
            this.btnRequestStatus_LHomepage = new System.Windows.Forms.Button();
            this.btnModifyReservation_LHomepage = new System.Windows.Forms.Button();
            this.btnReserveRoom_LHomepage = new System.Windows.Forms.Button();
            this.lblTime_LHomepage = new System.Windows.Forms.Label();
            this.lblDate_LHomepage = new System.Windows.Forms.Label();
            this.lblDay_LHomepage = new System.Windows.Forms.Label();
            this.pbxProfilePic_LHomepage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfilePic_LHomepage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrompt_LHomepage
            // 
            this.lblPrompt_LHomepage.AutoSize = true;
            this.lblPrompt_LHomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt_LHomepage.Location = new System.Drawing.Point(22, 83);
            this.lblPrompt_LHomepage.Name = "lblPrompt_LHomepage";
            this.lblPrompt_LHomepage.Size = new System.Drawing.Size(382, 37);
            this.lblPrompt_LHomepage.TabIndex = 15;
            this.lblPrompt_LHomepage.Text = "What do you want to do? ";
            this.lblPrompt_LHomepage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcome_LHomepage
            // 
            this.lblWelcome_LHomepage.AutoSize = true;
            this.lblWelcome_LHomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome_LHomepage.Location = new System.Drawing.Point(22, 32);
            this.lblWelcome_LHomepage.Name = "lblWelcome_LHomepage";
            this.lblWelcome_LHomepage.Size = new System.Drawing.Size(311, 37);
            this.lblWelcome_LHomepage.TabIndex = 14;
            this.lblWelcome_LHomepage.Text = "Welcome (Surname)";
            // 
            // btnGenerateReport_LHomepage
            // 
            this.btnGenerateReport_LHomepage.BackgroundImage = global::IOOP_assignment.Properties.Resources.report_edited;
            this.btnGenerateReport_LHomepage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerateReport_LHomepage.FlatAppearance.BorderSize = 0;
            this.btnGenerateReport_LHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport_LHomepage.Location = new System.Drawing.Point(391, 327);
            this.btnGenerateReport_LHomepage.Name = "btnGenerateReport_LHomepage";
            this.btnGenerateReport_LHomepage.Size = new System.Drawing.Size(150, 150);
            this.btnGenerateReport_LHomepage.TabIndex = 18;
            this.toolTip1.SetToolTip(this.btnGenerateReport_LHomepage, "Generate daily/monthly report");
            this.btnGenerateReport_LHomepage.UseVisualStyleBackColor = true;
            // 
            // btnStudentRequest_LHomepage
            // 
            this.btnStudentRequest_LHomepage.BackgroundImage = global::IOOP_assignment.Properties.Resources.pending;
            this.btnStudentRequest_LHomepage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStudentRequest_LHomepage.FlatAppearance.BorderSize = 0;
            this.btnStudentRequest_LHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentRequest_LHomepage.Location = new System.Drawing.Point(97, 327);
            this.btnStudentRequest_LHomepage.Name = "btnStudentRequest_LHomepage";
            this.btnStudentRequest_LHomepage.Size = new System.Drawing.Size(150, 150);
            this.btnStudentRequest_LHomepage.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btnStudentRequest_LHomepage, "Pending student requests");
            this.btnStudentRequest_LHomepage.UseVisualStyleBackColor = true;
            // 
            // btnLogout_LHomepage
            // 
            this.btnLogout_LHomepage.BackgroundImage = global::IOOP_assignment.Properties.Resources.logout;
            this.btnLogout_LHomepage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout_LHomepage.FlatAppearance.BorderSize = 0;
            this.btnLogout_LHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout_LHomepage.Location = new System.Drawing.Point(685, 327);
            this.btnLogout_LHomepage.Name = "btnLogout_LHomepage";
            this.btnLogout_LHomepage.Size = new System.Drawing.Size(150, 150);
            this.btnLogout_LHomepage.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnLogout_LHomepage, "Logout");
            this.btnLogout_LHomepage.UseVisualStyleBackColor = true;
            // 
            // btnRequestStatus_LHomepage
            // 
            this.btnRequestStatus_LHomepage.BackgroundImage = global::IOOP_assignment.Properties.Resources.status;
            this.btnRequestStatus_LHomepage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRequestStatus_LHomepage.FlatAppearance.BorderSize = 0;
            this.btnRequestStatus_LHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestStatus_LHomepage.Location = new System.Drawing.Point(685, 148);
            this.btnRequestStatus_LHomepage.Name = "btnRequestStatus_LHomepage";
            this.btnRequestStatus_LHomepage.Size = new System.Drawing.Size(150, 150);
            this.btnRequestStatus_LHomepage.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnRequestStatus_LHomepage, "Check reservation status");
            this.btnRequestStatus_LHomepage.UseVisualStyleBackColor = true;
            // 
            // btnModifyReservation_LHomepage
            // 
            this.btnModifyReservation_LHomepage.BackgroundImage = global::IOOP_assignment.Properties.Resources.modify;
            this.btnModifyReservation_LHomepage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModifyReservation_LHomepage.FlatAppearance.BorderSize = 0;
            this.btnModifyReservation_LHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyReservation_LHomepage.Location = new System.Drawing.Point(391, 148);
            this.btnModifyReservation_LHomepage.Name = "btnModifyReservation_LHomepage";
            this.btnModifyReservation_LHomepage.Size = new System.Drawing.Size(150, 150);
            this.btnModifyReservation_LHomepage.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnModifyReservation_LHomepage, "Modify a reservation");
            this.btnModifyReservation_LHomepage.UseVisualStyleBackColor = true;
            // 
            // btnReserveRoom_LHomepage
            // 
            this.btnReserveRoom_LHomepage.BackgroundImage = global::IOOP_assignment.Properties.Resources.add1;
            this.btnReserveRoom_LHomepage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReserveRoom_LHomepage.FlatAppearance.BorderSize = 0;
            this.btnReserveRoom_LHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserveRoom_LHomepage.Location = new System.Drawing.Point(97, 148);
            this.btnReserveRoom_LHomepage.Name = "btnReserveRoom_LHomepage";
            this.btnReserveRoom_LHomepage.Size = new System.Drawing.Size(150, 150);
            this.btnReserveRoom_LHomepage.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnReserveRoom_LHomepage, "Reserve a room");
            this.btnReserveRoom_LHomepage.UseVisualStyleBackColor = true;
            // 
            // lblTime_LHomepage
            // 
            this.lblTime_LHomepage.AutoSize = true;
            this.lblTime_LHomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime_LHomepage.Location = new System.Drawing.Point(807, 78);
            this.lblTime_LHomepage.Name = "lblTime_LHomepage";
            this.lblTime_LHomepage.Size = new System.Drawing.Size(113, 29);
            this.lblTime_LHomepage.TabIndex = 21;
            this.lblTime_LHomepage.Text = "10:01 PM";
            // 
            // lblDate_LHomepage
            // 
            this.lblDate_LHomepage.AutoSize = true;
            this.lblDate_LHomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate_LHomepage.Location = new System.Drawing.Point(734, 49);
            this.lblDate_LHomepage.Name = "lblDate_LHomepage";
            this.lblDate_LHomepage.Size = new System.Drawing.Size(186, 29);
            this.lblDate_LHomepage.TabIndex = 20;
            this.lblDate_LHomepage.Text = "26 January 2021";
            // 
            // lblDay_LHomepage
            // 
            this.lblDay_LHomepage.AutoSize = true;
            this.lblDay_LHomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay_LHomepage.Location = new System.Drawing.Point(780, 20);
            this.lblDay_LHomepage.Name = "lblDay_LHomepage";
            this.lblDay_LHomepage.Size = new System.Drawing.Size(140, 29);
            this.lblDay_LHomepage.TabIndex = 19;
            this.lblDay_LHomepage.Text = "Wednesday";
            // 
            // pbxProfilePic_LHomepage
            // 
            this.pbxProfilePic_LHomepage.Image = ((System.Drawing.Image)(resources.GetObject("pbxProfilePic_LHomepage.Image")));
            this.pbxProfilePic_LHomepage.Location = new System.Drawing.Point(410, 20);
            this.pbxProfilePic_LHomepage.Name = "pbxProfilePic_LHomepage";
            this.pbxProfilePic_LHomepage.Size = new System.Drawing.Size(100, 100);
            this.pbxProfilePic_LHomepage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProfilePic_LHomepage.TabIndex = 16;
            this.pbxProfilePic_LHomepage.TabStop = false;
            this.toolTip1.SetToolTip(this.pbxProfilePic_LHomepage, "Edit profile");
            // 
            // formLibrarianHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.lblTime_LHomepage);
            this.Controls.Add(this.lblDate_LHomepage);
            this.Controls.Add(this.lblDay_LHomepage);
            this.Controls.Add(this.btnGenerateReport_LHomepage);
            this.Controls.Add(this.btnStudentRequest_LHomepage);
            this.Controls.Add(this.pbxProfilePic_LHomepage);
            this.Controls.Add(this.lblPrompt_LHomepage);
            this.Controls.Add(this.lblWelcome_LHomepage);
            this.Controls.Add(this.btnLogout_LHomepage);
            this.Controls.Add(this.btnRequestStatus_LHomepage);
            this.Controls.Add(this.btnModifyReservation_LHomepage);
            this.Controls.Add(this.btnReserveRoom_LHomepage);
            this.Name = "formLibrarianHomepage";
            this.Text = "Librarian Homepage";
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfilePic_LHomepage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout_LHomepage;
        private System.Windows.Forms.Button btnRequestStatus_LHomepage;
        private System.Windows.Forms.Button btnModifyReservation_LHomepage;
        private System.Windows.Forms.Button btnReserveRoom_LHomepage;
        private System.Windows.Forms.PictureBox pbxProfilePic_LHomepage;
        private System.Windows.Forms.Label lblPrompt_LHomepage;
        private System.Windows.Forms.Label lblWelcome_LHomepage;
        private System.Windows.Forms.Button btnStudentRequest_LHomepage;
        private System.Windows.Forms.Button btnGenerateReport_LHomepage;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblTime_LHomepage;
        private System.Windows.Forms.Label lblDate_LHomepage;
        private System.Windows.Forms.Label lblDay_LHomepage;
    }
}