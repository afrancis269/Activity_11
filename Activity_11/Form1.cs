using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_11
{
    class Dice
    {
        private int sidesNum;
        private Random random;

        public Dice(int val)
        {
            sidesNum = val;
        }

        public int RollingDice()
        {
            random = new Random();
            return random.Next(1, 6);
        }
    }
    public partial class Form1 : Form
    {
        Dice firstDice = new Dice(6);
        Dice secondDice = new Dice(6);
        int count = 0;
        public Form1()
        {
            InitializeComponent();


        }

        private void RollBtn_Click(object sender, EventArgs e)
        {
            count += 1;
            int firstDiceRes = firstDice.RollingDice();
            int secondDiceRes = secondDice.RollingDice();
            Res1Txb.Text = firstDiceRes.ToString();
            Res2Txb.Text = secondDiceRes.ToString();
            if (firstDiceRes == secondDiceRes && firstDiceRes == 1)
            {
                MessageBox.Show("It tooks " + count.ToString() + " rolls to get a snake eyes!");
                count = 0;
            }

        }
    }
}
