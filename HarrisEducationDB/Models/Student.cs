using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisEducationDB.Models
{
    public class Student
    {
        public int studentID { get; set; }
        public string studentName { get; set; }
        public string studentLastName { get; set; }
        public int gender { get; set; }
        public int address { get; set; }
    }
}
