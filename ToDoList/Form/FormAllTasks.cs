
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ToDoList.HelperClasses;
using ToDoList.Model;
using ToDoList.Service.OperationsService;
using ToDoList.Service.TaskInterfaces;

namespace ToDoList.Forms
{
    public partial class FormAllTasks : Form, ILoader
    {
        readonly IFindTaskDto getTaskService;
        readonly IDmlTask dmlTaskService;


        public FormAllTasks()
        {
            InitializeComponent();
            lvAllTasks.FullRowSelect = true;
            getTaskService = new GetTaskService();
            dmlTaskService = new DmlTaskService();
            LoadData();
           

        }
 
      
        private void LvAllTasks_MouseClick(object sender, MouseEventArgs e)
        {
            if (lvAllTasks.SelectedItems.Count > 0)
            {

                ListViewItem item = lvAllTasks.SelectedItems[0];
                TaskDto taskDto = MapperListTask.ListViewItemToTask(item);
             
                string option = SaveOrDeleteOperationChecker.ChoiceOfOptions(taskDto, this);

                if (option.Equals("Delete"))
                {
                    dmlTaskService.DeleteByIdTask(taskDto.Id);

                    ControlsRefresher();

                }
            }
        }


        private void BtnAllTasks_Click(object sender, EventArgs e)
        {
            List<TaskDto> tasksDto = getTaskService.FindAllTasks();
            MapperListTask.TasksToListView(tasksDto, lvAllTasks);

        }

        private void DtpDate_ValueChanged_1(object sender, EventArgs e)
        {
            List<TaskDto> tasksDto = getTaskService.FindByDataTasks(dtpDate.Value.Date);
            MapperListTask.TasksToListView(tasksDto, lvAllTasks);
        }

        private void LoadData()
        {
            List<TaskDto> tasksDto = getTaskService.FindDailyTasks();
            MapperListTask.TasksToListView(tasksDto, lvAllTasks);
        }

        public void ControlsRefresher()
        {
            this.Controls.Clear();
            InitializeComponent();
            LoadData();
        }
    }
}
