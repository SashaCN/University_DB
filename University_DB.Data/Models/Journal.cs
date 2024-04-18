using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_DB.Data.Models
{
    public class Journal : Entity
    {
        public Student Student { get; set; }
        public List<Exam>? Exams { get; set; }

        public Journal(Student student)
        {
            Student = student;
        }
    }
}
