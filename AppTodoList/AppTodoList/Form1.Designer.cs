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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            monthCalendar1 = new MonthCalendar();
            todayButton = new Button();
            tomorowButton = new Button();
            addButton = new Button();
            deleteButton = new Button();
            completeButton = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(4, 7);
            label1.Name = "label1";
            label1.Size = new Size(428, 88);
            label1.TabIndex = 0;
            label1.Text = "Todo List App";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(66, 131);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // todayButton
            // 
            todayButton.Location = new Point(41, 391);
            todayButton.Name = "todayButton";
            todayButton.Size = new Size(287, 29);
            todayButton.TabIndex = 8;
            todayButton.Text = "Hôm nay";
            todayButton.UseVisualStyleBackColor = true;
            // 
            // tomorowButton
            // 
            tomorowButton.Location = new Point(41, 443);
            tomorowButton.Name = "tomorowButton";
            tomorowButton.Size = new Size(287, 29);
            tomorowButton.TabIndex = 10;
            tomorowButton.Text = "Ngày mai";
            tomorowButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Location = new Point(964, 52);
            addButton.Name = "addButton";
            addButton.Size = new Size(121, 29);
            addButton.TabIndex = 12;
            addButton.Text = "Thêm";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(1091, 52);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 13;
            deleteButton.Text = "Xóa";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // completeButton
            // 
            completeButton.Location = new Point(41, 498);
            completeButton.Name = "completeButton";
            completeButton.Size = new Size(287, 29);
            completeButton.TabIndex = 14;
            completeButton.Text = "Đã hoàn thành";
            completeButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(510, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(675, 322);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ActiveCaptionText;
            Column1.DefaultCellStyle = dataGridViewCellStyle1;
            Column1.FillWeight = 300F;
            Column1.HeaderText = "Thông tin";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 250;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ActiveCaptionText;
            Column2.DefaultCellStyle = dataGridViewCellStyle2;
            Column2.HeaderText = "Start Date";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            dataGridViewCellStyle3.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ActiveCaptionText;
            Column3.DefaultCellStyle = dataGridViewCellStyle3;
            Column3.HeaderText = "End Date";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle4.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.NullValue = false;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ActiveCaptionText;
            Column4.DefaultCellStyle = dataGridViewCellStyle4;
            Column4.HeaderText = "Done";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1212, 660);
            Controls.Add(dataGridView1);
            Controls.Add(completeButton);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(tomorowButton);
            Controls.Add(todayButton);
            Controls.Add(monthCalendar1);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Todo List App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private MonthCalendar monthCalendar1;
        private Button todayButton;
        private Button tomorowButton;
        private Button addButton;
        private Button deleteButton;
        private Button completeButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewCheckBoxColumn Column4;
    }
}
