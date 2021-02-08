﻿
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
            this.lblPendingStudentReq = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number_of_Students = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudentRequests
            // 
            this.dgvStudentRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Time,
            this.Room_Name,
            this.Number_of_Students,
            this.Status});
            this.dgvStudentRequests.Location = new System.Drawing.Point(75, 84);
            this.dgvStudentRequests.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStudentRequests.Name = "dgvStudentRequests";
            this.dgvStudentRequests.RowHeadersWidth = 51;
            this.dgvStudentRequests.RowTemplate.Height = 24;
            this.dgvStudentRequests.Size = new System.Drawing.Size(1117, 452);
            this.dgvStudentRequests.TabIndex = 0;
            this.dgvStudentRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblPendingStudentReq
            // 
            this.lblPendingStudentReq.AutoSize = true;
            this.lblPendingStudentReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingStudentReq.Location = new System.Drawing.Point(428, 25);
            this.lblPendingStudentReq.Name = "lblPendingStudentReq";
            this.lblPendingStudentReq.Size = new System.Drawing.Size(395, 36);
            this.lblPendingStudentReq.TabIndex = 2;
            this.lblPendingStudentReq.Text = "Pending Student Requests";
            // 
            // btnConfirm
            // 
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(377, 559);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(167, 45);
            this.btnConfirm.TabIndex = 78;
            this.btnConfirm.Text = "Reject";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::IOOP_assignment.Properties.Resources.pending11;
            this.pictureBox1.Location = new System.Drawing.Point(353, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 66);
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
            this.btnBack.Location = new System.Drawing.Point(1172, 559);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 55);
            this.btnBack.TabIndex = 77;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(673, 559);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 43);
            this.button1.TabIndex = 80;
            this.button1.Text = "Approve";
            this.button1.UseVisualStyleBackColor = true;
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
            this.Time.FillWeight = 60F;
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
            this.Number_of_Students.FillWeight = 60F;
            this.Number_of_Students.HeaderText = "Number of Students";
            this.Number_of_Students.MinimumWidth = 6;
            this.Number_of_Students.Name = "Number_of_Students";
            // 
            // Status
            // 
            this.Status.FillWeight = 75F;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            // 
            // Form_Pending_Student_Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1259, 617);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPendingStudentReq);
            this.Controls.Add(this.dgvStudentRequests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Pending_Student_Requests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pending Student Requests";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentRequests;
        private System.Windows.Forms.Label lblPendingStudentReq;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number_of_Students;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}