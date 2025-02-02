using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02
{
    internal abstract class Exam
    {
        public int ExamTime { get; set; }
        public int NumberOfQuestions { get; set; }
        public List<Questions> Questions { get; set; }

        public Exam(int examtime, int numberOfQuestions)
        {
            ExamTime = examtime;
            NumberOfQuestions = numberOfQuestions;
            Questions = new List<Questions>();
        }

        public void AddQuestion(Questions question)
        {
            Questions.Add(question);
        }

        public abstract void StartExam();
    }
}
