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
    /// Логика взаимодействия для HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        public HomeWindow()
        {
            InitializeComponent();
        }

        private void Profile_Button_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow profileWindow = new ProfileWindow();
            profileWindow.ShowDialog();
        }

        private void ChangeFaculry_Button_Click(object sender, RoutedEventArgs e)
        {
            FacultySelectionWindow facultySelectionWindow = new FacultySelectionWindow();
            facultySelectionWindow.ShowDialog();
        }

        private void StudentsView_Button_Click(object sender, RoutedEventArgs e)
        {
            StudentsViewWindow studentsViewWindow = new StudentsViewWindow();
            studentsViewWindow.ShowDialog();
        }

        private void DeductianList_Button_Click(object sender, RoutedEventArgs e)
        {
            DeductianListViewWindow deductianListViewWindow = new DeductianListViewWindow();
            deductianListViewWindow.ShowDialog();
        }

        private void ExamList_Button_Click(object sender, RoutedEventArgs e)
        {
            ExamListViewWindow examListViewWindow = new ExamListViewWindow();
            examListViewWindow.ShowDialog();
        }
    }
}
