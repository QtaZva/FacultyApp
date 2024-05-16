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
    /// Логика взаимодействия для AdminDeductianList.xaml
    /// </summary>
    public partial class AdminDeductianList : Window
    {
        ApplicationContext db;
        public AdminDeductianList()
        {
            InitializeComponent();

            db = new ApplicationContext();

            UpdateList();
        }
        private void UpdateList()
        {
            List<Students> students = db.Students.ToList();
            List<DeductionList> deductionLists = db.DeductionList.ToList();

            List<Students> studentsOnDeduction = new List<Students>();

            foreach (Students student in students)
            {
                foreach (DeductionList deduction in deductionLists)
                {
                    if (student.id == deduction.StudentId)
                    {
                        studentsOnDeduction.Add(student);
                    }
                }
            }
            DeductiansListBox.ItemsSource = studentsOnDeduction;
        }

        private void AddDeductian_Button_Click(object sender, RoutedEventArgs e)
        {
            Students futureDeductian = db.Students.FirstOrDefault(s => s.Login == DeductianLogin.Text);
            if(futureDeductian != null)
            {
                DeductionList deductionList = new DeductionList(futureDeductian.id);
                db.DeductionList.Add(deductionList);

                db.SaveChanges();

                UpdateList();
            }
        }

        private void DeleteStudent_Button_Click(object sender, RoutedEventArgs e)
        {
            Students selectedStudent = DeductiansListBox.SelectedItem as Students;
            if (selectedStudent != null)
            {

                DeductionList deduction = db.DeductionList.Where(d => d.StudentId == selectedStudent.id).FirstOrDefault();

                db.DeductionList.Remove(deduction);

                db.SaveChanges();

                MessageBox.Show("Changes are saved");
                UpdateList();
            }
            else
                MessageBox.Show("Error");
        }
    }
}
