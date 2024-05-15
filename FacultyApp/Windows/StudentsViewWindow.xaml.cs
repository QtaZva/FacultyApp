using FacultyApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FacultyApp.Windows
{
    /// <summary>
    /// Логика взаимодействия для StudentsViewWindow.xaml
    /// </summary>
    public partial class StudentsViewWindow : Window
    {
        ApplicationContext db;
        public StudentsViewWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();

            List<Students> students = db.Students.ToList();
            List<Students> studentsList = new List<Students>();
            foreach (var student in students)
            {
                student.login = null;
                student.password = null;
                studentsList.Add(student);
            }

            StudentsDataGrid.ItemsSource = studentsList;

        }
    }
}
