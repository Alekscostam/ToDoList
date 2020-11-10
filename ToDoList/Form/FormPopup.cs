﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.HelperClasses;
using ToDoList.Model;
using ToDoList.Model.DTO;

namespace ToDoList
{
    public partial class FormPopup : Form
    {
        Model.Task task;
        public FormPopup(Model.Task taskDto)
        {
            
            InitializeComponent();
            this.task = new Model.Task();
            this.task = taskDto;

            LoadData();

        }
        
        private void LoadData()
        {
            lblTime.Text = $"Time : {task.TimeSpan} ";
            lblDesc.Text = $"To do : {task.Description} ";

            switch (task.IdPriority)
            {
                case (int)PriorityModel.HIGH:
                    this.BackColor = Color.Red;
                break; 
                case (int)PriorityModel.MEDIUM:
                    this.BackColor = Color.Orange;
                    break;
                default:
                    this.BackColor = Color.Blue;
                    break;

            }

            

        } 

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
