using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_DB.Data.Models
{
    public class Subject : Entity
    {
        public string Name { get; set; }
        public Exam Exam { get; set; }
        public List<Specialization>? Specializations { get; set; }

        public Subject(string name)
        {
            Name = name;
        }
    }
}
