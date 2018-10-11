using System;
using System.Collections.Generic;

namespace AFTS.Models
{
    public partial class Schedule
    {
        public int ScheduleId { get; set; }

        public int MemberId { get; set; }

        public int EventId { get; set; }


        public Event Event { get; set; }

        public Member Member { get; set; }
    }
}
