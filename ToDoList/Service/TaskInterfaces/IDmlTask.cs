
using ToDoList.Model;

namespace ToDoList.Service.TaskInterfaces
{
   public interface IDmlTask 
    {
        void SaveTask(Task taskModel);
        void ModifyTask(Task taskModel);
        void DeleteByIdTask(int IdTask);
    }
}
