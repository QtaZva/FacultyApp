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
    /// Логика взаимодействия для AdminExamViewWindow.xaml
    /// </summary>
    public partial class AdminExamViewWindow : Window
    {
        ApplicationContext db;
        public AdminExamViewWindow()
        {
            InitializeComponent();

            db = new ApplicationContext();

            UpdateList();
        }
        private void UpdateList()
        {
            ExamsListBox.ItemsSource = db.ExamList.ToList();
        }

        private void SaveChanges_Button_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
            MessageBox.Show("Changes are saved");

            UpdateList();
        }

        private void DeleteStudent_Button_Click(object sender, RoutedEventArgs e)
        {
            ExamList selectedExam = ExamsListBox.SelectedItem as ExamList;
            if (selectedExam != null)
            {
                List<ExamList> exams = (List<ExamList>)ExamsListBox.ItemsSource;
                exams.Remove(selectedExam);

                db.ExamList.Remove(selectedExam);

                db.SaveChanges();

                MessageBox.Show("Changes are saved");
                UpdateList();
            }
        }

        private void AddExam_Button_Click(object sender, RoutedEventArgs e)
        {
            ExamList newExam = new ExamList(ExamDate.Text, ExamDesc.Text);

            db.ExamList.Add(newExam);

            db.SaveChanges();

            MessageBox.Show("Changes are saved");
            UpdateList();
        }
    }
}
