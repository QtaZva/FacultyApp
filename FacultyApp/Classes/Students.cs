using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace FacultyApp.Classes
{
    internal class Students
    {
        public int id {  get; set; }
        public string name, surname, patronymic, birthdayDate, login, password;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }
        public string BirthdayDate
        {
            get { return birthdayDate; }
            set { birthdayDate = value; }
        }
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public Students() { }

        public Students(string name, string surname, string patronymic, string birthdayDate, string login, string password)
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
            this.birthdayDate = birthdayDate;
            this.login = login;
            this.password = password;
        }
    }
}
