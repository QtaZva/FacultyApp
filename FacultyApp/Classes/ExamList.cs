using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyApp.Classes
{
    internal class ExamList
    {
        public int id {  get; set; }
        public string date, desc;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }
        public ExamList() { }

        public ExamList(string date, string desc)
        {
            this.date = date;
            this.desc = desc;
        }
    }
}
