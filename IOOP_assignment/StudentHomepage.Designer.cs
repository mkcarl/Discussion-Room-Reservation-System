
namespace IOOP_assignment
{
    partial class formStudentHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formStudentHomepage));
            this.lblWelcome_SHomepage = new System.Windows.Forms.Label();
            this.lblPrompt_SHomepage = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnLogout_SHomepage = new System.Windows.Forms.Button();
            this.btnRequestStatus_SHomepage = new System.Windows.Forms.Button();
            this.btnModifyReservation_SHomepage = new System.Windows.Forms.Button();
            this.btnReserveRoom_SHomepage = new System.Windows.Forms.Button();
            this.pbxProfilePic_SHomepage = new System.Windows.Forms.PictureBox();
            this.lblDay_SHomepage = new System.Windows.Forms.Label();
            this.lblDate_SHomepage = new System.Windows.Forms.Label();
            this.lblTime_SHomepage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfilePic_SHomepage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome_SHomepage
            // 
            this.lblWelcome_SHomepage.AutoSize = true;
            this.lblWelcome_SHomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome_SHomepage.Location = new System.Drawing.Point(22, 32);
            this.lblWelcome_SHomepage.Name = "lblWelcome_SHomepage";
            this.lblWelcome_SHomepage.Size = new System.Drawing.Size(311, 37);
            this.lblWelcome_SHomepage.TabIndex = 0;
            this.lblWelcome_SHomepage.Text = "Welcome (Surname)";
            // 
            // lblPrompt_SHomepage
            // 
            this.lblPrompt_SHomepage.AutoSize = true;
            this.lblPrompt_SHomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt_SHomepage.Location = new System.Drawing.Point(22, 83);
            this.lblPrompt_SHomepage.Name = "lblPrompt_SHomepage";
            this.lblPrompt_SHomepage.Size = new System.Drawing.Size(382, 37);
            this.lblPrompt_SHomepage.TabIndex = 1;
            this.lblPrompt_SHomepage.Text = "What do you want to do? ";
            this.lblPrompt_SHomepage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout_SHomepage
            // 
            this.btnLogout_SHomepage.BackgroundImage = global::IOOP_assignment.Properties.Resources.logout;
            this.btnLogout_SHomepage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout_SHomepage.FlatAppearance.BorderSize = 0;
            this.btnLogout_SHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout_SHomepage.Location = new System.Drawing.Point(724, 230);
            this.btnLogout_SHomepage.Name = "btnLogout_SHomepage";
            this.btnLogout_SHomepage.Size = new System.Drawing.Size(150, 150);
            this.btnLogout_SHomepage.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnLogout_SHomepage, "Logout");
            this.btnLogout_SHomepage.UseVisualStyleBackColor = true;
            this.btnLogout_SHomepage.Click += new System.EventHandler(this.btnLogout_SHomepage_Click);
            // 
            // btnRequestStatus_SHomepage
            // 
            this.btnRequestStatus_SHomepage.BackgroundImage = global::IOOP_assignment.Properties.Resources.status;
            this.btnRequestStatus_SHomepage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRequestStatus_SHomepage.FlatAppearance.BorderSize = 0;
            this.btnRequestStatus_SHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestStatus_SHomepage.Location = new System.Drawing.Point(506, 230);
            this.btnRequestStatus_SHomepage.Name = "btnRequestStatus_SHomepage";
            this.btnRequestStatus_SHomepage.Size = new System.Drawing.Size(150, 150);
            this.btnRequestStatus_SHomepage.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnRequestStatus_SHomepage, "Check reservation status");
            this.btnRequestStatus_SHomepage.UseVisualStyleBackColor = true;
            // 
            // btnModifyReservation_SHomepage
            // 
            this.btnModifyReservation_SHomepage.BackgroundImage = global::IOOP_assignment.Properties.Resources.modify;
            this.btnModifyReservation_SHomepage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModifyReservation_SHomepage.FlatAppearance.BorderSize = 0;
            this.btnModifyReservation_SHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyReservation_SHomepage.Location = new System.Drawing.Point(288, 230);
            this.btnModifyReservation_SHomepage.Name = "btnModifyReservation_SHomepage";
            this.btnModifyReservation_SHomepage.Size = new System.Drawing.Size(150, 150);
            this.btnModifyReservation_SHomepage.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnModifyReservation_SHomepage, "Modify reservation");
            this.btnModifyReservation_SHomepage.UseVisualStyleBackColor = true;
            // 
            // btnReserveRoom_SHomepage
            // 
            this.btnReserveRoom_SHomepage.BackgroundImage = global::IOOP_assignment.Properties.Resources.add1;
            this.btnReserveRoom_SHomepage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReserveRoom_SHomepage.FlatAppearance.BorderSize = 0;
            this.btnReserveRoom_SHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserveRoom_SHomepage.Location = new System.Drawing.Point(70, 230);
            this.btnReserveRoom_SHomepage.Name = "btnReserveRoom_SHomepage";
            this.btnReserveRoom_SHomepage.Size = new System.Drawing.Size(150, 150);
            this.btnReserveRoom_SHomepage.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnReserveRoom_SHomepage, "Reserve a room");
            this.btnReserveRoom_SHomepage.UseVisualStyleBackColor = true;
            // 
            // pbxProfilePic_SHomepage
            // 
            this.pbxProfilePic_SHomepage.Image = ((System.Drawing.Image)(resources.GetObject("pbxProfilePic_SHomepage.Image")));
            this.pbxProfilePic_SHomepage.Location = new System.Drawing.Point(410, 20);
            this.pbxProfilePic_SHomepage.Name = "pbxProfilePic_SHomepage";
            this.pbxProfilePic_SHomepage.Size = new System.Drawing.Size(100, 100);
            this.pbxProfilePic_SHomepage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProfilePic_SHomepage.TabIndex = 2;
            this.pbxProfilePic_SHomepage.TabStop = false;
            this.toolTip1.SetToolTip(this.pbxProfilePic_SHomepage, "Edit profile");
            // 
            // lblDay_SHomepage
            // 
            this.lblDay_SHomepage.AutoSize = true;
            this.lblDay_SHomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay_SHomepage.Location = new System.Drawing.Point(780, 22);
            this.lblDay_SHomepage.Name = "lblDay_SHomepage";
            this.lblDay_SHomepage.Size = new System.Drawing.Size(140, 29);
            this.lblDay_SHomepage.TabIndex = 7;
            this.lblDay_SHomepage.Text = "Wednesday";
            // 
            // lblDate_SHomepage
            // 
            this.lblDate_SHomepage.AutoSize = true;
            this.lblDate_SHomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate_SHomepage.Location = new System.Drawing.Point(734, 51);
            this.lblDate_SHomepage.Name = "lblDate_SHomepage";
            this.lblDate_SHomepage.Size = new System.Drawing.Size(186, 29);
            this.lblDate_SHomepage.TabIndex = 8;
            this.lblDate_SHomepage.Text = "26 January 2021";
            // 
            // lblTime_SHomepage
            // 
            this.lblTime_SHomepage.AutoSize = true;
            this.lblTime_SHomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime_SHomepage.Location = new System.Drawing.Point(807, 80);
            this.lblTime_SHomepage.Name = "lblTime_SHomepage";
            this.lblTime_SHomepage.Size = new System.Drawing.Size(113, 29);
            this.lblTime_SHomepage.TabIndex = 9;
            this.lblTime_SHomepage.Text = "10:01 PM";
            // 
            // formStudentHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.lblTime_SHomepage);
            this.Controls.Add(this.lblDate_SHomepage);
            this.Controls.Add(this.lblDay_SHomepage);
            this.Controls.Add(this.btnLogout_SHomepage);
            this.Controls.Add(this.btnRequestStatus_SHomepage);
            this.Controls.Add(this.btnModifyReservation_SHomepage);
            this.Controls.Add(this.btnReserveRoom_SHomepage);
            this.Controls.Add(this.pbxProfilePic_SHomepage);
            this.Controls.Add(this.lblPrompt_SHomepage);
            this.Controls.Add(this.lblWelcome_SHomepage);
            this.Name = "formStudentHomepage";
            this.Text = "Homepage";
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfilePic_SHomepage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome_SHomepage;
        private System.Windows.Forms.Label lblPrompt_SHomepage;
        private System.Windows.Forms.PictureBox pbxProfilePic_SHomepage;
        private System.Windows.Forms.Button btnReserveRoom_SHomepage;
        private System.Windows.Forms.Button btnModifyReservation_SHomepage;
        private System.Windows.Forms.Button btnRequestStatus_SHomepage;
        private System.Windows.Forms.Button btnLogout_SHomepage;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblDay_SHomepage;
        private System.Windows.Forms.Label lblDate_SHomepage;
        private System.Windows.Forms.Label lblTime_SHomepage;
    }
}