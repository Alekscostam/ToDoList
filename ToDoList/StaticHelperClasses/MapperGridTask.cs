
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ToDoList.HelperClasses;
using ToDoList.Model;
using ToDoList.Model.DTO;

namespace ToDoList
{
    public static class MapperGridTask 
    {
      
        public static void TasksToDataGridView(List<Task> lists, DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
            List<TaskModel> listsDto = ObjectMapper.MapperListTaskToListTaskDto(lists);

            CustomDataGridView.StartupDesign(dgv);

            int n = 0;
            for (int i = 0; i < listsDto.Count; i++)
            {
                n = dgv.Rows.Add();
                dgv.Rows[n].Cells[0].Value = listsDto[i].Id;
                dgv.Rows[n].Cells[1].Value = listsDto[i].DateTime;
                dgv.Rows[n].Cells[2].Value = listsDto[i].TimeSpan;
                dgv.Rows[n].Cells[3].Value = listsDto[i].Description;



                if (lists[i].IdPriority.ToString() == ((int)PriorityModel.HIGH).ToString())
                    dgv.Rows[i].DefaultCellStyle.ForeColor = Color.Red;

                else if (lists[i].IdPriority.ToString() == ((int)PriorityModel.MEDIUM).ToString())
                    dgv.Rows[i].DefaultCellStyle.ForeColor = Color.Orange;
                else
                    dgv.Rows[i].DefaultCellStyle.ForeColor = Color.Blue;

            }
        }

        public static Task GridRowToTask(DataGridView dataGridView, DataGridViewCellMouseEventArgs e) 
        {
            
            DataGridViewRow row = dataGridView.Rows[e.RowIndex];

            string id;

            switch (row.DefaultCellStyle.BackColor.Name)
            {

                case "Red":
                    id = ((int)PriorityModel.HIGH).ToString();
                    break;
                case "Orange":
                    id = ((int)PriorityModel.MEDIUM).ToString();
                    break;
                default:
                    id = ((int)PriorityModel.LOW).ToString();
                    break;

            }

            Task task = new Task()
            {
                Id = int.Parse(row.Cells["Id"].Value.ToString()),
                TimeSpan = row.Cells["Time"].Value.ToString(),
                DateTime = row.Cells["Date"].Value.ToString(),
                Description = row.Cells["ToDo"].Value.ToString(),
                IdPriority = int.Parse(id),

            };


            return task;
        }

    }
}
