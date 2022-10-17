using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisEducationDB.Models
{
    internal class Teaching_Material
    {
        public int teachingMaterialID { get; set; }
        public string fileName { get; set; }
        public byte[] filedata { get; set; }
    }
}
