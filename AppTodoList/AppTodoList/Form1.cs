using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace AppTodoList
{
    public class CustomTask
    {
        public required string ThongTin { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Done { get; set; }
    }
    public partial class Form1 : Form
    {
        private List<CustomTask> tasks = new List<CustomTask>();

        public Form1()
        {
            InitializeComponent();
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string task = textBox1.Text.Trim();
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;
            if (!string.IsNullOrEmpty(task))
            {
                dataGridView1.Rows.Add(task, startDate.ToShortDateString(), endDate.ToShortDateString());
                textBox1.Clear();
            }



        }

        private void deleteButton_Click(object sender, EventArgs e)
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
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells["Done"];
                bool isChecked = (bool)checkBoxCell.EditedFormattedValue;

                if (isChecked)
                {
                    MessageBox.Show("Hoàn thành!", "Trạng Thái Công Việc", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("Đã Cật Nhật!", "Trạng Thái Công Việc", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
        }


        private void completeButton_Click(object sender, EventArgs e)
        {

        }
    }
}