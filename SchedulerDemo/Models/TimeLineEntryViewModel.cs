using Kendo.Mvc.UI;
using System;
 

namespace SchedulerDemo.Models
{
    public class TimeLineEntryViewModel : ISchedulerEvent
    {
        public Guid EntryId { get; set; } = Guid.NewGuid();


        public Guid LocationAreaId { get; set; }

        public string Title { get; set; } = string.Empty;


        private DateTime start;
        public DateTime Start
        {
            get
            {
                return start;
            }
            set
            {
                start = value;
            }
        }

        public string StartTimezone { get; set; } = string.Empty;

        private DateTime end;

        public DateTime End
        {
            get
            {
                return end;
            }
            set
            {
                end = value;

            }
        }




        public string EndTimezone { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsAllDay { get; set; } = false;
        public string RecurrenceRule { get; set; } = string.Empty;
        public string RecurrenceException { get; set; } = string.Empty;
    }
}
