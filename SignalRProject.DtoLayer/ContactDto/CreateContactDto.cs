﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.DtoLayer.ContactDto
{
    public class CreateContactDto
    {
        public string ContactFooterTitle { get; set; }
        public string Location { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
    }
}
