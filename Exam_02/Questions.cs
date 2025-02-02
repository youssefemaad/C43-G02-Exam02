using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02
{
    internal abstract class Questions
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Marks { get; set; }
        public List<Answer> Answers { get; set; }
        public int CorrectAnswer { get; set; }

        public Questions(string header, string body, int marks)
        {
            Header = header;
            Body = body;
            Marks = marks;
        }

        public abstract bool ValidateAnswer(object answer);
    }
}