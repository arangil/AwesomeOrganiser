using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeOrganiser.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public string TaskTitle { get; set; }
        public string TaskDescription { get; set; }
        public DateTime TaskDueDate { get; set; }
        public bool IsComplete { get; set; }
        public string TaskComments { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
