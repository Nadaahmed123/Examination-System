using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public abstract class Question
    {
        public abstract string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answers[] Answer { get; set; }
        public Question(int _Mark, Answers[] _Answer)
        {
            Mark = _Mark;
            Answer = _Answer;
        }
        public abstract Question CreateQuestion();
    }
}
