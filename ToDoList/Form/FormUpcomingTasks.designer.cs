namespace ToDoList.Forms
{
    partial class FormUpcomingTasks
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
            this.nudHour = new System.Windows.Forms.NumericUpDown();
            this.lvAllTasks = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).BeginInit();
            this.SuspendLayout();
            // 
            // nudHour
            // 
            this.nudHour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nudHour.Location = new System.Drawing.Point(234, 345);
            this.nudHour.Name = "nudHour";
            this.nudHour.Size = new System.Drawing.Size(49, 26);
            this.nudHour.TabIndex = 3;
            // 
            // lvAllTasks
            // 
            this.lvAllTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvAllTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.id});
            this.lvAllTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAllTasks.HideSelection = false;
            this.lvAllTasks.Location = new System.Drawing.Point(58, 33);
            this.lvAllTasks.Name = "lvAllTasks";
            this.lvAllTasks.Size = new System.Drawing.Size(666, 304);
            this.lvAllTasks.TabIndex = 5;
            this.lvAllTasks.UseCompatibleStateImageBehavior = false;
            this.lvAllTasks.View = System.Windows.Forms.View.Details;
            this.lvAllTasks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LvAllTasks_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Time of day";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "To do";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 401;
            // 
            // id
            // 
            this.id.Text = "Id";
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(235)))));
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(289, 343);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(282, 31);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // FormUpcomingTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 378);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.nudHour);
            this.Controls.Add(this.lvAllTasks);
            this.Name = "FormUpcomingTasks";
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudHour;
        private System.Windows.Forms.ListView lvAllTasks;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Button btnApply;
    }
}