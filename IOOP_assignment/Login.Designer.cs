
namespace IOOP_assignment
{
    partial class formLogin
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
            this.txtStudentID_Login = new System.Windows.Forms.TextBox();
            this.txtPassword_Login = new System.Windows.Forms.TextBox();
            this.lblStudentID_Login = new System.Windows.Forms.Label();
            this.lblPassword_Login = new System.Windows.Forms.Label();
            this.btnRegister_Login = new System.Windows.Forms.Button();
            this.btnLogin_Login = new System.Windows.Forms.Button();
            this.pbxApuLogo_Login = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxApuLogo_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStudentID_Login
            // 
            this.txtStudentID_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID_Login.Location = new System.Drawing.Point(54, 272);
            this.txtStudentID_Login.MaxLength = 50;
            this.txtStudentID_Login.Name = "txtStudentID_Login";
            this.txtStudentID_Login.ShortcutsEnabled = false;
            this.txtStudentID_Login.Size = new System.Drawing.Size(300, 32);
            this.txtStudentID_Login.TabIndex = 1;
            this.txtStudentID_Login.TextChanged += new System.EventHandler(this.txtStudentID_Login_TextChanged);
            this.txtStudentID_Login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentID_Login_KeyPress);
            // 
            // txtPassword_Login
            // 
            this.txtPassword_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword_Login.Location = new System.Drawing.Point(54, 345);
            this.txtPassword_Login.MaxLength = 50;
            this.txtPassword_Login.Name = "txtPassword_Login";
            this.txtPassword_Login.Size = new System.Drawing.Size(300, 32);
            this.txtPassword_Login.TabIndex = 2;
            this.txtPassword_Login.UseSystemPasswordChar = true;
            // 
            // lblStudentID_Login
            // 
            this.lblStudentID_Login.AutoSize = true;
            this.lblStudentID_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID_Login.Location = new System.Drawing.Point(49, 243);
            this.lblStudentID_Login.Name = "lblStudentID_Login";
            this.lblStudentID_Login.Size = new System.Drawing.Size(127, 26);
            this.lblStudentID_Login.TabIndex = 3;
            this.lblStudentID_Login.Text = "Student ID :";
            // 
            // lblPassword_Login
            // 
            this.lblPassword_Login.AutoSize = true;
            this.lblPassword_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword_Login.Location = new System.Drawing.Point(49, 316);
            this.lblPassword_Login.Name = "lblPassword_Login";
            this.lblPassword_Login.Size = new System.Drawing.Size(120, 26);
            this.lblPassword_Login.TabIndex = 4;
            this.lblPassword_Login.Text = "Password :";
            // 
            // btnRegister_Login
            // 
            this.btnRegister_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister_Login.Location = new System.Drawing.Point(84, 409);
            this.btnRegister_Login.Name = "btnRegister_Login";
            this.btnRegister_Login.Size = new System.Drawing.Size(100, 45);
            this.btnRegister_Login.TabIndex = 5;
            this.btnRegister_Login.Text = "Register";
            this.btnRegister_Login.UseVisualStyleBackColor = true;
            // 
            // btnLogin_Login
            // 
            this.btnLogin_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin_Login.Location = new System.Drawing.Point(224, 409);
            this.btnLogin_Login.Name = "btnLogin_Login";
            this.btnLogin_Login.Size = new System.Drawing.Size(100, 45);
            this.btnLogin_Login.TabIndex = 6;
            this.btnLogin_Login.Text = "Login";
            this.btnLogin_Login.UseVisualStyleBackColor = true;
            this.btnLogin_Login.Click += new System.EventHandler(this.btnLogin_Login_Click);
            // 
            // pbxApuLogo_Login
            // 
            this.pbxApuLogo_Login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbxApuLogo_Login.Image = global::IOOP_assignment.Properties.Resources.APU_logo;
            this.pbxApuLogo_Login.Location = new System.Drawing.Point(142, 12);
            this.pbxApuLogo_Login.Name = "pbxApuLogo_Login";
            this.pbxApuLogo_Login.Size = new System.Drawing.Size(125, 125);
            this.pbxApuLogo_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxApuLogo_Login.TabIndex = 0;
            this.pbxApuLogo_Login.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(46, 152);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(317, 74);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Discussion Room \r\nReservation System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 501);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogin_Login);
            this.Controls.Add(this.btnRegister_Login);
            this.Controls.Add(this.lblPassword_Login);
            this.Controls.Add(this.lblStudentID_Login);
            this.Controls.Add(this.txtPassword_Login);
            this.Controls.Add(this.txtStudentID_Login);
            this.Controls.Add(this.pbxApuLogo_Login);
            this.Name = "formLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbxApuLogo_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxApuLogo_Login;
        private System.Windows.Forms.TextBox txtStudentID_Login;
        private System.Windows.Forms.TextBox txtPassword_Login;
        private System.Windows.Forms.Label lblStudentID_Login;
        private System.Windows.Forms.Label lblPassword_Login;
        private System.Windows.Forms.Button btnRegister_Login;
        private System.Windows.Forms.Button btnLogin_Login;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}