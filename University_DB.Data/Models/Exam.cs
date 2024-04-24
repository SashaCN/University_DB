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
        public Guid Subject_id { get; set; }
        public Guid Journal_id { get; set; }
        public Subject Subject { get; set; }
        public Journal Journal { get; set; }

        public Exam() { }

        public Exam(double mark, Guid subjectId, Guid journalId)
        {
            Mark = mark;
            Subject_id = subjectId;
            Journal_id = journalId;
        }
     
    }
}
