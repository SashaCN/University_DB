using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_DB.Data.Models
{
    public class Specialization : Entity
    {
        public string Name { get; set; }
        public List<Student>? Student { get; set; }
        public List<Teacher>? Teachers { get; set; }
        public List<Subject>? Subjects { get; set; }

        public Specialization(string name) 
        {
            Name = name;
        }
    }
}
