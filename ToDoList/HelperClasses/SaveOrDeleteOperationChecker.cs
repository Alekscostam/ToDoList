using System.Windows.Forms;
using ToDoList.Forms;
using ToDoList.Model;

namespace ToDoList.HelperClasses
{
    public class SaveOrDeleteOperationChecker
    {
        
        
        private  SaveOrDeleteOperationChecker()
        {

            // private const
        }

        public static string ChoiceOfOptions(TaskDto taskDto, Form forms)
        {
            string deleteChecker = OperationChecker("do you want to delete the task", "Delete task");
          
            string ChoiceResult = "";

            switch (deleteChecker)
            {
                case "Yes":
                    ChoiceResult = "Delete";
                    break;
                case "No":
                    string modifyChecker = OperationChecker("do you want to modify the task", "Modify task");
                    if (modifyChecker.Equals("Yes"))
                    {
                        forms.Close();
                        Form form = new FormDmlData(taskDto);
                        form.Show();
                    }
                    else if(modifyChecker.Equals("No"))
                        ChoiceResult = "Cancel";
                    
                    break;
                default:
                    return ChoiceResult;
            }
            return ChoiceResult;

        }

        private static string OperationChecker(string message, string caption)
        {         
            return MessageBox.Show(message, caption,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question).ToString();
        }      
    }
}
