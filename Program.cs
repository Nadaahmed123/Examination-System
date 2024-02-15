using System;
using System.Diagnostics;
namespace Examination_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(10, "c#");
            subject.CreateExam();
            Console.Clear();
            Console.Write("Do you want to start exam Y | N : ");
            if (char.Parse(Console.ReadLine()) == 'y')
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                subject.Exam.ShowExam();
                Console.WriteLine($"The Elabsed Time = {sw.Elapsed}");

            }
        }
    }
}
