using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Forms1HW
{
    class QuizApp
    {
        public string MessageBoxTitle { get; set; } = "Question";
        public List<Question> Questions { get; set; } = new List<Question>();
        private int correct  = 0;
        private int record = 0;
        public int Record { 
            get => record;
            private set
            {
                if (value > record)
                {
                    this.record = value;
                }
            }
        }
        public void AddQuestion(string question, bool answer)
        {
            Questions.Add(new Question(question, answer));
        }
        public void Start()
        {
            if (Questions.Count == 0)
            {
                MessageBox.Show("Haven`t questions", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (var item in Questions)
            {
                DialogResult res = MessageBox.Show(item.AQuestion, MessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes && item.Result || res == DialogResult.No && !item.Result)
                {
                    ++correct;
                    MessageBox.Show("Correct answer", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Incorrect answer", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            this.Record = correct;
            

        }
    }
}
