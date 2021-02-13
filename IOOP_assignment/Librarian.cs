using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_assignment
{
    class Librarian : Student
    {
        private string librarianID;

        public Librarian(string studentID, string password, string fullName, string email):base(studentID, password, fullName, email) // inheriting from the base class
        {
            this.librarianID = this.GetLibrarianID();
        }

        public string LibrarianID { get => librarianID; set => librarianID = value; }

        private string GetLibrarianID()
        {
            SqlDataReader dr = Controller.Query("SELECT * FROM Librarian WHERE StudentID=" + this.StudentID);

            if (dr.HasRows)
            {
                dr.Read();
                return dr["LibrarianID"].ToString();
            }
            else
            {
                return "Unknown";
            }

        }
       
    }
}
