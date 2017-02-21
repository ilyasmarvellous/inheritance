using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Principal p = new Principal();
            p.Monitor();
            Teacher t = new Teacher();
            t.Monitor();
            t.Teach();
            Student s = new Student();
            s.Monitor();
            s.Learn();
            Console.ReadKey();
        }
        class Principal
        {
            public void Monitor()
            {
                Console.WriteLine("Monitor");
            }
        }
        class Teacher : Principal
        {
            public void Teach()
            {
                Console.WriteLine("Teach");
            }
        }
        class Student : Principal
        {
            public void Learn()
            {
                Console.WriteLine("Learn");
            }
        }
    }
}