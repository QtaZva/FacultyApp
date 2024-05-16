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
    /// Логика взаимодействия для DeductianListViewWindow.xaml
    /// </summary>
    public partial class DeductianListViewWindow : Window
    {
        ApplicationContext db;
        public DeductianListViewWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();

            List<Students> students = db.Students.ToList();
            List<DeductionList> deductionLists = db.DeductionList.ToList();

            List<Students> studentsOnDeduction = new List<Students>();

            foreach (Students student in students)
            {
                foreach(DeductionList deduction in deductionLists)
                {
                    if(student.id == deduction.StudentId)
                    {
                        student.login = "";
                        student.password = "";
                        studentsOnDeduction.Add(student);
                    }
                }
            }
            StudentsDataGrid.ItemsSource = studentsOnDeduction;
        }
    }
}
