using System;
using System.Collections.Generic;
using System.Linq;
using ToDoList.DAO;
using ToDoList.Model;
using ToDoList.Service.TaskInterfaces;

namespace ToDoList.Service.OperationsService
{
    public class GetTaskService : IFindTaskDto
    {
        readonly TaskDbContext taskContext = new TaskDbContext();
     //  private static MemoryCache cache = MemoryCache.Default;
        private  List<Task> listsTask;

        
            
      

        public List<Task> FindAllTasks()
        {
            listsTask = taskContext.Tasks.ToList();
            return DbFinder(listsTask);
        }

        public List<Task> FindUpcomingTasks(int amount)
        {
            listsTask = taskContext.Tasks.ToList();
            return DbFinder(listsTask)
                .Where(x => DateTime.Parse(x.DateTime) == DateTime.Today)
                .Where(x => DateTime.Parse(x.TimeSpan) >= DateTime.Parse(DateTime.Now.ToString("HH:mm")))
                .Take(amount).ToList();
        }

        public List<Task> FindDailyTasks()
        {
            listsTask = taskContext.Tasks.ToList();
            return DbFinder(listsTask).Where(x => DateTime.Parse(x.DateTime) == DateTime.Today).ToList();
        }

        public List<Task> FindByDataTasks(DateTime dateTime)
        {
            listsTask = taskContext.Tasks.ToList();
            return DbFinder(listsTask).Where(x => DateTime.Parse(x.DateTime) == dateTime).ToList();
        }
        public Task FindOneUpcomingTaskByActuallyDate(TimeSpan actuallyDate)
        {

            Task task = this.FindUpcomingTasks(1)
                .Where(x=>(TimeSpan.Parse(x.TimeSpan)-actuallyDate).ToString().Substring(0,2).Equals("00")).FirstOrDefault();
            return task;

        }
        public List<Task> DbFinder(List<Task> listsTask)
        {
            List<Task> tasksList = new List<Task>();

            listsTask.ForEach(
                    x =>
                    {
                        tasksList.Add(new Task()
                        {
                            Id = x.Id,
                            TimeSpan = x.TimeSpan,
                            DateTime = x.DateTime,
                            IdPriority = x.IdPriority,
                            Description = x.Description,

                        });
                    }
                  );

            return tasksList.OrderBy(x => DateTime.Parse(x.DateTime)).ThenBy(x => x.TimeSpan).ToList();
        }       
    }
}
