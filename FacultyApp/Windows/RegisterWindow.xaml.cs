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
            string name = NameTextBox.Text.Trim();
            string surname = SurnameTextBox.Text.Trim();
            string patronymic = PatronymicTextBox.Text.Trim();
            string birthdayDate = BirthdayDatePicker.Text.Trim();

            if(login.Length < 5)
                MessageBox.Show("Login is too small");

            else if (password.Length < 8)
                MessageBox.Show("Password is too small");

            else if (name.Length == 0)
                MessageBox.Show("Enter your name");

            else if (surname.Length == 0)
                MessageBox.Show("Enter your surname");

            else if(!password.Any(Char.IsLower))
                MessageBox.Show("Password must contains lower case words");

            else if(!password.Any(Char.IsUpper))
                MessageBox.Show("Password must contains upper case words");

            else if(!password.Any(Char.IsDigit))
                MessageBox.Show("Password must contains numbers");

            else if(password.Intersect("#$%^&_").Count() == 0)
                MessageBox.Show("Password must contains special symbols(#$%^&_)");

            else if(BirthdayDatePicker.SelectedDate > DateTime.Now)
            {
                MessageBox.Show("Wrong birthday date");
            }

            else
            {
                if(db.Students.Where(s => s.Login == login).FirstOrDefault() == null)
                {
                    Students newstudent = new Students(name, surname, patronymic, birthdayDate, login, password);

                    db.Students.Add(newstudent);
                    db.SaveChanges();
                    MessageBox.Show("Account created");
                }
                else
                {
                    MessageBox.Show("This login is already used");
                }
            }
        }
    }
}
