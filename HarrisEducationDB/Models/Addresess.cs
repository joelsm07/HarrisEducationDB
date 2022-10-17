using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisEducationDB.Models
{
    public class Address
    {
        public int addressId { get; set}
        public string addressLine1 { get; set }
        public string addressLine2 { get; set; }
        public string county { get; set; }
        public string city { get; set; }

        public string PostCode { get; set }
    }
}
