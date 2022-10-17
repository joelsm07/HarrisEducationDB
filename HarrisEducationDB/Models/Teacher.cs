using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisEducationDB.Models
{
    public class Teacher
    {
        public int teacherID { get; set; }
        public string teacherName { get; set; }
        public string teacherLastName { get; set; }
        public int gender { get; set; }
        public int address { get; set; }
    }
}
