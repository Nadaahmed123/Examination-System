using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class FinalExam : Exam
    {
        public FinalExam(int _Time, int _NumberQuestion) : base(_Time, _NumberQuestion)
        {

        }

        public override void ShowExam()
        {
            ShowQuestionsAndStudentAnswer();
            Console.Clear();
            Console.WriteLine("Your Answers");
            int totalMark = 0, studentMark = 0;
            for (int i = 0; i < ExamQuestion.Count; i++)
            {
                int rightanswerId = ExamQuestion[i].Answer.Length;
                Console.WriteLine($"Q{i + 1})    {ExamQuestion[i].Body} : {ExamQuestion[i].Answer[Answer[i] - 1].AnswerText}");
                if (Answer[i] == ExamQuestion[i].Answer[rightanswerId - 1].AnswerId) studentMark += ExamQuestion[i].Mark;
                totalMark += ExamQuestion[i].Mark;
            }
            Console.WriteLine($"Your Exam Grade is {studentMark} from {totalMark}");
        }

    }
}
