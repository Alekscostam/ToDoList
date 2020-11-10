
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ToDoList.Model;
using ToDoList.Model.DTO;

namespace ToDoList
{
    public class MapperListTask
    {
        private MapperListTask()
        {
            //private constructor            

        }

        public static void TasksToListView(List<TaskDto> lists, ListView lvAllTasks)
        {
            lvAllTasks.Items.Clear();
            for (int i = 0; i < lists.Count; i++)
            {
                lvAllTasks.Items.Add(new ListViewItem(new string[] {
                lists[i].TimeSpan.ToString(),
                lists[i].DateTime.ToString(),
                lists[i].Description.ToString(),
                lists[i].Id.ToString()
                }));

                if (lists[i].IdPriority.ToString() == ((int)PriorityDto.HIGH).ToString())
                    lvAllTasks.Items[i].SubItems[0].ForeColor = Color.Red;

                else if (lists[i].IdPriority.ToString() == ((int)PriorityDto.MEDIUM).ToString())
                    lvAllTasks.Items[i].SubItems[0].ForeColor = Color.Orange;
                else
                    lvAllTasks.Items[i].SubItems[0].ForeColor = Color.Blue;
            }

        }
        public static TaskDto ListViewItemToTask(ListViewItem item)
        {
            
            string id;

            switch (item.ForeColor.Name)
            {

                case "Red":
                    id = ((int) PriorityDto.HIGH).ToString();
                    break;
                case "Orange":
                    id = ((int)PriorityDto.MEDIUM).ToString();
                    break;
                default:
                    id = ((int)PriorityDto.LOW).ToString();
                    break;

            }

            TaskDto taskDto = new TaskDto() {
                TimeSpan = item.SubItems[0].Text,
                DateTime = item.SubItems[1].Text,
                Description = item.SubItems[2].Text,
                Id = int.Parse(item.SubItems[3].Text),
                IdPriority = id

            };


            return taskDto;
        }

    }
}
