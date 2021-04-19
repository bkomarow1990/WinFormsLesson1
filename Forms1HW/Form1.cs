using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms1HW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            QuizApp app = new QuizApp();
            app.AddQuestion("Поставите 12?", true);
            app.AddQuestion("2+2*2=8", false);
            app.AddQuestion("C# is cool?", true);
            app.Start();
            this.RecordTextLabel.Text = "Record: "+app.Record.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RecordTextLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
