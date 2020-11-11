

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

        public void SaveTask(Task task)
        {

            taskDbContext.Tasks.Add(task);
            taskDbContext.SaveChanges();
        }
        public void ModifyTask(Task task)
        {

            taskDbContext.Entry(task).State = EntityState.Modified;
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
