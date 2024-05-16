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
    /// Логика взаимодействия для AdminStudentViewWindow.xaml
    /// </summary>
    public partial class AdminStudentViewWindow : Window
    {
        ApplicationContext db;
        public AdminStudentViewWindow()
        {
            InitializeComponent();

            db = new ApplicationContext();

            UpdateList();
        }
        private void UpdateList()
        {
            StudentsListBox.ItemsSource = db.Students.ToList();
        }

        private void SaveChanges_Button_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
            MessageBox.Show("Changes are saved");

            UpdateList();
        }

        private void DeleteStudent_Button_Click(object sender, RoutedEventArgs e)
        {
            Students selectedStedent = StudentsListBox.SelectedItem as Students;
            if (selectedStedent != null)
            {
                List<Students> students = (List<Students>)StudentsListBox.ItemsSource;
                students.Remove(selectedStedent);

                db.Students.Remove(selectedStedent);

                db.SaveChanges();

                MessageBox.Show("Changes are saved");
                UpdateList();
            }
            /*
            Events selectedEvent = EventsListBox.SelectedItem as Events;
            if (selectedEvent != null)
            {
                List<Events> events = (List<Events>)EventsListBox.ItemsSource;
                events.Remove(selectedEvent);

                db.Events.Remove(selectedEvent);

                db.SaveChanges();

                ListUpdate();

                MessageBox.Show("Изменения сохранены");
            }
            */
        }
    }
}
