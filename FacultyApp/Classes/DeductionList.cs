using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyApp.Classes
{
    internal class DeductionList
    {
        public int studentId;
        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
        public DeductionList() { }
        public DeductionList(int studentId)
        {
            this.studentId = studentId;
        }
    }
}
