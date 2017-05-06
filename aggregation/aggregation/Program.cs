using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aggregation
{
    class Program
    {

        //Also referred to as the weak association
        static void Main(string[] args)
        {
            Department computerScienceDept = new Department() { Name = "Computer Science"};
            Department biologyDept = new Department() { Name = "Biology Dept" };

            
            Teacher computerTeacher = new Teacher() { Name = "Sushil"};
            computerScienceDept.Teachers.Add(computerTeacher);
            biologyDept.Teachers.Add(computerTeacher);
        }
    }
}
