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
    /// Логика взаимодействия для ExamListViewWindow.xaml
    /// </summary>
    public partial class ExamListViewWindow : Window
    {
        ApplicationContext db;
        public ExamListViewWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
            List<ExamList> examList = db.ExamList.ToList();
            ExamsDataGrid.ItemsSource = examList;
        }
    }
}
