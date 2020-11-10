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

        
            
      

        public List<TaskDto> FindAllTasks()
        {
            listsTask = taskContext.Tasks.ToList();
            return DbFinder(listsTask);
        }

        public List<TaskDto> FindUpcomingTasks(int amount)
        {
            listsTask = taskContext.Tasks.ToList();
            return DbFinder(listsTask)
                .Where(x => DateTime.Parse(x.DateTime) == DateTime.Today)
                .Where(x => DateTime.Parse(x.TimeSpan) >= DateTime.Parse(DateTime.Now.ToString("HH:mm")))
                .Take(amount).ToList();
        }

        public List<TaskDto> FindDailyTasks()
        {
            listsTask = taskContext.Tasks.ToList();
            return DbFinder(listsTask).Where(x => DateTime.Parse(x.DateTime) == DateTime.Today).ToList();
        }

        public List<TaskDto> FindByDataTasks(DateTime dateTime)
        {
            listsTask = taskContext.Tasks.ToList();
            return DbFinder(listsTask).Where(x => DateTime.Parse(x.DateTime) == dateTime).ToList();
        }
        public TaskDto FindOneUpcomingTaskByActuallyDate(TimeSpan actuallyDate)
        {

            TaskDto taskDto = this.FindUpcomingTasks(1)
                .Where(x=>(TimeSpan.Parse(x.TimeSpan)-actuallyDate).ToString().Substring(0,2).Equals("00")).FirstOrDefault();
            return taskDto;

        }
        public List<TaskDto> DbFinder(List<Task> listsTask)
        {
            List<TaskDto> tasksListDto = new List<TaskDto>();

            listsTask.ForEach(
                    x =>
                    {
                        tasksListDto.Add(new TaskDto()
                        {
                            Id = x.Id,
                            TimeSpan = x.TimeSpan,
                            DateTime = x.DateTime,
                            IdPriority = x.IdPriority.ToString(),
                            Description = x.Description,

                        });
                    }
                  );

            return tasksListDto.OrderBy(x => DateTime.Parse(x.DateTime)).ThenBy(x => x.TimeSpan).ToList();
        }       
    }
}
