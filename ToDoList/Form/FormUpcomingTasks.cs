﻿using System;
using System.Collections.Generic;
using ToDoList.Model;
using System.Windows.Forms;
using ToDoList.Service.OperationsService;
using ToDoList.HelperClasses;
using ToDoList.Service.TaskInterfaces;
using ToDoList.StaticHelperClasses;

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
            LoadData();
        }

        private void LoadData(int hour = 3)
        {

            List<Task> lists = getDataService.FindUpcomingTasks(hour);
            MapperGridTask.TasksToDataGridView(lists, dtUpcoming);
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(Math.Round(nudHour.Value, 0));
            LoadData(count);

        }


        public void ControlsRefresher()
        {
            this.Controls.Clear();
            InitializeComponent();
            LoadData();
        }

        private void dtUpcoming_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtUpcoming_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try { 
            Task task = MapperGridTask.GridRowToTask(dtUpcoming, e);

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
