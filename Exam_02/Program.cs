using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam_02;


namespace Exam_02
{
    class Programn
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(1, "Maths");
            subject.CreateExam();
            Console.Clear();
            Console.WriteLine("Do You want to Start The Exam (y | n)");

            if (char.Parse(Console.ReadLine()) == 'y')
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                subject.Exam.StartExam();
                Console.WriteLine($"The Elapsed Time = {stopwatch.Elapsed}");
            }

        }
    }
}