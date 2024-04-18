using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_DB.Data.Models
{
    public class Teacher : User
    {
        public double Salary { get; set; } = 10000;
        // public List<Specialization> Specializations { get; set; }
        public Teacher(string name, string surname, string email, string password) : base(name, surname, email, password)
        {
        }
    }
}
