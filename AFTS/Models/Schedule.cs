using System;
using System.Collections.Generic;

namespace AFTS.Models
{
    public partial class Schedule
    {
        public int ScheduleId { get; set; }
        public Event EventId { get; set; }
        public Member MemberId { get; set; }
    }
}
