
namespace AppTodoList
{
    public partial class Form1 : Form
    {
        private List<CustomTask> tasks = new List<CustomTask>();
        private List<CustomTask> todayTasks = new List<CustomTask>();
        private List<CustomTask> tomorrowTasks = new List<CustomTask>();
        private int nextTaskId = 1;  // Để tạo ID duy nhất cho mỗi công việc

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
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells["Done"];
                bool isChecked = (bool)checkBoxCell.EditedFormattedValue;

                var taskId = (int)dataGridView1.Rows[e.RowIndex].Cells["ID"].Value;  // Lấy ID công việc
                var task = tasks.FirstOrDefault(t => t.ID == taskId);

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

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void UpdateDataGridView(List<CustomTask> taskList)
        {
            dataGridView1.Rows.Clear();
            foreach (var task in taskList)
            {
                dataGridView1.Rows.Add(task.ID,task.ThongTin, task.StartDate.ToShortDateString(), task.EndDate.ToShortDateString(), task.Done);
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
                var newTask = new CustomTask
                {
                    ID = nextTaskId++,  // Gán ID duy nhất cho công việc mới
                    ThongTin = task,
                    StartDate = startDate,
                    EndDate = endDate,
                    Done = false
                };
                tasks.Add(newTask);
                textBox1.Clear();
                UpdateFilteredTasks(monthCalendar1.SelectionRange.Start);
                UpdateDataGridView(tasks);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                var taskId = (int)row.Cells["ID"].Value;
                tasks.RemoveAll(t => t.ID == taskId);
            }

            UpdateFilteredTasks(monthCalendar1.SelectionRange.Start);
            UpdateDataGridView(tasks);
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