using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace association
{
    class Student
    {
        List<Teacher> teachers;
        public void AddTeachers(List<Teacher> teachers)
        {
            this.teachers = teachers;
        }
    }
}
