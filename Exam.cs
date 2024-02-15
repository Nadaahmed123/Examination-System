using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestion { get; set; }
        public List<Question> ExamQuestion { get; set; }
        public List<int> Answer { get; set; }
        public Exam(int _Time, int _NumberOfQuestion)
        {
            Time = _Time;
            NumberOfQuestion = _NumberOfQuestion;
            ExamQuestion = new List<Question>(_NumberOfQuestion);
            Answer = new List<int>(_NumberOfQuestion);
        }
        public void ShowQuestionsAndStudentAnswer()
        {
            Console.Clear();

            for (int i = 0; i < ExamQuestion.Count; i++)
            {
                Console.WriteLine(ExamQuestion[i].ToString());
                int answer;
                int.TryParse(Console.ReadLine(), out answer);
                Answer.Add(answer);
                Console.WriteLine("================================================================");
            }
        }
        public abstract void ShowExam();
    }
}
