using LiseYonetim.Entities;
using LiseYonetim.Service;

namespace LiseYonetim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            _school = new School();
            _studentService = new(_school);
            _courseService = new(_school);
            _teacherService = new(_school);
            InitializeComponent();
        }

        private readonly School _school = new School();
        private readonly StudentService _studentService;
        private readonly CourseService _courseService;
        private readonly TeacherService _teacherService;
        private void Form1_Load(object sender, EventArgs e)
        {
            FillDataGrids();
            FillComboBoxes();
        }

        private void FillDataGrids()
        {
            var students = _studentService.GetStudents();
            dgStudent.DataSource = students;

            var teachers = _teacherService.GetTeachers();
            dgTeacher.DataSource = teachers;

            var courses = _courseService.GetCourses();
            dgCourse.DataSource = courses;

        }

        private void FillComboBoxes()
        {
            cbCourseName.DataSource = _courseService.GetCoursesDropDownList();
            cbCourseName.DisplayMember = "Text";
            cbCourseName.ValueMember = "Value";

            cbTeacherName.DataSource = _teacherService.GetTeachersDropDownList();
            cbTeacherName.DisplayMember = "Text";
            cbTeacherName.ValueMember = "Value";
        }

        private void btnStudentCreate_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                Name = txtStudentName.Text,
                LastName = txtStudentLastName.Text,
                Email = txtStudentEmail.Text,
                CourseId = (int)cbCourseName.SelectedValue,
            };
            _studentService.CreateStudent(student);
            FillDataGrids();
        }

        private void btnTeacherCreate_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher()
            {
                Name = txtTeacherName.Text,
                LastName = txtTeacherLastName.Text,
                Email = txtTeacherEmail.Text,

            };
            _teacherService.CreateTeacher(teacher);
            ClearAllTextboxes();
            FillComboBoxes();
            FillDataGrids();
        }


        private void btnCourseCreate_Click(object sender, EventArgs e)
        {
            Course course = new Course()
            {
                Name = txtCourseName.Text,
                TeacherId = (int)cbTeacherName.SelectedValue
            };
            _courseService.CreateCourse(course);
            ClearAllTextboxes();
            FillComboBoxes();
            FillDataGrids();
        }

        private void ClearAllTextboxes()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textbox = (TextBox)control;
                    textbox.Clear();
                }
            }
        }
    }
}