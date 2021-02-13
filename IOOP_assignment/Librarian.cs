using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_assignment
{
    class Librarian : Student
    {
        private string librarianID;

        public Librarian(string studentID, string password, string fullName, string email, string librarianID):base(studentID, password, fullName, email) // inheriting from the base class
        {
            this.librarianID = librarianID;
        }

        public string LibrarianID { get => librarianID; set => librarianID = value; }
       
    }
}
