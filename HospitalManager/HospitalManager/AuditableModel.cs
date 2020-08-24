﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManager
{
    public class AuditableModel
    {
        public int CreatedById { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int? ModifiedById{ get; set; }
        public DateTime? ModifiedDateTime { get; set; }
    }
}
