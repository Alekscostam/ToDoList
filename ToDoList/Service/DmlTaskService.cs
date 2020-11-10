

using Microsoft.EntityFrameworkCore;
using ToDoList.DAO;
using ToDoList.Model;
using ToDoList.Service.TaskInterfaces;
using Task = ToDoList.Model.Task;

namespace ToDoList.Service.OperationsService
{
   public class DmlTaskService :IDmlTask
    {
        readonly TaskDbContext taskDbContext = new TaskDbContext();


        public void SaveTask(Task taskModel)
        {

            taskDbContext.Tasks.Add(taskModel);
            taskDbContext.SaveChanges();
        }
        public void ModifyTask(Task taskModel)
        {

            taskDbContext.Entry(taskModel).State = EntityState.Modified;
            taskDbContext.SaveChanges();
        }


        public void DeleteByIdTask(int IdTask)
        {
            Task taskToDelete = taskDbContext.Tasks.Find(IdTask);
            taskDbContext.Tasks.Remove(taskToDelete);
            taskDbContext.SaveChanges();
        }
    }
}
