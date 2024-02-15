using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class Answers
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        public Answers(int _AnswerId, string _AnswerText)
        {
            AnswerId = _AnswerId;
            AnswerText = _AnswerText;
        }

    }
}
