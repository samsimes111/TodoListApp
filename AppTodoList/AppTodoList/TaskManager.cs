using System;
using System.Collections.Generic;
using System.Linq;

namespace AppTodoList
{
    public class TaskManager
    {
        private List<CustomTask> tasks = new List<CustomTask>();
        private int nextTaskId = 1;

        public List<CustomTask> Tasks => tasks;

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
        }

        public void DeleteTask(int taskId)
        {
            tasks.RemoveAll(t => t.ID == taskId);
        }

        public void UpdateTaskStatus(int taskId, bool done)
        {
            var task = tasks.FirstOrDefault(t => t.ID == taskId);
            if (task != null)
            {
                task.Done = done;
            }
        }

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
