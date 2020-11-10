namespace ToDoList
{
    partial class FormInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformation));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAddTask = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblUpcoming = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAllTasks = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAddTask);
            this.groupBox1.Location = new System.Drawing.Point(13, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add task";
            // 
            // lblAddTask
            // 
            this.lblAddTask.AutoSize = true;
            this.lblAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.lblAddTask.Location = new System.Drawing.Point(7, 31);
            this.lblAddTask.Name = "lblAddTask";
            this.lblAddTask.Size = new System.Drawing.Size(469, 17);
            this.lblAddTask.TabIndex = 0;
            this.lblAddTask.Text = "Z okna \'Add task\' Korzysta opcja dodawania jak i modyfikowania zadania.\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblUpcoming);
            this.groupBox2.Location = new System.Drawing.Point(13, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 73);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Upcoming ";
            // 
            // lblUpcoming
            // 
            this.lblUpcoming.AutoSize = true;
            this.lblUpcoming.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.lblUpcoming.Location = new System.Drawing.Point(7, 16);
            this.lblUpcoming.Name = "lblUpcoming";
            this.lblUpcoming.Size = new System.Drawing.Size(743, 34);
            this.lblUpcoming.TabIndex = 0;
            this.lblUpcoming.Text = resources.GetString("lblUpcoming.Text");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblAllTasks);
            this.groupBox3.Location = new System.Drawing.Point(13, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(759, 104);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "All tasks";
            // 
            // lblAllTasks
            // 
            this.lblAllTasks.AutoSize = true;
            this.lblAllTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.lblAllTasks.Location = new System.Drawing.Point(7, 31);
            this.lblAllTasks.Name = "lblAllTasks";
            this.lblAllTasks.Size = new System.Drawing.Size(689, 51);
            this.lblAllTasks.TabIndex = 0;
            this.lblAllTasks.Text = resources.GetString("lblAllTasks.Text");
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(13, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(759, 51);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wstęp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(716, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uzytkownik może modyfikowac i usuwac informacje odnosnie zadan po kliknieciu na p" +
    "oszczególny element z listy\r\n";
            // 
            // FormInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 378);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormInformation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAddTask;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblUpcoming;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblAllTasks;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
    }
}