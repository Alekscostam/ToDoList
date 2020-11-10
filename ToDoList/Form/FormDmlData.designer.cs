namespace ToDoList.Forms
{
    partial class FormDmlData
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOperation = new System.Windows.Forms.Button();
            this.mtbHour = new System.Windows.Forms.MaskedTextBox();
            this.rbVery = new System.Windows.Forms.RadioButton();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.rbModerately = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbLittle = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnOperation);
            this.panel1.Controls.Add(this.mtbHour);
            this.panel1.Controls.Add(this.rbVery);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.rbModerately);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rbLittle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 378);
            this.panel1.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtDescription.Location = new System.Drawing.Point(254, 223);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(324, 74);
            this.txtDescription.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(254, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Importance level:";
            // 
            // btnOperation
            // 
            this.btnOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(235)))));
            this.btnOperation.FlatAppearance.BorderSize = 0;
            this.btnOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOperation.ForeColor = System.Drawing.Color.White;
            this.btnOperation.Location = new System.Drawing.Point(254, 303);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(324, 55);
            this.btnOperation.TabIndex = 6;
            this.btnOperation.Text = "Add";
            this.btnOperation.UseVisualStyleBackColor = false;
            this.btnOperation.Click += new System.EventHandler(this.BtnOperation_Click);
            // 
            // mtbHour
            // 
            this.mtbHour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.mtbHour.Location = new System.Drawing.Point(441, 87);
            this.mtbHour.Mask = "00:00";
            this.mtbHour.Name = "mtbHour";
            this.mtbHour.Size = new System.Drawing.Size(53, 24);
            this.mtbHour.TabIndex = 5;
            this.mtbHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbHour.ValidatingType = typeof(System.DateTime);
            // 
            // rbVery
            // 
            this.rbVery.AutoSize = true;
            this.rbVery.Location = new System.Drawing.Point(441, 132);
            this.rbVery.Name = "rbVery";
            this.rbVery.Size = new System.Drawing.Size(92, 17);
            this.rbVery.TabIndex = 0;
            this.rbVery.TabStop = true;
            this.rbVery.Text = "Very important";
            this.rbVery.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dtpDate.Location = new System.Drawing.Point(254, 21);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(324, 26);
            this.dtpDate.TabIndex = 4;
            // 
            // rbModerately
            // 
            this.rbModerately.AutoSize = true;
            this.rbModerately.Checked = true;
            this.rbModerately.Location = new System.Drawing.Point(441, 155);
            this.rbModerately.Name = "rbModerately";
            this.rbModerately.Size = new System.Drawing.Size(124, 17);
            this.rbModerately.TabIndex = 1;
            this.rbModerately.TabStop = true;
            this.rbModerately.Text = "Moderately Important";
            this.rbModerately.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(254, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hours:";
            // 
            // rbLittle
            // 
            this.rbLittle.AutoSize = true;
            this.rbLittle.Location = new System.Drawing.Point(441, 178);
            this.rbLittle.Name = "rbLittle";
            this.rbLittle.Size = new System.Drawing.Size(85, 17);
            this.rbLittle.TabIndex = 2;
            this.rbLittle.TabStop = true;
            this.rbLittle.Text = "Unimportant ";
            this.rbLittle.UseVisualStyleBackColor = true;
            // 
            // FormDmlData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(831, 378);
            this.Controls.Add(this.panel1);
            this.Name = "FormDmlData";
            this.Text = "Task creator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOperation;
        private System.Windows.Forms.MaskedTextBox mtbHour;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.RadioButton rbLittle;
        private System.Windows.Forms.RadioButton rbModerately;
        private System.Windows.Forms.RadioButton rbVery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
    }
}