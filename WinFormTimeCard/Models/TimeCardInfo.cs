using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WinFormTimeCard.Models
{
    public class TimeCardInfo
    {
        public int TimeEntryId { get; set; }
        public int TiemCardId { get; set; }
        public double MonInfo { get; set; }
        public double TueInfo { get; set; }
        public double WedInfo { get; set; }
        public double ThuInfo { get; set; }
        public double FriInfo { get; set; }
        public double SatInfo { get; set; }
        public double SunInfo { get; set; }
        public double Count { get; set; }

        public TimeEntryInfo TimeEntry { get; set; }
    }
}
