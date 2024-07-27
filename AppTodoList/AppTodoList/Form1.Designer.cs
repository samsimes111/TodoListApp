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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            label1 = new Label();
            label3 = new Label();
            panel9 = new Panel();
            allButton = new Button();
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
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.InfoText;
            label2.Location = new Point(520, 51);
            label2.Name = "label2";
            label2.Size = new Size(116, 36);
            label2.TabIndex = 17;
            label2.Text = "Nhập task";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1033, 17);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(24, 27);
            dateTimePicker1.TabIndex = 23;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(1165, 16);
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
            dataGridViewCellStyle6.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ControlText;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.BackgroundColor = SystemColors.Menu;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ThongTin, startDate, endDate, Done });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.ButtonHighlight;
            dataGridView1.ImeMode = ImeMode.Disable;
            dataGridView1.Location = new Point(520, 185);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(682, 355);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.ColumnSortModeChanged += dataGridView1_ColumnSortModeChanged;
            // 
            // ThongTin
            // 
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.ControlText;
            ThongTin.DefaultCellStyle = dataGridViewCellStyle8;
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
            Done.FalseValue = "Chưa Hoàn Thành";
            Done.HeaderText = "Hoàn Thành";
            Done.MinimumWidth = 6;
            Done.Name = "Done";
            Done.TrueValue = "Hoàn Thành";
            Done.Width = 110;
            // 
            // completeButton
            // 
            completeButton.BackColor = Color.Violet;
            completeButton.Location = new Point(47, 156);
            completeButton.Name = "completeButton";
            completeButton.Size = new Size(151, 41);
            completeButton.TabIndex = 14;
            completeButton.Text = "Đã hoàn thành";
            completeButton.UseVisualStyleBackColor = false;
            // 
            // todayButton
            // 
            todayButton.BackColor = Color.Violet;
            todayButton.Location = new Point(47, 64);
            todayButton.Name = "todayButton";
            todayButton.Size = new Size(151, 40);
            todayButton.TabIndex = 8;
            todayButton.Text = "Hôm nay";
            todayButton.UseVisualStyleBackColor = false;
            todayButton.Click += todayButton_Click;
            // 
            // tomorowButton
            // 
            tomorowButton.BackColor = Color.Violet;
            tomorowButton.Location = new Point(47, 110);
            tomorowButton.Name = "tomorowButton";
            tomorowButton.Size = new Size(151, 40);
            tomorowButton.TabIndex = 10;
            tomorowButton.Text = "Ngày mai";
            tomorowButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Violet;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(allButton);
            panel1.Controls.Add(completeButton);
            panel1.Controls.Add(todayButton);
            panel1.Controls.Add(tomorowButton);
            panel1.Location = new Point(132, 347);
            panel1.Name = "panel1";
            panel1.Size = new Size(235, 213);
            panel1.TabIndex = 26;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Fuchsia;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Location = new Point(862, 178);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 355);
            panel2.TabIndex = 27;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Fuchsia;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Location = new Point(974, 178);
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
            panel6.BorderStyle = BorderStyle.FixedSingle;
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
            label1.Location = new Point(937, 12);
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
            label3.Location = new Point(1069, 11);
            label3.Name = "label3";
            label3.Size = new Size(120, 36);
            label3.TabIndex = 32;
            label3.Text = "End Date";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel9
            // 
            panel9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel9.BackColor = Color.Fuchsia;
            panel9.BorderStyle = BorderStyle.Fixed3D;
            panel9.Location = new Point(520, 209);
            panel9.Name = "panel9";
            panel9.Size = new Size(682, 10);
            panel9.TabIndex = 30;
            // 
            // allButton
            // 
            allButton.BackColor = Color.Violet;
            allButton.Location = new Point(47, 18);
            allButton.Name = "allButton";
            allButton.Size = new Size(151, 40);
            allButton.TabIndex = 15;
            allButton.Text = "All";
            allButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.images__1_;
            ClientSize = new Size(1255, 598);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel6);
            Controls.Add(panel5);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Label label1;
        private Label label3;
        private DataGridViewTextBoxColumn ThongTin;
        private DataGridViewTextBoxColumn startDate;
        private DataGridViewTextBoxColumn endDate;
        private DataGridViewCheckBoxColumn Done;
        private Panel panel9;
        private Button allButton;
    }
}
