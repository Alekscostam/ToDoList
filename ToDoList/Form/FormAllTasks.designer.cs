namespace ToDoList.Forms
{
    partial class FormAllTasks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAllTasks = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtAllTasks = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtAllTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAllTasks
            // 
            this.btnAllTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(235)))));
            this.btnAllTasks.FlatAppearance.BorderSize = 0;
            this.btnAllTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnAllTasks.ForeColor = System.Drawing.Color.White;
            this.btnAllTasks.Location = new System.Drawing.Point(405, 344);
            this.btnAllTasks.Name = "btnAllTasks";
            this.btnAllTasks.Size = new System.Drawing.Size(312, 31);
            this.btnAllTasks.TabIndex = 7;
            this.btnAllTasks.Text = "All tasks";
            this.btnAllTasks.UseVisualStyleBackColor = false;
            this.btnAllTasks.Click += new System.EventHandler(this.BtnAllTasks_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dtpDate.Location = new System.Drawing.Point(56, 349);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(343, 26);
            this.dtpDate.TabIndex = 8;
            this.dtpDate.ValueChanged += new System.EventHandler(this.DtpDate_ValueChanged_1);
            // 
            // dtAllTasks
            // 
            this.dtAllTasks.AllowUserToAddRows = false;
            this.dtAllTasks.AllowUserToDeleteRows = false;
            this.dtAllTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtAllTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAllTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Date,
            this.Time,
            this.ToDo});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtAllTasks.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtAllTasks.GridColor = System.Drawing.Color.White;
            this.dtAllTasks.Location = new System.Drawing.Point(30, 12);
            this.dtAllTasks.Name = "dtAllTasks";
            this.dtAllTasks.ReadOnly = true;
            this.dtAllTasks.RowTemplate.Height = 25;
            this.dtAllTasks.Size = new System.Drawing.Size(706, 331);
            this.dtAllTasks.TabIndex = 10;
            this.dtAllTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAllTasks_CellContentClick_1);
            this.dtAllTasks.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtAllTasks_CellMouseClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // ToDo
            // 
            this.ToDo.HeaderText = "To do";
            this.ToDo.Name = "ToDo";
            this.ToDo.ReadOnly = true;
            this.ToDo.Width = 500;
            // 
            // FormAllTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 378);
            this.Controls.Add(this.dtAllTasks);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnAllTasks);
            this.Name = "FormAllTasks";
            ((System.ComponentModel.ISupportInitialize)(this.dtAllTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAllTasks;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridView dtAllTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToDo;
    }
}