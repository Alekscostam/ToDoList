
using System;
using System.Windows.Forms;
using ToDoList.HelperClasses;
using ToDoList.Model;
using ToDoList.Model.DTO;
using ToDoList.Service.OperationsService;

namespace ToDoList.Forms
{
    public partial class FormDmlData : Form , ILoader
    {
        readonly DmlTaskService dmlTaskService;
        readonly Task taskDto;
        public FormDmlData(Task taskDto = null)
        {

            InitializeComponent();
            dmlTaskService = new DmlTaskService();
            this.taskDto = taskDto;
            LoadData(this.taskDto);

        }

        private void LoadData(Task task)
        {
            if (taskDto != null)
            {
                txtDescription.Text = taskDto.Description;

                string dateTime = taskDto.DateTime;

                dtpDate.Value = DateTime.Parse(dateTime);

                string timeSpan = taskDto.TimeSpan;
          
                mtbHour.Text = timeSpan;

                switch (task.IdPriority)
                {
                    case (int)PriorityModel.HIGH:
                        rbVery.Checked = true;
                        break;
                    case (int)PriorityModel.MEDIUM:
                        rbModerately.Checked = true;
                        break;
                    default:
                        rbLittle.Checked = true;
                        break;
                }

                btnOperation.BackColor = System.Drawing.Color.Orange;
                btnOperation.Text = "Modify";
            }
         
        }

        private void BtnOperation_Click(object sender, EventArgs e)
        {

            bool resultValidInfo = ValidInformationsChecker(out string dateTime, out Priority priority);

            if (resultValidInfo)
            {

                if (taskDto == null)
                { 
                    Task task = CreateTaskModel(dateTime, mtbHour.Text, txtDescription.Text, priority, null);
                    dmlTaskService.SaveTask(task);
                    ControlsRefresher();
                }

                  
                else {
                    Task task = CreateTaskModel(dateTime, mtbHour.Text, txtDescription.Text, priority, taskDto.Id.ToString());
                    dmlTaskService.ModifyTask(task);
                    this.Close();
                }
               
            }
        }
        private Task CreateTaskModel(string dateTime, string timeSpan, string desc, Priority priority, string Id)
        {
            Task taskModel = new Task
            {
                DateTime = dateTime,
                Description = desc,
                IdPriority = priority.IdPriority,
                TimeSpan = timeSpan
            };

            if (Id != null)
            {
                taskModel.Id = int.Parse(Id);
            }
          
            return taskModel;
        }

        private bool ValidInformationsChecker(out string dateTime, out Priority priority)
        {
            dateTime = dtpDate.Value.Date.Day + "/" + dtpDate.Value.Date.Month + "/" + dtpDate.Value.Date.Year;

            priority = new Priority();

            if (mtbHour.MaskCompleted && txtDescription.Text != "")
            {
                int hour = int.Parse(mtbHour.Text.Substring(0, 2));
                int minute = int.Parse(mtbHour.Text.Substring(3, 2));

                if (!(hour >= 24 || minute >= 60))
                {
                     
                    #region radioButton checker

                    if (rbLittle.Checked)
                        priority.IdPriority = (int)PriorityModel.LOW;

                    else if (rbVery.Checked)
                        priority.IdPriority = (int)PriorityModel.HIGH;

                    else
                        priority.IdPriority = (int)PriorityModel.MEDIUM;

                    #endregion

                    return true;
                }
                else
                {
                    MessageBox.Show("Not valid time span");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Values in fields cannot be empty");
                return false;
            }


        }

        public void ControlsRefresher()
        {
            this.Controls.Clear();
            InitializeComponent();
           
        }

    }
}
