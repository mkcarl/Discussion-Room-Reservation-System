
namespace IOOP_assignment
{
    partial class PendingStudentRequests
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
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number_Of_Students = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPendingStudentReq = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudentRequests
            // 
            this.dgvStudentRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Day,
            this.Room,
            this.Number_Of_Students,
            this.Status});
            this.dgvStudentRequests.Location = new System.Drawing.Point(43, 67);
            this.dgvStudentRequests.Name = "dgvStudentRequests";
            this.dgvStudentRequests.RowHeadersWidth = 51;
            this.dgvStudentRequests.RowTemplate.Height = 24;
            this.dgvStudentRequests.Size = new System.Drawing.Size(1158, 500);
            this.dgvStudentRequests.TabIndex = 0;
            this.dgvStudentRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            // 
            // Day
            // 
            this.Day.HeaderText = "Day";
            this.Day.MinimumWidth = 6;
            this.Day.Name = "Day";
            // 
            // Room
            // 
            this.Room.HeaderText = "Room";
            this.Room.MinimumWidth = 6;
            this.Room.Name = "Room";
            // 
            // Number_Of_Students
            // 
            this.Number_Of_Students.HeaderText = "Number_Of_Students";
            this.Number_Of_Students.MinimumWidth = 6;
            this.Number_Of_Students.Name = "Number_Of_Students";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            // 
            // lblPendingStudentReq
            // 
            this.lblPendingStudentReq.AutoSize = true;
            this.lblPendingStudentReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingStudentReq.Location = new System.Drawing.Point(462, 24);
            this.lblPendingStudentReq.Name = "lblPendingStudentReq";
            this.lblPendingStudentReq.Size = new System.Drawing.Size(268, 25);
            this.lblPendingStudentReq.TabIndex = 2;
            this.lblPendingStudentReq.Text = "Pending Student Requests";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Lime;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.Location = new System.Drawing.Point(525, 597);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(129, 52);
            this.btnConfirm.TabIndex = 20;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // PendingStudentRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblPendingStudentReq);
            this.Controls.Add(this.dgvStudentRequests);
            this.Name = "PendingStudentRequests";
            this.Text = "PendingStudentRequests";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentRequests;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number_Of_Students;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label lblPendingStudentReq;
        private System.Windows.Forms.Button btnConfirm;
    }
}