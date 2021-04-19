using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormHW
{
    class Question
    {
        public string AQuestion { get; set; }
        public bool Result { get; set; }
        public Question(string question, bool res)
        {
            AQuestion = question;
            Result = res;
        }
    }
}
