using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_8
{
    [Serializable]
    public class MyTask
    {

        public MyTask(MyTask task)
        {
            if (task != null)
            {
                this.Title = task.Title;
                this.Category = task.Category;
                this.Priority = task.Priority;
                this.StartTime = task.StartTime;
                this.Status = task.Status;
                this.Description = task.Description;
            }
        }

        public MyTask(string title, string category, string priority, DateTime startTime, string status, string description)
        {
            Title = title;
            Category = category;
            Priority = priority;
            StartTime = startTime;
            Status = status;
            Description = description;
        }

        public string Title { get; set; }
        public string Category { get; set; }
        public string Priority { get; set; }
        public DateTime StartTime { get; set; }
        public string GetStartTime{ get { return StartTime.ToShortDateString(); } }
        public string Status { get; set; }
        public string Description { get; set; }
    }
}
