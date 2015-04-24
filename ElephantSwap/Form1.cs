using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElephantSwap
{
    public partial class Form1 : Form
    {
        Elephant lucinda;
        Elephant lloyd;

        public Form1()
        {
            InitializeComponent();
            lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant holder;
            holder = lloyd;
            lloyd = lucinda;
            lucinda = holder;
            MessageBox.Show("Objects swapped");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lloyd.TellMe("Hi", lucinda);

            //lloyd = lucinda;
            //lloyd.EarSize = 4321;
            //lloyd.WhoAmI();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lloyd.SpeakTo(lucinda, "Hello");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Elephant[] elephants = new Elephant[7];
            elephants[0] = new Elephant() { Name = "Lloyd", EarSize = 40 };
            elephants[1] = new Elephant() { Name = "Lucinda", EarSize = 33 };
            elephants[2] = new Elephant() { Name = "Larry", EarSize = 42 };
            elephants[3] = new Elephant() { Name = "Lucille", EarSize = 32 };
            elephants[4] = new Elephant() { Name = "Lars", EarSize = 44 };
            elephants[5] = new Elephant() { Name = "Linda", EarSize = 37 };
            elephants[6] = new Elephant() { Name = "Humphrey", EarSize = 45 };
            Elephant biggestEars = elephants[0];
            for (int i = 1; i < elephants.Length; i++)
            {
                if (elephants[i].EarSize > biggestEars.EarSize)
                {
                    biggestEars = elephants[i];
                }
            }
            MessageBox.Show(biggestEars.EarSize.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string result = "";
            int[] index = new int[4];
            index[0] = 1;
            index[1] = 3;
            index[2] = 0;
            index[3] = 2;
            string[] islands = new string[4];
            islands[0] = "Bermuda";
            islands[1] = "Fiji";
            islands[2] = "Azores";
            islands[3] = "Cozumel";
            int y = 0;
            int refNum;
            while (y < 4) {
                refNum = index[y];
                result += "\nisland = ";
                result += islands[refNum];
                y = y + 1;
            }
            MessageBox.Show(result);
        }
    }
}
