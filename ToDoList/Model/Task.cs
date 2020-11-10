using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList.Model
{
   
   public class Task
    {
        [Key]
        public int Id { get; set; }

        public int IdPriority { get; set; }
        public Priority Priority { get; set; }

        public string Description { get; set; }

        public string DateTime { get; set; }
        public string TimeSpan { get; set; }      

    }
}
