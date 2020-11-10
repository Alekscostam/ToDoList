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
            this.lvAllTasks = new System.Windows.Forms.ListView();
            this.columnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAllTasks = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lvAllTasks
            // 
            this.lvAllTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvAllTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTime,
            this.columnDate,
            this.columnDesc,
            this.id});
            this.lvAllTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAllTasks.HideSelection = false;
            this.lvAllTasks.Location = new System.Drawing.Point(56, 34);
            this.lvAllTasks.Name = "lvAllTasks";
            this.lvAllTasks.Size = new System.Drawing.Size(661, 304);
            this.lvAllTasks.TabIndex = 0;
            this.lvAllTasks.UseCompatibleStateImageBehavior = false;
            this.lvAllTasks.View = System.Windows.Forms.View.Details;
            this.lvAllTasks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LvAllTasks_MouseClick);
            // 
            // columnTime
            // 
            this.columnTime.Text = "Time of day";
            this.columnTime.Width = 110;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Date";
            this.columnDate.Width = 95;
            // 
            // columnDesc
            // 
            this.columnDesc.Text = "To do";
            this.columnDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDesc.Width = 401;
            // 
            // id
            // 
            this.id.Text = "Id";
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
            // FormAllTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 378);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnAllTasks);
            this.Controls.Add(this.lvAllTasks);
            this.Name = "FormAllTasks";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAllTasks;
        private System.Windows.Forms.ColumnHeader columnTime;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnDesc;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Button btnAllTasks;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}