
using ToDoList.Model;

namespace ToDoList.Service.TaskInterfaces
{
   public interface IDmlTask 
    {
        void SaveTask(Task task);
        void ModifyTask(Task task);
        void DeleteByIdTask(int IdTask);

    }
}
