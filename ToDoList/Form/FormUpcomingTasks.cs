using System;
using System.Collections.Generic;
using ToDoList.Model;
using System.Windows.Forms;
using ToDoList.Service.OperationsService;
using ToDoList.HelperClasses;
using ToDoList.Service.TaskInterfaces;

namespace ToDoList.Forms
{
    public partial class FormUpcomingTasks : Form, ILoader
    {
        readonly IFindTaskDto getDataService;
        readonly IDmlTask dmlTaskService;


        public FormUpcomingTasks()
        {
            InitializeComponent();
            getDataService = new GetTaskService();
            dmlTaskService = new DmlTaskService();
            lvAllTasks.FullRowSelect = true;
            LoadData();
        }

        private void LoadData(int hour = 3)
        {

            List<TaskDto> lists = getDataService.FindUpcomingTasks(hour);
            MapperListTask.TasksToListView(lists, lvAllTasks);
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(Math.Round(nudHour.Value, 0));
            LoadData(count);
            
        }

        private void LvAllTasks_MouseClick(object sender, MouseEventArgs e)
        {

            ListViewItem item = lvAllTasks.SelectedItems[0];
            TaskDto taskDto = MapperListTask.ListViewItemToTask(item);
            string option = SaveOrDeleteOperationChecker.ChoiceOfOptions(taskDto,this);

            if (option.Equals("Delete")) {
                dmlTaskService.DeleteByIdTask(taskDto.Id);  
                ControlsRefresher(); 
            }
                
        }

        public void ControlsRefresher()
        {
            this.Controls.Clear();
            InitializeComponent();
            lvAllTasks.FullRowSelect = true;
            LoadData();
        }

       
    }
}
