
namespace IOOP_assignment
{
    partial class Form_Pending_Student_Requests
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
            this.dgvStudentRequests = new System.Windows.Forms.DataGridView();
            this.Reservation_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number_of_Students = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPendingStudentReq = new System.Windows.Forms.Label();
            this.btnReject = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudentRequests
            // 
            this.dgvStudentRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reservation_ID,
            this.Student_ID,
            this.Date,
            this.Time,
            this.Room_Name,
            this.Number_of_Students,
            this.Status});
            this.dgvStudentRequests.Location = new System.Drawing.Point(56, 68);
            this.dgvStudentRequests.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStudentRequests.Name = "dgvStudentRequests";
            this.dgvStudentRequests.RowHeadersWidth = 51;
            this.dgvStudentRequests.RowTemplate.Height = 24;
            this.dgvStudentRequests.Size = new System.Drawing.Size(838, 367);
            this.dgvStudentRequests.TabIndex = 0;
            this.dgvStudentRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Reservation_ID
            // 
            this.Reservation_ID.FillWeight = 50F;
            this.Reservation_ID.HeaderText = "Reservation ID";
            this.Reservation_ID.MinimumWidth = 6;
            this.Reservation_ID.Name = "Reservation_ID";
            // 
            // Student_ID
            // 
            this.Student_ID.FillWeight = 50F;
            this.Student_ID.HeaderText = "Student ID";
            this.Student_ID.MinimumWidth = 6;
            this.Student_ID.Name = "Student_ID";
            // 
            // Date
            // 
            this.Date.FillWeight = 60F;
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            // 
            // Time
            // 
            this.Time.FillWeight = 40F;
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            // 
            // Room_Name
            // 
            this.Room_Name.HeaderText = "Room Name";
            this.Room_Name.MinimumWidth = 6;
            this.Room_Name.Name = "Room_Name";
            // 
            // Number_of_Students
            // 
            this.Number_of_Students.FillWeight = 65F;
            this.Number_of_Students.HeaderText = "Number of Students";
            this.Number_of_Students.MinimumWidth = 6;
            this.Number_of_Students.Name = "Number_of_Students";
            // 
            // Status
            // 
            this.Status.FillWeight = 50F;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            // 
            // lblPendingStudentReq
            // 
            this.lblPendingStudentReq.AutoSize = true;
            this.lblPendingStudentReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingStudentReq.Location = new System.Drawing.Point(386, 22);
            this.lblPendingStudentReq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPendingStudentReq.Name = "lblPendingStudentReq";
            this.lblPendingStudentReq.Size = new System.Drawing.Size(323, 29);
            this.lblPendingStudentReq.TabIndex = 2;
            this.lblPendingStudentReq.Text = "Pending Student Requests";
            // 
            // btnReject
            // 
            this.btnReject.FlatAppearance.BorderSize = 0;
            this.btnReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.Location = new System.Drawing.Point(283, 454);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(125, 37);
            this.btnReject.TabIndex = 78;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::IOOP_assignment.Properties.Resources.pending11;
            this.pictureBox1.Location = new System.Drawing.Point(318, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::IOOP_assignment.Properties.Resources.back2;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(882, 439);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 50);
            this.btnBack.TabIndex = 77;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.FlatAppearance.BorderSize = 0;
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.Location = new System.Drawing.Point(505, 454);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(125, 35);
            this.btnApprove.TabIndex = 80;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Pending_Student_Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPendingStudentReq);
            this.Controls.Add(this.dgvStudentRequests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Pending_Student_Requests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pending Student Requests";
            this.Load += new System.EventHandler(this.Form_Pending_Student_Requests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentRequests;
        private System.Windows.Forms.Label lblPendingStudentReq;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reservation_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number_of_Students;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}