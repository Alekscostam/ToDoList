
using System.Drawing;
using System.Windows.Forms;

namespace ToDoList.HelperClasses
{
  public static class CustomDataGridView
    {

      public  static void StartupDesign(DataGridView dataGridView)
        {
            



            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(237, 245, 252);
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView.DefaultCellStyle.Font = new Font("Tahoma", 12);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView.BackgroundColor = Color.White;


            foreach (DataGridViewColumn item in dataGridView.Columns)
            {
                item.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12);
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 180, 235);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

    }
}
