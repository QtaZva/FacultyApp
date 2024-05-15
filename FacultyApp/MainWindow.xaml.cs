using FacultyApp.Classes;
using FacultyApp.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FacultyApp
{
    public partial class MainWindow : Window
    {
        ApplicationContext db;
        public MainWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }

        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Password;

            /*
            User authUser = new User();
            using (ApplicationContext db = new ApplicationContext())
            {
                authUser = db.Users.Where(b => b.Login == login && b.Pass == pass_1).FirstOrDefault();
            }
            */

            Students user = new Students();
            user = db.Students.Where(u => u.Login == login && u.Password == password).FirstOrDefault();

            if (user != null)
            {
                User.user_id = user.id;
                if(user.faculty_id == 0)
                {
                    FacultySelectionWindow facultySelectionWindow = new FacultySelectionWindow();
                    facultySelectionWindow.Show();
                    this.Close();
                }
                else
                {
                    HomeWindow homeWindow = new HomeWindow();
                    homeWindow.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Login or password was entered incorrectly");
            }
        }

        private void CreateAccount_Button_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
            this.Close();
        }
    }
}
