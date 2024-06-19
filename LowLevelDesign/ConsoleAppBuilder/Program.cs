using System;

namespace ConsoleAppBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object of student validated before creation 
            //With the help of builder object validation of props done, 

            Student st = Student.getBuilder().setId(10).setName("tony").setAge(5).setGradYear(2015).build();
            Console.WriteLine("Hello World!");
        }
    }
}
