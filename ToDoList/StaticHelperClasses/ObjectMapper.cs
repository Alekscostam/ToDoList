
using System.Collections.Generic;
using ToDoList.Model;

namespace ToDoList.HelperClasses
{
    public static class ObjectMapper
    {
     

        public static List<TaskModel> MapperListTaskToListTaskDto(List<Task> tasksModel)
        {

            List<TaskModel> tasksDto = new List<TaskModel>();
            tasksModel.ForEach(tasks =>
            {
                tasksDto.Add(new TaskModel()
                {
                    Id = tasks.Id,                  
                    TimeSpan = tasks.TimeSpan,
                    DateTime = tasks.DateTime,
                    Description = tasks.Description
                });
            }
            );

            return tasksDto;
        }
    }
}
