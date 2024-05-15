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
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        ApplicationContext db;
        public RegisterWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }

        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Register_Button_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Password;
            string name = NameTextBox.Text;
            string surname = SurnameTextBox.Text;
            string patronymic = PatronymicTextBox.Text;
            string birthdayDate = BirthdayDatePicker.Text;

            Students newstudent = new Students(name, surname, patronymic, birthdayDate, login, password);

            db.Students.Add(newstudent);
            db.SaveChanges();
        }
    }
}
