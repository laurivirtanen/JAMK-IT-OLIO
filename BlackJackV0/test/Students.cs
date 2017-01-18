using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;


namespace test
{
    public class Studenttor
    {
        public static void StudentProgram()
        {
            Students();
        }

        public static void Students()
        {
            List<Student> students = new List<Student>();

            Student student1 = new Student("daa", "Hortensen", 25, 4.3f);
            Student student2 = new Student("Lasse", "Mortensen", 26, 4.4f);

            students.Add(student1);
            students.Add(student2);

            foreach (var Student in students)
            {

                Console.WriteLine("--Student--");
                Console.WriteLine(Student.Name);
                Console.WriteLine(Student.Age);
                Console.WriteLine(Student.Avg);
            }
        }
    }
}
