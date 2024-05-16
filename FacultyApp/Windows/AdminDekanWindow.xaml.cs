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
    /// Логика взаимодействия для AdminDekanWindow.xaml
    /// </summary>
    public partial class AdminDekanWindow : Window
    {
        ApplicationContext db;
        public AdminDekanWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }

        private void Reg_Button_Click(object sender, RoutedEventArgs e)
        {
            Dekans newDekan = new Dekans("name", "surname", "patronymic", "12.13.2005", LoginTextBox.Text, PasswordTextBox.Password, 0);

            db.Dekans.Add(newDekan);
            db.SaveChanges();
            MessageBox.Show("Dekan created");
        }
    }
}
