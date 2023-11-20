using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.EntityLayer.Entities
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string ContactFooterTitle { get; set; }
        public string Location { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
    }
}
