using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_DB.Data.Models
{
    public class Exam : Entity
    {
        public double Mark { get; set; }
        public Subject Subject { get; set; }
        public Journal Journal { get; set; }

        public Exam(double mark, Subject subject, Journal journal)
        {
            Mark = mark;
            Subject = subject;
            Journal = journal;
        }
     
    }
}
