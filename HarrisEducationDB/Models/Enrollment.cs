using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisEducationDB.Models
{
    public class Enrollment
    {
        public int enrollmentID { get; set; }
        public int studentID { get; set; }
        public int courseID { get; set; }
    }
}
