
using System;
using System.Collections.Generic;

using ToDoList.Model;

namespace ToDoList.Service.TaskInterfaces
{
    public interface IFindTaskDto
    {
        List<TaskDto> FindAllTasks();
        List<TaskDto> FindUpcomingTasks(int amount);
        List<TaskDto> FindDailyTasks();
        List<TaskDto> FindByDataTasks(DateTime dateTime);

        TaskDto FindOneUpcomingTaskByActuallyDate(TimeSpan actuallyDate);
    }
}
