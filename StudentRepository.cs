using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStudent
{
    public class StudentRepository
    {
        public List<Student> students = new List<Student>();
        
        public StudentRepository()
        {
            students.Add(new Student("Vasya", "Pupkin", 20));
        }
    }
}
