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
    /// Логика взаимодействия для AdminPanelWindow.xaml
    /// </summary>
    public partial class AdminPanelWindow : Window
    {
        public AdminPanelWindow()
        {
            InitializeComponent();
        }

        private void Profile_Button_Click(object sender, RoutedEventArgs e)
        {
            AdminProfileWindow profileWindow = new AdminProfileWindow();
            profileWindow.ShowDialog();
        }

        private void Students_Button_Click(object sender, RoutedEventArgs e)
        {
            AdminStudentViewWindow studentViewWindow = new AdminStudentViewWindow();
            studentViewWindow.ShowDialog();
        }

        private void Exams_Button_Click(object sender, RoutedEventArgs e)
        {
            AdminExamViewWindow adminExamViewWindow = new AdminExamViewWindow();
            adminExamViewWindow.ShowDialog();
        }

        private void Deducation_Button_Click(object sender, RoutedEventArgs e)
        {
            AdminDeductianList adminDeductianList = new AdminDeductianList();
            adminDeductianList.ShowDialog();
        }

        private void faculty_Button_Click(object sender, RoutedEventArgs e)
        {
            AdminFacultyWindow adminFacultyWindow = new AdminFacultyWindow();
            adminFacultyWindow.ShowDialog();
        }

        private void dekan_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
