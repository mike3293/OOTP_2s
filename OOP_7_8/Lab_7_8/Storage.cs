using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_8
{
    public class Storage
    {
        DataContractJsonSerializer jsonformatter = new DataContractJsonSerializer(typeof(List<MyTask>));

        private string path = "Tasks.json";

        public List<MyTask> GetMyTasks()
        {
            bool flagRewrite = false;
            List<MyTask> tasks;
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                try
                {
                    tasks = (List<MyTask>)jsonformatter.ReadObject(fs);
                    tasks = tasks.OrderBy((x) => x.Title).ToList();
                }
                catch
                {
                    tasks = new List<MyTask>();
                    flagRewrite = true;
                }
            }
            if (flagRewrite)
            {
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    jsonformatter.WriteObject(fs, tasks);
                }
            }
            return tasks;
        }


        public void AddMyTask(MyTask task)
        {
            var list = GetMyTasks();
            list.Add(task);
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                jsonformatter.WriteObject(fs, list);
            }
        }

        public void RemoveMyTask(MyTask task)
        {
            var list = GetMyTasks();
            list.RemoveAll(x => x.Title == task.Title && x.Category == task.Category&& x.StartTime == task.StartTime);
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                jsonformatter.WriteObject(fs, list);
            }
        }

        public void EditMyTask(MyTask task, MyTask task2)
        {
            if (task != null && task2 != null)
            {
                RemoveMyTask(task);
                AddMyTask(task2);
            }
        }
    }
}
