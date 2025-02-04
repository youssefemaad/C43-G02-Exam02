using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public void CreateExam()
        {
            Console.Write("Please Enter the type of exam you want to create (1 for Practical and 2 for Final): ");
            int examType = int.Parse(Console.ReadLine());
            Console.Write("Please Enter the Time of Exam in minutes: ");
            int time = int.Parse(Console.ReadLine());
            Console.Write("Please Enter the Number of Questions You want to create: ");
            int numQuestions = int.Parse(Console.ReadLine());

            if (examType == 1)
            {
                Exam = new PracticalExam(time, numQuestions);

                for (int i = 0; i < numQuestions; i++)
                {
                    Console.Write($"Please Enter the Body of Question ({i + 1}): ");
                    string body = Console.ReadLine();
                    Console.Write("Please Enter The Marks of Question: ");
                    int mark = int.Parse(Console.ReadLine());

                    List<Answer> answers = new List<Answer>();
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write($"Please Enter the Answer Number ({j + 1}): ");
                        string ans = Console.ReadLine();
                        answers.Add(new Answer(j + 1, ans));
                    }

                    Console.Write("Please Enter the Correct Answer Id: ");
                    int correctAnswerId = int.Parse(Console.ReadLine());
                    Exam.AddQuestion(new McqQuestion("MCQ Questions", body, mark, answers, correctAnswerId));

                }
            }

            else
            {
                Exam = new FinalExam(time, numQuestions);

                for (int i = 0; i < numQuestions; i++)
                {
                    Console.Write($"Please choose the Type of Question Number ({i + 1}) (1 for T/F || 2 for MCQ): ");
                    int qType = int.Parse(Console.ReadLine());
                    Console.Write("Please Enter the Body of Question: ");
                    string body = Console.ReadLine();
                    Console.Write("Please Enter The Marks of Question: ");
                    int mark = int.Parse(Console.ReadLine());

                    if (qType == 1)
                    {
                        Console.Write("Please Enter the Correct Answer (1 for True | 2 for False): ");
                        int correctAnswer = int.Parse(Console.ReadLine());
                        Exam.AddQuestion(new TrueFalse("True/False Questions", body, mark, correctAnswer));
                    }
                    else
                    {
                        List<Answer> answers = new List<Answer>();
                        for (int j = 0; j < 4; j++)
                        {
                            Console.Write($"Please Enter the Answer Number ({j + 1}): ");
                            string ans = Console.ReadLine();
                            answers.Add(new Answer(j + 1, ans));
                        }

                        Console.Write("Please Enter the Correct Answer Id: ");
                        int correctAnswerId = int.Parse(Console.ReadLine());
                        Exam.AddQuestion(new McqQuestion("MCQ Questions", body, mark, answers, correctAnswerId));
                    }

                }
            }

        }
    }
}
