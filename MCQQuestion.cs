using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class MCQQuestion :Question
    {
        public override string Header
        {
            set
            {
            }
            get
            {
                return "Choose One Answer Question";
            }
        }

        public MCQQuestion(int _Grade, Answers[] _Answers) : base(_Grade, _Answers)
        {

        }

        public override string ToString()
        {
            return $"{Header}\n    Marks({Mark})\n{Body}\n 1. {Answer[0].AnswerText}     2. {Answer[1].AnswerText}           3. {Answer[2].AnswerText}\n ==========================================";
        }

        public override Question CreateQuestion()
        {
            int mark, rightAnswer;
            string body;
            Console.WriteLine(Header);
            Console.WriteLine("Please Enter the Body Of Question:");
            body = Console.ReadLine();

            Console.WriteLine("Please Enter the Marks Of Question:");
            int.TryParse(Console.ReadLine(), out mark);
            Answers[] MCQ = new Answers[4];
            Console.WriteLine("the Choices Of Question:");
            for (int i = 0; i < 3; i++)
            {
                string option;
                Console.Write($"Please Enter the Choice Number {i + 1}:");
                option = Console.ReadLine();
                MCQ[i] = new Answers(i + 1, option);
            }
            Console.WriteLine("Please Specify the Right Answer Of Question:");
            int.TryParse(Console.ReadLine(), out rightAnswer);
            MCQ[3] = MCQ[rightAnswer - 1];
            this.Body = body;
            this.Mark = mark;
            this.Answer = MCQ;
            return this;
        }
    
}
}
