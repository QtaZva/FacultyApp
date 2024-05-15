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
    public partial class ProfileWindow : Window
    {
        ApplicationContext db;
        public ProfileWindow()
        {
            db = new ApplicationContext();
            Students student = new Students();
            student = db.Students.FirstOrDefault(s => s.id == User.user_id);
            
            InitializeComponent();

            LoginTextBox.Text = student.Login;
            PasswordTextBox.Password = student.Password;
            NameTextBox.Text = student.Name;
            SurnameTextBox.Text = student.Surname;
            PatronymicTextBox.Text = student.Patronymic;
            BirthdayDatePicker.Text = student.BirthdayDate;
        }

        private void SaveChanges_Button_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Password;
            string name = NameTextBox.Text.Trim();
            string surname = SurnameTextBox.Text.Trim();
            string patronymic = PatronymicTextBox.Text.Trim();
            string birthdayDate = BirthdayDatePicker.Text.Trim();

            if (login.Length < 5)
                MessageBox.Show("Login is too small");

            else if (password.Length < 8)
                MessageBox.Show("Password is too small");

            else if (name.Length == 0)
                MessageBox.Show("Enter your name");

            else if (surname.Length == 0)
                MessageBox.Show("Enter your surname");

            else if (!password.Any(Char.IsLower))
                MessageBox.Show("Password must contains lower case words");

            else if (!password.Any(Char.IsUpper))
                MessageBox.Show("Password must contains upper case words");

            else if (!password.Any(Char.IsDigit))
                MessageBox.Show("Password must contains numbers");

            else if (password.Intersect("#$%^&_").Count() == 0)
                MessageBox.Show("Password must contains special symbols(#$%^&_)");

            else if (BirthdayDatePicker.SelectedDate > DateTime.Now)
                MessageBox.Show("Wrong birthday date");

            else
            {
                Students student = new Students();
                student = db.Students.FirstOrDefault(s => s.id == User.user_id);

                student.name = NameTextBox.Text;
                student.surname = SurnameTextBox.Text;
                student.patronymic = PatronymicTextBox.Text;
                student.login = LoginTextBox.Text;
                student.password = PasswordTextBox.Password;
                student.birthdayDate = BirthdayDatePicker.Text;

                db.SaveChanges();
            }
        }
    }
}
