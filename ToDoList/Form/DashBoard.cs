using System;
using System.Drawing;
using System.Windows.Forms;
using ToDoList.Forms;
using ToDoList.Model;
using ToDoList.Service.OperationsService;

namespace ToDoList
{
    public partial class DashBoard : Form
    {
        readonly GetTaskService getTaskService = new GetTaskService();
        private Button actuallyButton;
        private Form formRemember;
        private int ticks;
        public DashBoard()
        {
            InitializeComponent();
            Startup(new FormUpcomingTasks());
            actuallyButton = new Button();
        }



        private void ActivateColorButton(object btnSenderColor = null)
        {
            Color color = Color.FromArgb(111, 183, 214);
            if (btnSenderColor != null)
            {
                actuallyButton = (Button)btnSenderColor;
                actuallyButton.BackColor = color;

            }
            else
                btnUpcomingTasks.BackColor = color;

        }
        private void DeactivateRestOfColorButtons()
        {
            foreach (Control control in panel.Controls)
            {
                if (!(control is Panel))
                {
                    Color color = Color.FromArgb(52, 180, 235);
                    control.BackColor = color;
                }
            }
        }

        private void OpenDifferentForm(object sender, Form form)
        {

            if (formRemember != null)
                formRemember.Hide();


            this.panelMain.Controls.Clear();
            DeactivateRestOfColorButtons();
            ActivateColorButton(sender);
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            this.panelMain.Controls.Add(form);
            formRemember = form;
            formRemember.Show();


        }
        private void Startup(Form form)
        {


            SetLabelText("Upcoming tasks");
            OpenDifferentForm(null, form);
        }
        

        private void BtnUpcomingTasks_Click(object sender, EventArgs e)
        {

            SetLabelText("Upcoming tasks");
            OpenDifferentForm(sender, new FormUpcomingTasks());

        }

        private void BtnAllTasks_Click(object sender, EventArgs e)
        {
            SetLabelText("All tasks");
            OpenDifferentForm(sender, new FormAllTasks());
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            SetLabelText("Inforamtions");
            OpenDifferentForm(sender, new FormInformation());
        }

        private void BtnDmlData_Click(object sender, EventArgs e)
        {
            SetLabelText("Add tasks");
            OpenDifferentForm(sender, new FormDmlData());
        }

        private void SetLabelText(string text)
        {
            lblLogo.Text = text;
        }

       
        private void TimerDbChecker_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks == 1)
            {
                TimeSpan actuallyDate = TimeSpan.Parse(DateTime.Now.TimeOfDay.ToString().Substring(0, 5));

                TaskDto taskDto = getTaskService.FindOneUpcomingTaskByActuallyDate(actuallyDate);
                if (taskDto != null)
                {
                    ShowMessage(taskDto);

                }

            }
            else if (ticks == 120)
                ticks = 0;

        }

        private void ShowMessage(TaskDto taskDto)
        {
            Form a = new FormPopup(taskDto)
            {
                StartPosition = FormStartPosition.Manual
            };
            a.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - a.Width,
                                   Screen.PrimaryScreen.WorkingArea.Height - a.Height);
            a.Show();
        }

        private void DashBoard_Resize(object sender, EventArgs e)
        {
            bool cursorNotInBar = Screen.GetWorkingArea(this).Contains(Cursor.Position);
            if (this.WindowState == FormWindowState.Minimized && cursorNotInBar)
            {
                this.ShowInTaskbar = false;
                notifyIcon.Visible = true;
                Hide();
            }
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon.Visible = false;
            this.Visible = true;
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
        // DashBoard Load
        }
    }
}
