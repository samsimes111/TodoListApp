using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace AppTodoList
{
    public partial class Form1 : BaseForm
    {
        private TaskManager taskManager = new TaskManager();

        public Form1()
        {
            InitializeComponent();
        }

        //Calendar
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionRange.Start;
            UpdateFilteredTasks(selectedDate);


        }

        private void UpdateFilteredTasks(DateTime selectedDate)
        {
            var tasksForSelectedDate = taskManager.GetTasksForDate(selectedDate);
            UpdateDataGridView(tasksForSelectedDate);
        }



        //Button

        private void addButton_Click(object sender, EventArgs e)
        {
            string task = textBox1.Text.Trim();
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;

            if (!string.IsNullOrEmpty(task))
            {
                taskManager.AddTask(task, startDate, endDate);
                textBox1.Clear();
                UpdateFilteredTasks(monthCalendar1.SelectionRange.Start);
                UpdateDataGridView(taskManager.Tasks);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                var taskId = (int)row.Cells["ID"].Value;
                taskManager.DeleteTask(taskId);
            }

            UpdateFilteredTasks(monthCalendar1.SelectionRange.Start);
            UpdateDataGridView(taskManager.Tasks);

        }

        private void allButton_Click(object sender, EventArgs e)
        {
            UpdateDataGridView(taskManager.Tasks);
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            var completedTasks = taskManager.GetCompletedTasks();
            if (completedTasks.Count == 0)
                ShowMessage("Chưa có công việc nào hoàn thành", "Lỗi", MessageBoxIcon.Error);
            else
                UpdateDataGridView(completedTasks);
        }

        private void todayButton_Click(object sender, EventArgs e)
        {
            var todayTasks = taskManager.GetTodayTasks();
            UpdateDataGridView(todayTasks);
        }

        private void tomorowButton_Click(object sender, EventArgs e)
        {
            var tomorrowTasks = taskManager.GetTomorrowTasks();
            UpdateDataGridView(tomorrowTasks);
        }

        //Data
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Done"].Index && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells["Done"];
                bool isChecked = (bool)checkBoxCell.EditedFormattedValue;

                var taskId = (int)dataGridView1.Rows[e.RowIndex].Cells["ID"].Value;
                taskManager.UpdateTaskStatus(taskId, isChecked);

                if (isChecked)
                    ShowMessage("Công việc đã được hoàn thành!", "Trạng Thái Công Việc", MessageBoxIcon.Information);
                else
                    ShowMessage("Công việc đã cập nhật chưa hoàn thành!", "Trạng Thái Công Việc", MessageBoxIcon.Information);
            }
        }

        private void UpdateDataGridView(List<CustomTask> taskList)
        {
            dataGridView1.Rows.Clear();
            foreach (var task in taskList)
            {
                dataGridView1.Rows.Add(task.ID, task.ThongTin, task.StartDate.ToShortDateString(), task.EndDate.ToShortDateString(), task.Done);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var taskId = (int)dataGridView1.Rows[e.RowIndex].Cells["ID"].Value;

            if (e.ColumnIndex == dataGridView1.Columns["ThongTin"].Index)
            {
                string newInfo = (string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                taskManager.UpdateTaskInfo(taskId, newInfo);
                UpdateFilteredTasks(monthCalendar1.SelectionRange.Start);

            }
            else if (e.ColumnIndex == dataGridView1.Columns["StartDate"].Index || e.ColumnIndex == dataGridView1.Columns["EndDate"].Index)
            {
                string newDateValue = (string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                DateTime newDate;

                if (DateTime.TryParse(newDateValue, out newDate))
                {
                    if (e.ColumnIndex == dataGridView1.Columns["StartDate"].Index)
                        taskManager.UpdateTaskStartDate(taskId, newDate);

                    else if (e.ColumnIndex == dataGridView1.Columns["EndDate"].Index)
                        taskManager.UpdateTaskEndDate(taskId, newDate);

                    UpdateFilteredTasks(monthCalendar1.SelectionRange.Start);
                }
                else ShowMessage("Ngày tháng không hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
                dateTimePicker2.Value = dateTimePicker1.Value;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
                dateTimePicker2.Value = dateTimePicker1.Value;
        } 
    }
}
