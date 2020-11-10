
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Model
{
   public class Priority
    {
        [Key]
        public int IdPriority { get; set; }
        public string Name { get; set; }
    }
}
