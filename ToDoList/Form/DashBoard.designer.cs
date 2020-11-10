namespace ToDoList
{
    partial class DashBoard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.panel = new System.Windows.Forms.Panel();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnAllTasks = new System.Windows.Forms.Button();
            this.btnUpcomingTasks = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProject = new System.Windows.Forms.Label();
            this.timerDbChecker = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(235)))));
            this.panel.Controls.Add(this.btnAddTask);
            this.panel.Controls.Add(this.btnToday);
            this.panel.Controls.Add(this.btnAllTasks);
            this.panel.Controls.Add(this.btnUpcomingTasks);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 492);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(800, 70);
            this.panel.TabIndex = 0;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddTask.FlatAppearance.BorderSize = 0;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.Image = global::ToDoList.Properties.Resources.plus;
            this.btnAddTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTask.Location = new System.Drawing.Point(600, 0);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddTask.Size = new System.Drawing.Size(200, 70);
            this.btnAddTask.TabIndex = 4;
            this.btnAddTask.Text = "  Add task";
            this.btnAddTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.BtnDmlData_Click);
            // 
            // btnToday
            // 
            this.btnToday.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnToday.FlatAppearance.BorderSize = 0;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.ForeColor = System.Drawing.Color.White;
            this.btnToday.Image = global::ToDoList.Properties.Resources.information1;
            this.btnToday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToday.Location = new System.Drawing.Point(400, 0);
            this.btnToday.Name = "btnToday";
            this.btnToday.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnToday.Size = new System.Drawing.Size(200, 70);
            this.btnToday.TabIndex = 3;
            this.btnToday.Text = " About app";
            this.btnToday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToday.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // btnAllTasks
            // 
            this.btnAllTasks.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAllTasks.FlatAppearance.BorderSize = 0;
            this.btnAllTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllTasks.ForeColor = System.Drawing.Color.White;
            this.btnAllTasks.Image = global::ToDoList.Properties.Resources.clipboards;
            this.btnAllTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllTasks.Location = new System.Drawing.Point(200, 0);
            this.btnAllTasks.Name = "btnAllTasks";
            this.btnAllTasks.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAllTasks.Size = new System.Drawing.Size(200, 70);
            this.btnAllTasks.TabIndex = 2;
            this.btnAllTasks.Text = " All Tasks ";
            this.btnAllTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllTasks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllTasks.UseVisualStyleBackColor = true;
            this.btnAllTasks.Click += new System.EventHandler(this.BtnAllTasks_Click);
            // 
            // btnUpcomingTasks
            // 
            this.btnUpcomingTasks.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUpcomingTasks.FlatAppearance.BorderSize = 0;
            this.btnUpcomingTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpcomingTasks.ForeColor = System.Drawing.Color.White;
            this.btnUpcomingTasks.Image = global::ToDoList.Properties.Resources.to_do_list__1_;
            this.btnUpcomingTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpcomingTasks.Location = new System.Drawing.Point(0, 0);
            this.btnUpcomingTasks.Name = "btnUpcomingTasks";
            this.btnUpcomingTasks.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUpcomingTasks.Size = new System.Drawing.Size(200, 70);
            this.btnUpcomingTasks.TabIndex = 1;
            this.btnUpcomingTasks.Text = "Upcoming daily";
            this.btnUpcomingTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpcomingTasks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpcomingTasks.UseVisualStyleBackColor = true;
            this.btnUpcomingTasks.Click += new System.EventHandler(this.BtnUpcomingTasks_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 75);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 417);
            this.panelMain.TabIndex = 2;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(95, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 51);
            this.lblTitle.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(146)))), ((int)(((byte)(227)))));
            this.panelTitle.Controls.Add(this.lblLogo);
            this.panelTitle.Controls.Add(this.panel1);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(800, 75);
            this.panelTitle.TabIndex = 1;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.lblLogo.ForeColor = System.Drawing.Color.Transparent;
            this.lblLogo.Location = new System.Drawing.Point(297, 14);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(275, 44);
            this.lblLogo.TabIndex = 4;
            this.lblLogo.Text = "Welcome user!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(227)))));
            this.panel1.Controls.Add(this.lblProject);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 75);
            this.panel1.TabIndex = 3;
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblProject.ForeColor = System.Drawing.Color.White;
            this.lblProject.Location = new System.Drawing.Point(12, 19);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(154, 39);
            this.lblProject.TabIndex = 2;
            this.lblProject.Text = "ToDoList";
            // 
            // timerDbChecker
            // 
            this.timerDbChecker.Enabled = true;
            this.timerDbChecker.Interval = 1000;
            this.timerDbChecker.Tick += new System.EventHandler(this.TimerDbChecker_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashBoard";
            this.Text = "ToDoList";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.Resize += new System.EventHandler(this.DashBoard_Resize);
            this.panel.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnAllTasks;
        private System.Windows.Forms.Button btnUpcomingTasks;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Timer timerDbChecker;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

