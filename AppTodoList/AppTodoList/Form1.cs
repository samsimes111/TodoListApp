
namespace AppTodoList
{

    public partial class Form1 : Form
    {
        private List<CustomTask> tasks = new List<CustomTask>();
        private List<CustomTask> dateTasks = new List<CustomTask>();
       
        public Form1()
        {
            InitializeComponent();
            
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            DateTime selectedDate = monthCalendar1.SelectionRange.Start;

            var tasksForSelectedDate = tasks.Where(t => t.StartDate.Date <= selectedDate && t.EndDate.Date >= selectedDate).ToList();

            //Cat nhat dateTask
            dateTasks.Clear();
            foreach (var task in tasksForSelectedDate)
            {
                if (task.Done == false)
                    dateTasks.Add(task);
            }

            UpdateDataGridView();
        }
        private void UpdateDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var task in dateTasks)
            {
                dataGridView1.Rows.Add(task.ThongTin, task.StartDate.ToShortDateString(), task.EndDate.ToShortDateString(), task.Done);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void todayButton_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView1.Columns["Done"].Index && e.RowIndex >= 0)
            {
                //Luu gia tri checkBox
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells["Done"];
                bool isChecked = (bool)checkBoxCell.EditedFormattedValue;

                var taskInfo = dataGridView1.Rows[e.RowIndex].Cells["ThongTin"].Value;
                CustomTask? task = null;
                foreach (var t in tasks)
                {
                    if (t.ThongTin == (string)taskInfo)
                    {
                        task = t;
                        break;
                    }
                }

                //Thong bao trang thai job
                if (task != null)
                {
                    task.Done = isChecked;

                    if (isChecked)
                        MessageBox.Show("Công việc đã được hoàn thành!", "Trạng Thái Công Việc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Công việc đã cật nhật chưa hoàn thành!", "Trạng Thái Công Việc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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

        //Button_Click
        private void addButton_Click(object sender, EventArgs e)
        {

            string task = textBox1.Text.Trim();
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;

            if (!string.IsNullOrEmpty(task))
            {
                //Them vao task
                tasks.Add(new CustomTask { ThongTin = task, StartDate = startDate, EndDate = endDate, Done = false });

                //Them vao dataGridView
                dataGridView1.Rows.Add(task, startDate.ToShortDateString(), endDate.ToShortDateString(), false);

                textBox1.Clear();
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }

            //Cat nhat task
            tasks.RemoveAll(t => dataGridView1.Rows.Cast<DataGridViewRow>().All(r => r.Cells["ThongTin"].Value.ToString() != t.ThongTin));


        }
        private void allButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (var task in tasks)
            {
                dataGridView1.Rows.Add(task.ThongTin, task.StartDate.ToShortDateString(), task.EndDate.ToShortDateString(), task.Done);
            }
        }
        private void completeButton_Click(object sender, EventArgs e)
        {
            int Count = 0;
            dataGridView1.Rows.Clear();
            foreach (var task in tasks)
            {
                if (task.Done)
                {
                    dataGridView1.Rows.Add(task.ThongTin, task.StartDate.ToShortDateString(), task.EndDate.ToShortDateString(), task.Done);
                    Count++;
                }

            }
            if (Count == 0) MessageBox.Show("Chưa công việc nào hoàn thành", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        
    }

}