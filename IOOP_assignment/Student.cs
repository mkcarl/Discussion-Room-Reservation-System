using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_assignment
{
    class Student
    {
        private string studentID;
        private string password;
        private string fullName;
        private string email;
        private Form mainForm; 

        public Student(string studentID, string password, string fullName, string email)
        {
            this.studentID = studentID;
            this.password = password;
            this.fullName = fullName;
            this.email = email;
        }

        public string StudentID { get => studentID; set => studentID = value; }
        public string Password { get => password; set => password = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Email { get => email; set => email = value; }
        public Form MainForm { get => mainForm; set => mainForm = value; }
    }
}
