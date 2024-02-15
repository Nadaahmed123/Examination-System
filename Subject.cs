using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }

        public Subject(int _SubjectId, string _SubjectName)
        {
            SubjectId = _SubjectId;
            SubjectName = _SubjectName;
        }

        public void CreateExam()
        {
            Console.Write("Please Enter Type Of Exam You Want To Create(1 for Practical and 2 for Final):");
            int ChooseExam, TimeExam, NumberOfQuestions;
            int.TryParse(Console.ReadLine(), out ChooseExam);
            Console.Write("Please Enter Time Of Exam in Minutes: ");
            int.TryParse(Console.ReadLine(), out TimeExam);
            Console.Write("Please Enter The Number of the Questions You Want to Create: ");
            int.TryParse(Console.ReadLine(), out NumberOfQuestions);
            Console.Clear();
            Question QuestionType;

            if (ChooseExam == 1)
            {
                Exam = new PracticalExam(TimeExam, NumberOfQuestions);

                for (int i = 0; i < NumberOfQuestions; i++)
                {
                    QuestionType = new MCQQuestion(0, new Answers[4]);
                    Exam.ExamQuestion.Add((MCQQuestion)QuestionType.CreateQuestion());
                    Console.Clear();
                }
            }
            else if (ChooseExam == 2)
            {
                Exam = new FinalExam(TimeExam, NumberOfQuestions);

                for (int i = 0; i < NumberOfQuestions; i++)
                {
                    int QuesionType;
                    Console.Write($"Please Enter the Type Of Question{i + 1}(1 for True or False || 2 for MCQ ) :");
                    
                    int.TryParse(Console.ReadLine(), out QuesionType);
                    Console.Clear();

                    if (QuesionType == 1)
                    {
                        QuestionType = new TrueFalseQuestion(0, new Answers(0, ""));
                        Exam.ExamQuestion.Add((TrueFalseQuestion)QuestionType.CreateQuestion());
                    }
                    else if (QuesionType == 2)
                    {
                        QuestionType = new MCQQuestion(0, new Answers[4]);
                        Exam.ExamQuestion.Add((MCQQuestion)QuestionType.CreateQuestion());
                    }
                    else
                        Console.WriteLine("Not Valid");
                    Console.Clear();
                }
               

            }
            else
                Console.WriteLine("Not Valid");
        }
    }
}
