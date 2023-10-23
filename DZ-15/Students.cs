using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_15
{
    internal class Students
    {
        public string name;
        public int grade;
        public int course;


        public Students(string name,int grade,int course) 
        {
            this.name = name;
            this.grade = grade;
            this.course = course;
        }
        public override string ToString()
        {
            return "Ім'я: " + name + "   Оцінка: " + grade + "   Курс: "+ course;
        }
    }
}
