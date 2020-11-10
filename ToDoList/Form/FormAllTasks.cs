
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
            getTaskService = new GetTaskService();
            dmlTaskService = new DmlTaskService();
            LoadData();


        }


        private void DtAllTasks_MouseClick(object sender, MouseEventArgs e)
        {



            /*
                            dtAllTasks.CurrentCell.ColumnIndex;
                            Task task = MapperListTask.ListViewItemToTask(item);

                            string option = SaveOrDeleteOperationChecker.ChoiceOfOptions(task, this);

                            if (option.Equals("Delete"))
                            {
                                dmlTaskService.DeleteByIdTask(task.Id);

                                ControlsRefresher();

                            }*/

        }


        private void BtnAllTasks_Click(object sender, EventArgs e)
        {

            List<Task> tasks = getTaskService.FindAllTasks();
            MapperListTask.TasksToDataGridView(tasks, dtAllTasks);

        }

        private void DtpDate_ValueChanged_1(object sender, EventArgs e)
        {
            List<Task> tasks = getTaskService.FindByDataTasks(dtpDate.Value.Date);
            MapperListTask.TasksToDataGridView(tasks, dtAllTasks);
        }

        private void LoadData()
        {
            List<Task> tasks = getTaskService.FindDailyTasks();
            MapperListTask.TasksToDataGridView(tasks, dtAllTasks);
        }

        public void ControlsRefresher()
        {
            this.Controls.Clear();
            InitializeComponent();

            LoadData();
        }

        private void lvAllTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtAllTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtAllTasks_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtAllTasks_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dataGridViewRow = dtAllTasks.Rows[e.RowIndex];

            Task task = MapperListTask.GridRowToTask(dataGridViewRow);

            string option = SaveOrDeleteOperationChecker.ChoiceOfOptions(task, this);

            if (option.Equals("Delete"))
            {
                dmlTaskService.DeleteByIdTask(task.Id);

                ControlsRefresher();

            }

        }
    }
}
