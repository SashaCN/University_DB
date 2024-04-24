using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace University_DB.Data.Models
{
    public class Student : User
    {
        public int JournalId { get; set; }
        public int SpecializationlId { get; set; } 
        public Journal Journal { get; set; }
        public Specialization? Specialization { get; set; }

        public Student(string name, string surname, string email, string password) : base(name, surname, email, password)
        {
            Journal = new Journal(this);
        }
    }
}
