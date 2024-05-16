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
    /// Логика взаимодействия для AdminFacultyWindow.xaml
    /// </summary>
    public partial class AdminFacultyWindow : Window
    {
        ApplicationContext db;
        public AdminFacultyWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();

            UpdateList();
        }
        private void UpdateList()
        {
            FacultyListBox.ItemsSource = db.Faculties.ToList();
        }

        private void SaveChanges_Button_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
            MessageBox.Show("Изменения сохранены");
        }

        private void AddExam_Button_Click(object sender, RoutedEventArgs e)
        {
            Faculties newFaculty = new Faculties(facultyName.Text, FacultyDesc.Text);
            db.Faculties.Add(newFaculty);
            db.SaveChanges();
            UpdateList();
        }

        private void DeleteStudent_Button_Click(object sender, RoutedEventArgs e)
        {
            Faculties selectedFaculty = FacultyListBox.SelectedItem as Faculties;
            if (selectedFaculty != null)
            {
                List<Faculties> faculty = (List<Faculties>)FacultyListBox.ItemsSource;
                faculty.Remove(selectedFaculty);

                db.Faculties.Remove(selectedFaculty);

                db.SaveChanges();

                MessageBox.Show("Changes are saved");
                UpdateList();
            }
        }
    }
}
