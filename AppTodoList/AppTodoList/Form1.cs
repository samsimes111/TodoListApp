
namespace AppTodoList
{
    public partial class Form1 : Form
    {
        private List<CustomTask> tasks = new List<CustomTask>();
        private List<CustomTask> todayTasks = new List<CustomTask>();
        private List<CustomTask> tomorrowTasks = new List<CustomTask>();

        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionRange.Start;
            UpdateFilteredTasks(selectedDate);
        }

        private void UpdateFilteredTasks(DateTime selectedDate)
        {
            var tasksForSelectedDate = tasks.Where(t => t.StartDate.Date <= selectedDate && t.EndDate.Date >= selectedDate).ToList();
            UpdateDataGridView(tasksForSelectedDate);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Done"].Index && e.RowIndex >= 0)
            {
                // Lưu giá trị checkBox
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells["Done"];
                bool isChecked = (bool)checkBoxCell.EditedFormattedValue;

                var taskInfo = dataGridView1.Rows[e.RowIndex].Cells["ThongTin"].Value;
                if (taskInfo != null)
                {
                    string taskInfoStr = (string)taskInfo;
                    CustomTask? task = tasks.FirstOrDefault(t => t.ThongTin == taskInfoStr);

                    // Thông báo trạng thái job
                    if (task != null)
                    {
                        task.Done = isChecked;

                        if (isChecked)
                            MessageBox.Show("Công việc đã được hoàn thành!", "Trạng Thái Công Việc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Công việc đã cập nhật chưa hoàn thành!", "Trạng Thái Công Việc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            DateTime selectedDate = monthCalendar1.SelectionRange.Start;
            UpdateFilteredTasks(selectedDate);
            UpdateDataGridView(tasks);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Chinh sua thong tin trong data grid view
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var newValue = cell.Value;
                var task = tasks[e.RowIndex];

                switch (e.ColumnIndex)
                {
                    case 0:
                        task.ThongTin = (string)newValue;
                        break;
                    case 1:
                        task.StartDate = DateTime.Parse((string)newValue);
                        break;
                    case 2:
                        task.EndDate = DateTime.Parse((string)newValue);
                        break;
                    case 3:
                        task.Done = (bool)newValue;
                        break;
                }
            }
        }

        private void UpdateDataGridView(List<CustomTask> taskList)
        {
            dataGridView1.Rows.Clear();
            foreach (var task in taskList)
            {
                dataGridView1.Rows.Add(task.ThongTin, task.StartDate.ToShortDateString(), task.EndDate.ToShortDateString(), task.Done);
            }
        }

        //Button_Click
        private void addButton_Click(object sender, EventArgs e)
        {
            string task = textBox1.Text.Trim();
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;

            if (!string.IsNullOrEmpty(task))
            {
                tasks.Add(new CustomTask { ThongTin = task, StartDate = startDate, EndDate = endDate, Done = false });
                textBox1.Clear();
                UpdateFilteredTasks(monthCalendar1.SelectionRange.Start);
                UpdateDataGridView(tasks);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                var taskInfo = row.Cells["ThongTin"].Value.ToString();
                tasks.RemoveAll(t => t.ThongTin == taskInfo);
            }

            UpdateFilteredTasks(monthCalendar1.SelectionRange.Start);
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            UpdateDataGridView(tasks);
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            var completedTasks = tasks.Where(t => t.Done).ToList();
            if (completedTasks.Count == 0)
                MessageBox.Show("Chưa có công việc nào hoàn thành", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                UpdateDataGridView(completedTasks);
        }

        private void todayButton_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            todayTasks = tasks.Where(t => t.StartDate.Date <= today && t.EndDate.Date >= today && !t.Done).ToList();
            UpdateDataGridView(todayTasks);
        }

        private void tomorowButton_Click(object sender, EventArgs e)
        {
            DateTime tomorrow = DateTime.Today.AddDays(1);
            tomorrowTasks = tasks.Where(t => t.StartDate.Date <= tomorrow && t.EndDate.Date >= tomorrow && !t.Done).ToList();
            UpdateDataGridView(tomorrowTasks);
        }
    }
}