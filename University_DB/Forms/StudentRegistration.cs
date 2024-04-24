using University_DB.Forms;

namespace University_DB
{
    public partial class StudentRegistration : Form
    {
        public StudentRegistration()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            TeacherRegistration teacherForm = new();

            Hide();
            teacherForm.Show();
        }
    }
}
