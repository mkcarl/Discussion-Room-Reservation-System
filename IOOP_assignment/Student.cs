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
        private string surname;
        private string givenName; 
        private string email;
        private Form mainForm;

        public Student(string studentID, string password, string surname, string givenName, string email)
        {
            this.studentID = studentID;
            this.password = password;
            this.email = email;
            this.Surname = surname;
            this.GivenName = givenName;
        }

        public string StudentID { get => studentID; set => studentID = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public Form MainForm { get => mainForm; set => mainForm = value; }
        public string Surname { get => surname; set => surname = value; }
        public string GivenName { get => givenName; set => givenName = value; }
    }
}
