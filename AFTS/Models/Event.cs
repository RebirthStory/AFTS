﻿using System;
using System.Collections.Generic;

namespace AFTS.Models
{
    public partial class Event
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public DateTime Date { get; set; }

        public Member Member { get; set; }
    }
}
