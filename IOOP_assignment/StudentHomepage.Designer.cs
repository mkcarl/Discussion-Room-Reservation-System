
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfilePic_SHomepage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome_SHomepage
            // 
            this.lblWelcome_SHomepage.AutoSize = true;
            this.lblWelcome_SHomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome_SHomepage.Location = new System.Drawing.Point(45, 45);
            this.lblWelcome_SHomepage.Name = "lblWelcome_SHomepage";
            this.lblWelcome_SHomepage.Size = new System.Drawing.Size(311, 37);
            this.lblWelcome_SHomepage.TabIndex = 0;
            this.lblWelcome_SHomepage.Text = "Welcome (Surname)";
            // 
            // lblPrompt_SHomepage
            // 
            this.lblPrompt_SHomepage.AutoSize = true;
            this.lblPrompt_SHomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt_SHomepage.Location = new System.Drawing.Point(45, 96);
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
            this.btnLogout_SHomepage.Location = new System.Drawing.Point(982, 271);
            this.btnLogout_SHomepage.Name = "btnLogout_SHomepage";
            this.btnLogout_SHomepage.Size = new System.Drawing.Size(225, 225);
            this.btnLogout_SHomepage.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnLogout_SHomepage, "Logout");
            this.btnLogout_SHomepage.UseVisualStyleBackColor = true;
            // 
            // btnRequestStatus_SHomepage
            // 
            this.btnRequestStatus_SHomepage.BackgroundImage = global::IOOP_assignment.Properties.Resources._56_512;
            this.btnRequestStatus_SHomepage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRequestStatus_SHomepage.FlatAppearance.BorderSize = 0;
            this.btnRequestStatus_SHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestStatus_SHomepage.Location = new System.Drawing.Point(670, 271);
            this.btnRequestStatus_SHomepage.Name = "btnRequestStatus_SHomepage";
            this.btnRequestStatus_SHomepage.Size = new System.Drawing.Size(225, 225);
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
            this.btnModifyReservation_SHomepage.Location = new System.Drawing.Point(358, 271);
            this.btnModifyReservation_SHomepage.Name = "btnModifyReservation_SHomepage";
            this.btnModifyReservation_SHomepage.Size = new System.Drawing.Size(225, 225);
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
            this.btnReserveRoom_SHomepage.Location = new System.Drawing.Point(46, 271);
            this.btnReserveRoom_SHomepage.Name = "btnReserveRoom_SHomepage";
            this.btnReserveRoom_SHomepage.Size = new System.Drawing.Size(225, 225);
            this.btnReserveRoom_SHomepage.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnReserveRoom_SHomepage, "Reserve a room");
            this.btnReserveRoom_SHomepage.UseVisualStyleBackColor = true;
            // 
            // pbxProfilePic_SHomepage
            // 
            this.pbxProfilePic_SHomepage.Image = ((System.Drawing.Image)(resources.GetObject("pbxProfilePic_SHomepage.Image")));
            this.pbxProfilePic_SHomepage.Location = new System.Drawing.Point(433, 33);
            this.pbxProfilePic_SHomepage.Name = "pbxProfilePic_SHomepage";
            this.pbxProfilePic_SHomepage.Size = new System.Drawing.Size(100, 100);
            this.pbxProfilePic_SHomepage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProfilePic_SHomepage.TabIndex = 2;
            this.pbxProfilePic_SHomepage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1087, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Wednesday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1041, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "26 January 2021";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1114, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "10:01 PM";
            // 
            // formStudentHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}