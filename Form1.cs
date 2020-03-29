using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sec = 0;
        int min = 0;
        int score = 0;
        public static int highestScore = 0;
        int userans = 0;
        int corans = 0;
        string mode = "easy";
        public Tuple<int, char, int, int> MakeEasyTask()
        {
            int correctans = 0;

            //рандомайзер знаков
            Random r = new Random();
            char[] op = { '+', '-'};
            char oprand = op[r.Next(op.Length)];

            //рандомайзер чисел
            Random rnd = new Random();
            int value1 = rnd.Next(1, 10);
            int value2 = rnd.Next(1, 10);

            if (value1 < value2)
            {
                int tmp = value1;
                value1 = value2;
                value2 = tmp;
            }


            switch (oprand)
            {
                case '+':
                    correctans = value1 + value2;
                    break;
                case '-':
                    correctans = value1 - value2;
                    break;
            }
            
            var result = new Tuple<int, char, int, int>(value1, oprand, value2, correctans);
            return result;
        }
        public Tuple<int, char, int, int> MakeHardTask()
        {
            int correctans = 0;

            //рандомайзер знаков
            Random r = new Random();
            char[] op = { '+', '-', '*', '/' };
            char oprand = op[r.Next(op.Length)];

            //рандомайзер чисел
            Random rnd = new Random();
            int value1 = rnd.Next(1, 10);
            int value2 = rnd.Next(1, 10);

            if (value1 < value2)
            {
                int tmp = value1;
                value1 = value2;
                value2 = tmp;
            }

            char[] op2 = { '+', '-', '*' };
            if (value1 % value2 != 0)
            {
                oprand = op2[r.Next(op2.Length)];
            }

            switch (oprand)
            {
                case '/':
                    correctans = value1 / value2;
                    break;
                case '+':
                    correctans = value1 + value2;
                    break;
                case '-':
                    correctans = value1 - value2;
                    break;
                case '*':
                    correctans = value1 * value2;
                    break;
            }

            var result = new Tuple<int, char, int, int>(value1, oprand, value2, correctans);
            return result;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "Highest score: " + highestScore;
        }

        private void tasklabel_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void easybutton_Click(object sender, EventArgs e)
        {
            label1.Text = "EASY MODE";
            easybutton.Hide();
            hardbutton.Hide();
            mode = "easy";

            min = 1;
            label3.Text = "Score: " + score.ToString();
            label2.Text = "Time left: 01:00";

            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();

            var result = MakeEasyTask();
            newtasklabel.Text = result.Item1.ToString();
            newtasklabel.Text = "Task: " + result.Item1.ToString() + " " +
                result.Item2.ToString() + " " + result.Item3.ToString();
            corans = result.Item4;

        }

        private void hardbutton_Click(object sender, EventArgs e)
        {
            label1.Text = "HARD MODE";
            easybutton.Hide();
            hardbutton.Hide();
            mode = "hard";
            min = 2;


            label3.Text = "Score: " + score.ToString();
            label2.Text = "Time left: 02:00";

            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();

            var result = MakeHardTask();
            newtasklabel.Text = result.Item1.ToString();
            newtasklabel.Text = "Task: " + result.Item1.ToString() + " " +
                result.Item2.ToString() + " " + result.Item3.ToString();
            corans = result.Item4;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            sec--;
            if (sec == -1)
            {
                min--;
                sec = 59;
            }
            if (sec < 10)
            {
                label2.Text = "Time left: " + min + ":0" + sec;
            }
            else label2.Text = "Time left: " + min + ":" + sec;
            if (sec == 0 && min == 0)
            {
                label2.Text =  "TIME'S UP!!!";
                label1.Text = "Your score is: " + score;
                if (score > highestScore)
                {
                    highestScore = score;
                }
                timer1.Stop();
                easybutton.Show();
                hardbutton.Show();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkbutton_Click(object sender, EventArgs e)
        {
            string val = textBox1.Text;
            bool check = int.TryParse(val, out userans);
            if (val == "" || check == false)
            {
                label5.Text = "IT IS NOT A NUMBER!!!";
            }
            else
            {
                userans = Convert.ToInt32(textBox1.Text);
                if (corans == userans)
                {
                    score++;
                    label3.Text = "Score: " + score;
                    label5.Text = "Correct answer: ";
                }
                else label5.Text = "Correct answer: " + corans.ToString();
                if (mode == "easy")
                {
                    var result = MakeEasyTask();
                    newtasklabel.Text = result.Item1.ToString();
                    newtasklabel.Text = "Task: " + result.Item1.ToString() + " " +
                        result.Item2.ToString() + " " + result.Item3.ToString();
                    corans = result.Item4;
                    textBox1.Text = "";
                }
                else
                {
                    var result = MakeHardTask();
                    newtasklabel.Text = result.Item1.ToString();
                    newtasklabel.Text = "Task: " + result.Item1.ToString() + " " +
                        result.Item2.ToString() + " " + result.Item3.ToString();
                    corans = result.Item4;
                    textBox1.Text = "";
                }
            }
            
            


        }
    }
}
