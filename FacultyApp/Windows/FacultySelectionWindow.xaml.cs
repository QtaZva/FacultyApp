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
    public partial class FacultySelectionWindow : Window
    {
        ApplicationContext db;
        public FacultySelectionWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
            FacultiesListBox.ItemsSource = db.Faculties.ToList();
        }

        private void SelectFaculty_Button_Click(object sender, RoutedEventArgs e)
        {
            Faculties selectedFaculty = FacultiesListBox.SelectedItem as Faculties;
            Students student = new Students();
            if(selectedFaculty != null )
            {
                student = db.Students.Where(u => u.id == User.user_id).FirstOrDefault();
                student.faculty_id = selectedFaculty.id;
                db.SaveChanges();
                MessageBox.Show("Faculty choosed");
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
