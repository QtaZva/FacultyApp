using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyApp.Classes
{
    internal class Dekans
    {
        public int id { get; set; }
        public string name, surname, patronymic, birthdayDate, login, password;
        public int faculty_id;

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
        public int Faculty_id
        {
            get { return faculty_id; }
            set { faculty_id = value; }
        }
        public Dekans() { }

        public Dekans(string name, string surname, string patronymic, string birthdayDate, string login, string password, int faculty_id)
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
            this.birthdayDate = birthdayDate;
            this.login = login;
            this.password = password;
            this.faculty_id = faculty_id;
        }
    }
}
