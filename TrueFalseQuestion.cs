using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class TrueFalseQuestion : Question
    {
    public override string Header
    {
        set
        {
        }
        get
        {
            return "True | False Question";
        }
    }

    public TrueFalseQuestion(int _Mark, Answers rightAnswer) : base(_Mark, new Answers[3] { new Answers(1, "True"), new Answers(2, "False"), rightAnswer })
    {

    }

    public override string ToString()
    {
        return $"{Header}    Marks({Mark})\n{Body}\n 1. True   2. False\n=======================================================";
    }

    public override Question CreateQuestion()
    {
        int mark, rightAnswer;
        string body;
        Console.WriteLine(Header);
        Console.WriteLine("Please enter the Body Of Question :");
        body = Console.ReadLine();
        Console.WriteLine("Please  enter the Marks Of Question :");
        int.TryParse(Console.ReadLine(), out mark);
        Console.WriteLine("Please enter the Right Answer Of Question(1 for True 2 for False):");
        int.TryParse(Console.ReadLine(), out rightAnswer);
        this.Body = body;
        this.Mark = mark;
        this.Answer = new Answers[3]
        {
                new Answers(1, "True"),
                new Answers(2, "False"),
                new Answers(rightAnswer,
                rightAnswer == 1 ? "True" : "False")
        };
        return this;

    }

}
}
