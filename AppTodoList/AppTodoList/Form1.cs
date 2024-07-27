using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Windows.Forms;

namespace AppTodoList
{
    public partial class Form1 : Form
    {
        private List<Task> tasks = new List<Task>();
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
            //Them Task
            string task = textBox1.Text.Trim();
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;
            if (!string.IsNullOrEmpty(task))
            {
                dataGridView1.Rows.Add(task, startDate.ToShortDateString(), endDate.ToShortDateString());
                textBox1.Clear();
            }

            //Sap xep cac cong viec

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


            //Hien thi thong bao khi hoan thanh
            if (e.ColumnIndex == dataGridView1.Columns["Done"].Index && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell thongBao = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells["Done"];
                bool isChecked = (bool)thongBao.EditedFormattedValue;

                if (isChecked) MessageBox.Show("Hoàn thành!", "Trạng Thái Công Việc", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                else MessageBox.Show("Đã Cật Nhật", "Trạng Thái Công Việc", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }




        }

        private void dataGridView1_ColumnSortModeChanged(object sender, DataGridViewColumnEventArgs e)
        {
            int i = 0;
            if (i > 0)
                this.dataGridView1.Columns["startDate"].SortMode = DataGridViewColumnSortMode.Automatic;
            i++;
        }

       
    }
}