using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int examDate, int numberOfQuestions) : base(examDate, numberOfQuestions)
        {

        }

        public override void StartExam()
        {
            int score = 0;
            foreach (var question in Questions)
            {
                Console.WriteLine(question.Header);
                Console.WriteLine(question.Body);
                foreach (var answer in question.Answers)
                {
                    Console.Write($"{answer.AnswerId}. {answer.AnswerText}");
                }

                int userAnswer = int.Parse(Console.ReadLine());

                if (question.ValidateAnswer(userAnswer))
                {
                    score += question.Marks;
                }
                Console.WriteLine("------------------------------");
            }
            Console.WriteLine($"Your Score: {score}/{Questions.Sum(q => q.Marks)}");
        }
    }
}
