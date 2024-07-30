namespace AppTodoList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            monthCalendar1 = new MonthCalendar();
            addButton = new Button();
            deleteButton = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            ThongTin = new DataGridViewTextBoxColumn();
            startDate = new DataGridViewTextBoxColumn();
            endDate = new DataGridViewTextBoxColumn();
            Done = new DataGridViewCheckBoxColumn();
            completeButton = new Button();
            todayButton = new Button();
            tomorowButton = new Button();
            panel1 = new Panel();
            allButton = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.Gainsboro;
            monthCalendar1.ForeColor = Color.Fuchsia;
            monthCalendar1.Location = new Point(137, 69);
            monthCalendar1.Margin = new Padding(10, 9, 10, 9);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            monthCalendar1.TitleBackColor = Color.Fuchsia;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            monthCalendar1.DateSelected += monthCalendar1_DateChanged;
            // 
            // addButton
            // 
            addButton.BackColor = Color.Fuchsia;
            addButton.BackgroundImageLayout = ImageLayout.Zoom;
            addButton.Location = new Point(934, 102);
            addButton.Name = "addButton";
            addButton.Size = new Size(145, 37);
            addButton.TabIndex = 12;
            addButton.Text = "Thêm";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Fuchsia;
            deleteButton.Location = new Point(1085, 102);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(117, 37);
            deleteButton.TabIndex = 13;
            deleteButton.Text = "Xóa";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.Location = new Point(520, 102);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(384, 57);
            textBox1.TabIndex = 16;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.Fuchsia;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.InfoText;
            label2.Location = new Point(520, 53);
            label2.Name = "label2";
            label2.Size = new Size(116, 36);
            label2.TabIndex = 17;
            label2.Text = "Nhập task";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1016, 20);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(24, 27);
            dateTimePicker1.TabIndex = 23;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(1165, 20);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(24, 27);
            dateTimePicker2.TabIndex = 24;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ThongTin, startDate, endDate, Done });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.ButtonHighlight;
            dataGridView1.ImeMode = ImeMode.Disable;
            dataGridView1.Location = new Point(520, 185);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(682, 355);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ThongTin
            // 
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            ThongTin.DefaultCellStyle = dataGridViewCellStyle3;
            ThongTin.HeaderText = "Thông Tin";
            ThongTin.MinimumWidth = 6;
            ThongTin.Name = "ThongTin";
            ThongTin.Width = 300;
            // 
            // startDate
            // 
            startDate.HeaderText = "Start Date";
            startDate.MinimumWidth = 6;
            startDate.Name = "startDate";
            startDate.Width = 110;
            // 
            // endDate
            // 
            endDate.HeaderText = "End Date";
            endDate.MinimumWidth = 6;
            endDate.Name = "endDate";
            endDate.Width = 110;
            // 
            // Done
            // 
            Done.HeaderText = "Hoàn Thành";
            Done.MinimumWidth = 6;
            Done.Name = "Done";
            Done.Width = 110;
            // 
            // completeButton
            // 
            completeButton.BackColor = Color.Violet;
            completeButton.Location = new Point(63, 188);
            completeButton.Name = "completeButton";
            completeButton.Size = new Size(144, 47);
            completeButton.TabIndex = 14;
            completeButton.Text = "Đã hoàn thành";
            completeButton.UseVisualStyleBackColor = false;
            completeButton.Click += completeButton_Click;
            // 
            // todayButton
            // 
            todayButton.BackColor = Color.Violet;
            todayButton.Location = new Point(63, 76);
            todayButton.Name = "todayButton";
            todayButton.Size = new Size(144, 47);
            todayButton.TabIndex = 8;
            todayButton.Text = "Hôm nay";
            todayButton.UseVisualStyleBackColor = false;
            todayButton.Click += todayButton_Click;
            // 
            // tomorowButton
            // 
            tomorowButton.BackColor = Color.Violet;
            tomorowButton.Location = new Point(63, 132);
            tomorowButton.Name = "tomorowButton";
            tomorowButton.Size = new Size(144, 47);
            tomorowButton.TabIndex = 10;
            tomorowButton.Text = "Ngày mai";
            tomorowButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Violet;
            panel1.Controls.Add(completeButton);
            panel1.Controls.Add(tomorowButton);
            panel1.Controls.Add(todayButton);
            panel1.Controls.Add(allButton);
            panel1.Location = new Point(137, 316);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 246);
            panel1.TabIndex = 26;
            // 
            // allButton
            // 
            allButton.BackColor = Color.Violet;
            allButton.Location = new Point(63, 20);
            allButton.Name = "allButton";
            allButton.Size = new Size(144, 47);
            allButton.TabIndex = 15;
            allButton.Text = "ALL";
            allButton.UseVisualStyleBackColor = false;
            allButton.Click += allButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Fuchsia;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Location = new Point(865, 178);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 355);
            panel2.TabIndex = 27;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Fuchsia;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Location = new Point(976, 178);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 355);
            panel3.TabIndex = 28;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Fuchsia;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Location = new Point(1085, 178);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 355);
            panel4.TabIndex = 29;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Fuchsia;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Location = new Point(520, 185);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 355);
            panel5.TabIndex = 28;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Fuchsia;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Location = new Point(1192, 185);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 355);
            panel6.TabIndex = 30;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Fuchsia;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Location = new Point(520, 178);
            panel7.Name = "panel7";
            panel7.Size = new Size(682, 10);
            panel7.TabIndex = 29;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Fuchsia;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Location = new Point(520, 530);
            panel8.Name = "panel8";
            panel8.Size = new Size(682, 10);
            panel8.TabIndex = 30;
            // 
            // label1
            // 
            label1.BackColor = Color.Fuchsia;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(920, 15);
            label1.Name = "label1";
            label1.Size = new Size(120, 36);
            label1.TabIndex = 31;
            label1.Text = "Start Date";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.BackColor = Color.Fuchsia;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.InfoText;
            label3.Location = new Point(1069, 15);
            label3.Name = "label3";
            label3.Size = new Size(120, 36);
            label3.TabIndex = 32;
            label3.Text = "End Date";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.images__1_;
            ClientSize = new Size(1255, 598);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dateTimePicker2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(monthCalendar1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(label3);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Todo List App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MonthCalendar monthCalendar1;
        private Button addButton;
        private Button deleteButton;
        private TextBox textBox1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DataGridView dataGridView1;
        private Button completeButton;
        private Button todayButton;
        private Button tomorowButton;
        private Panel panel1;
        private DataGridViewTextBoxColumn ThongTin;
        private DataGridViewTextBoxColumn startDate;
        private DataGridViewTextBoxColumn endDate;
        private DataGridViewCheckBoxColumn Done;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Label label1;
        private Label label3;
        private Button allButton;
    }
}
