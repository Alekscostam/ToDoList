
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
        readonly IFindTask getTaskService;
        readonly IDmlTask dmlTaskService;

        public FormAllTasks()
        {
            InitializeComponent();
            getTaskService = new GetTaskService();
            dmlTaskService = new DmlTaskService();
            LoadData();


        }

        private void BtnAllTasks_Click(object sender, EventArgs e)
        {

            List<Task> tasks = getTaskService.FindAllTasks();
            MapperGridTask.TasksToDataGridView(tasks, dtAllTasks);

        }

        private void DtpDate_ValueChanged_1(object sender, EventArgs e)
        {
            List<Task> tasks = getTaskService.FindByDataTasks(dtpDate.Value.Date);
            MapperGridTask.TasksToDataGridView(tasks, dtAllTasks);
        }

        private void LoadData()
        {
            List<Task> tasks = getTaskService.FindDailyTasks();
            MapperGridTask.TasksToDataGridView(tasks, dtAllTasks);
        }

        public void ControlsRefresher()
        {
            this.Controls.Clear();
            InitializeComponent();

            LoadData();
        }

    

        private void DtAllTasks_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Task task = MapperGridTask.GridRowToTask(dtAllTasks, e);

                string option = SaveOrDeleteOperationChecker.ChoiceOfOptions(task, this);

                if (option.Equals("Delete"))
                {
                    dmlTaskService.DeleteByIdTask(task.Id);

                    ControlsRefresher();

                }

            }

            catch (ArgumentOutOfRangeException)
            {
                //Zaznoczonych kilka pol
            }
        }
    }
}

