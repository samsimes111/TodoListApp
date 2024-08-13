using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace AppTodoList
{
    public class TaskManager
    {
        private List<CustomTask> tasks = new List<CustomTask>();
        private int nextTaskId = 1;

        public List<CustomTask> Tasks => tasks;

        private const string filePath = "tasks.json";

        // data Button
        public void AddTask(string thongTin, DateTime startDate, DateTime endDate)
        {
            var newTask = new CustomTask
            {
                ID = nextTaskId++,
                ThongTin = thongTin,
                StartDate = startDate,
                EndDate = endDate,
                Done = false
            };
            tasks.Add(newTask);
            SaveTasks();
        }

        public void SaveTasks()
        {
            string json = JsonConvert.SerializeObject(tasks, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
        public void LoadTasks()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                tasks = JsonConvert.DeserializeObject<List<CustomTask>>(json) ?? new List<CustomTask>();
            }
        }
        public List<CustomTask> GetTasks()
        {
            return tasks;
        }

        public void DeleteTask(int taskId)
        {
            tasks.RemoveAll(t => t.ID == taskId);
            SaveTasks();
        }

        public void UpdateTaskStatus(int taskId, bool done)
        {
            var task = tasks.FirstOrDefault(t => t.ID == taskId);
            if (task != null)
            {
                task.Done = done;
            }
            SaveTasks();
        }

        //Chinh sua thong tin datagridview
        public void UpdateTaskInfo(int taskId, string newInfo)
        {
            var task = tasks.FirstOrDefault(t => t.ID == taskId);
            if (task != null)
            {
                task.ThongTin = newInfo;
            }
            SaveTasks();
        }
        public void UpdateTaskStartDate(int taskId, DateTime newStartDate)
        {
            var task = tasks.FirstOrDefault(t => t.ID == taskId);
            if (task != null)
            {
                task.StartDate = newStartDate;
            }
            SaveTasks();
        }

        public void UpdateTaskEndDate(int taskId, DateTime newEndDate)
        {
            var task = tasks.FirstOrDefault(t => t.ID == taskId);
            if (task != null)
            {
                task.EndDate = newEndDate;
            }
            SaveTasks();
        }

        //select date
        public void SelectDatetime(DateTime startDate, DateTime endDate)
        {

            
            if (startDate.Date > endDate.Date)
            {
                DateTime t = endDate.Date;
                startDate = endDate.Date;
                endDate = t.Date;
            }
            SaveTasks();
        }



        //Get Tasks
        public List<CustomTask> GetTasksForDate(DateTime date)
        {
            return tasks.Where(t => t.StartDate.Date <= date && t.EndDate.Date >= date).ToList();
        }

        public List<CustomTask> GetCompletedTasks()
        {
            return tasks.Where(t => t.Done).ToList();
        }

        public List<CustomTask> GetTodayTasks()
        {
            DateTime today = DateTime.Today;
            return tasks.Where(t => t.StartDate.Date <= today && t.EndDate.Date >= today && !t.Done).ToList();
        }

        public List<CustomTask> GetTomorrowTasks()
        {
            DateTime tomorrow = DateTime.Today.AddDays(1);
            return tasks.Where(t => t.StartDate.Date <= tomorrow && t.EndDate.Date >= tomorrow && !t.Done).ToList();
        }
    }
}
