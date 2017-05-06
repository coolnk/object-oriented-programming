using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace association
{
    class Program
    {
        //Association why because the student and teacher have association and can live independent of each other. The student does not own the teacher
        static void Main(string[] args)
        {
            Student nirjal = new Student();
            List<Teacher> teachers = new List<Teacher>();
            nirjal.AddTeachers(teachers);           


        }
    }
}
