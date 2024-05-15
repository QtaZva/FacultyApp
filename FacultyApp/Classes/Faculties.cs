using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyApp.Classes
{
    internal class Faculties
    {
        public int id {  get; set; }
        public string name, desc;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }
        public Faculties() { }

        public Faculties(string name, string desc)
        {
            this.name = name;
            this.desc = desc;
        }
    }
}
