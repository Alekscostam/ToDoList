
using System;
using System.Collections.Generic;

using ToDoList.Model;

namespace ToDoList.Service.TaskInterfaces
{
    public interface IFindTaskDto
    {
        List<Task> FindAllTasks();
        List<Task> FindUpcomingTasks(int amount);
        List<Task> FindDailyTasks();
        List<Task> FindByDataTasks(DateTime dateTime);

        Task FindOneUpcomingTaskByActuallyDate(TimeSpan actuallyDate);
    }
}
