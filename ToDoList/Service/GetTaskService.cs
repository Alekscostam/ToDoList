using System;
using System.Collections.Generic;
using System.Linq;
using ToDoList.DAO;
using ToDoList.Model;
using ToDoList.Service.TaskInterfaces;

namespace ToDoList.Service.OperationsService
{
    public class GetTaskService : IFindTask
    {
        readonly TaskDbContext taskContext = new TaskDbContext();
       
  
        public List<Task> FindAllTasks()
        {
            List<Task> listsTask = taskContext.Tasks.ToList();
            return listsTask
                .OrderBy(x => DateTime.Parse(x.DateTime))
                .ThenBy(x => x.TimeSpan).ToList();
        }

        public List<Task> FindUpcomingTasks(int amount)
        {
            List<Task> listsTask = taskContext.Tasks.ToList();
            return listsTask
                .OrderBy(x => DateTime.Parse(x.DateTime))
                .ThenBy(x => x.TimeSpan)
                .Where(x => DateTime.Parse(x.DateTime) == DateTime.Today)
                .Where(x => DateTime.Parse(x.TimeSpan) >= DateTime.Parse(DateTime.Now.ToString("HH:mm")))
                .Take(amount).ToList();
        }

        public List<Task> FindDailyTasks()
        {
            List<Task> listsTask = taskContext.Tasks.ToList();
            return listsTask
                .OrderBy(x => DateTime.Parse(x.DateTime))
                .ThenBy(x => x.TimeSpan)
                .Where(x => DateTime.Parse(x.DateTime) == DateTime.Today).ToList();
        }

        public List<Task> FindByDataTasks(DateTime dateTime)
        {
            List<Task> listsTask = taskContext.Tasks.ToList();
            return listsTask
                .OrderBy(x => DateTime.Parse(x.DateTime))
                .ThenBy(x => x.TimeSpan).Where(x => DateTime.Parse(x.DateTime) == dateTime).ToList();
        }
        public Task FindOneUpcomingTaskByActuallyDate(TimeSpan actuallyDate)
        {

            Task task = FindUpcomingTasks(1)
                .FirstOrDefault(x=>(TimeSpan.Parse(x.TimeSpan)-actuallyDate).ToString().Substring(0,2).Equals("00"));
            return task;

        }
          
    }
}
