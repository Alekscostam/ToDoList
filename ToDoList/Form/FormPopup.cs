using System;
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
        TaskDto taskDto;
        public FormPopup(Model.TaskDto taskDto)
        {
            
            InitializeComponent();
            this.taskDto = new TaskDto();
            this.taskDto = taskDto;

            LoadData();

        }
        
        private void LoadData()
        {
            lblTime.Text = $"Time : {taskDto.TimeSpan} ";
            lblDesc.Text = $"To do : {taskDto.Description} ";

            switch (int.Parse(taskDto.IdPriority))
            {
                case (int)PriorityDto.HIGH:
                    this.BackColor = Color.Red;
                break; 
                case (int)PriorityDto.MEDIUM:
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
