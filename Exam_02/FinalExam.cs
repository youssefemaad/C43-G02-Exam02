using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02
{
    internal class FinalExam : Exam
    {
        public FinalExam(int examDate, int numberOfQuestions) : base(examDate, numberOfQuestions)
        {

        }

        public override void StartExam()
        {
            int score = 0;
            foreach (var question in Questions)
            {
                System.Console.WriteLine(question.Header);
                Console.WriteLine(question.Body);
                if (question is TrueFalse)
                {
                    Console.Write("1. True , 2. False");
                }
                else if (question is McqQuestion)
                {
                    foreach (var answer in question.Answers)
                    {
                        Console.Write($"{answer.AnswerId}. {answer.AnswerText}  ");
                    }

                }
                Console.WriteLine();
                Console.Write("Enter The index of the Answer: ");
                int userAnswer = int.Parse(Console.ReadLine());
                if (question.ValidateAnswer(userAnswer))
                {
                    score += question.Marks;
                }
                System.Console.WriteLine("------------------------------");
            }
            Console.WriteLine($"Your Score: {score}/{Questions.Sum(q => q.Marks)}");
        }

    }
}
