﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class PracticalExam : Exam
    {
        public PracticalExam(int _Time, int _NumberQuestion) : base(_Time, _NumberQuestion)
        {

        }

        public override void ShowExam()
        {
            ShowQuestionsAndStudentAnswer();
            Console.Clear();
            Console.WriteLine("Right Answers");
            for (int i = 0; i < ExamQuestion.Count; i++)
            {
                Console.WriteLine($"Q{i + 1}) {ExamQuestion[i].Body} : {ExamQuestion[i].Answer[3].AnswerText}");
            }
        }
    }
}
