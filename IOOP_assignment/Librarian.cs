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

        public Librarian(string studentID, string password, string fullName, string email):base(studentID, password, fullName, email) // inheriting from the base class
        {
            
        }

        public string LibrarianID { get => librarianID; set => librarianID = value; }
       
    }
}
