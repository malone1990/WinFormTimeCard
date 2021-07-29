using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WinFormTimeCard.Models
{
    public class TimeEntryInfo
    {
        public int UserId { get; set; }

        public int TimeEntryId { get; set; }
        public double? TotalHours { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        public UserInfo User { get; set; }
        public ICollection<TimeCardInfo> TimeCards { get; set; }
    }
}
