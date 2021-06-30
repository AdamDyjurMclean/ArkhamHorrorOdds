using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkhamHorrorOdds
{
    public partial class Form1 : Form
    {
        Dictionary<int, int> bag = new Dictionary<int, int>();
        public Form1()
        {
            InitializeComponent();
            cbCampaign.SelectedIndex = 0;
            cbScenario.SelectedIndex = 0;
            cbDifficulty.SelectedIndex = 1;
            cbTokens.SelectedIndex = 0;
            startBag();
            setText();
        }

        private void cbCampaign_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbScenario.Items.Clear();
            string[] scenarios = ScenarioNames.getList(cbCampaign.SelectedIndex);
            foreach (string s in scenarios)
            {
                cbScenario.Items.Add(s);
            }
            if (cbScenario.Items.Count > 0)
                cbScenario.SelectedIndex = 0;
        }
        private void btnDefault_Click(object sender, EventArgs e)
        {
            int[] start = DefaultBags.bagStart(cbCampaign.SelectedIndex, cbDifficulty.SelectedIndex);
            bag[1] = start[0];
            bag[0] = start[1];
            bag[-1] = start[2];
            bag[-2] = start[3];
            bag[-3] = start[4];
            bag[-4] = start[5];
            bag[-5] = start[6];
            bag[-6] = start[7];
            bag[-7] = start[8];
            bag[-8] = start[9];
            bag[11] = start[10];
            bag[12] = start[11];
            bag[13] = start[12];
            bag[14] = start[13];
            bag[15] = start[14];
            bag[16] = start[15];
            setText();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int token = TokenNumber.convert(cbTokens.SelectedIndex);
            if ((cbTokens.SelectedIndex == 7 || cbTokens.SelectedIndex == 8 || cbTokens.SelectedIndex == 9 ||
                cbTokens.SelectedIndex == 14 || cbTokens.SelectedIndex == 15) && bag[token] < 1)
                bag[token]++;
            if ((cbTokens.SelectedIndex == 5 || cbTokens.SelectedIndex == 6) && bag[token] < 2)
                bag[token]++;
            if ((cbTokens.SelectedIndex == 0 || cbTokens.SelectedIndex == 4) && bag[token] < 3)
                bag[token]++;
            if ((cbTokens.SelectedIndex == 1 || cbTokens.SelectedIndex == 3 || cbTokens.SelectedIndex == 10 ||
                cbTokens.SelectedIndex == 11 || cbTokens.SelectedIndex == 12 || cbTokens.SelectedIndex == 13) && bag[token] < 4)
                bag[token]++;
            if (cbTokens.SelectedIndex == 2 && bag[token] < 5)
                bag[token]++;
            setText();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int token = TokenNumber.convert(cbTokens.SelectedIndex);
            if (bag[token] > 0)
                bag[token]--;
            setText();
        }

        private void setText()
        {
            txtBag.Text = TextBoxString.textBox(bag);
            setBag();
        }

        private void startBag()
        {
            StreamReader reader = new StreamReader("bag.txt");
            bag.Add(1, Int32.Parse(reader.ReadLine()));
            bag.Add(0, Int32.Parse(reader.ReadLine()));
            bag.Add(-1, Int32.Parse(reader.ReadLine()));
            bag.Add(-2, Int32.Parse(reader.ReadLine()));
            bag.Add(-3, Int32.Parse(reader.ReadLine()));
            bag.Add(-4, Int32.Parse(reader.ReadLine()));
            bag.Add(-5, Int32.Parse(reader.ReadLine()));
            bag.Add(-6, Int32.Parse(reader.ReadLine()));
            bag.Add(-7, Int32.Parse(reader.ReadLine()));
            bag.Add(-8, Int32.Parse(reader.ReadLine()));
            bag.Add(11, Int32.Parse(reader.ReadLine())); //Skull
            bag.Add(12, Int32.Parse(reader.ReadLine())); //Cultest
            bag.Add(13, Int32.Parse(reader.ReadLine())); //Tablet
            bag.Add(14, Int32.Parse(reader.ReadLine())); //Elder Thing
            bag.Add(15, Int32.Parse(reader.ReadLine())); //Auto Fail
            bag.Add(16, Int32.Parse(reader.ReadLine())); //Elder Sign
            reader.Close();
        }

        private void setBag()
        {
            StreamWriter writer = new StreamWriter("bag.txt", false);
            writer.WriteLine(bag[1]);
            writer.WriteLine(bag[0]);
            writer.WriteLine(bag[-1]);
            writer.WriteLine(bag[-2]);
            writer.WriteLine(bag[-3]);
            writer.WriteLine(bag[-4]);
            writer.WriteLine(bag[-5]);
            writer.WriteLine(bag[-6]);
            writer.WriteLine(bag[-7]);
            writer.WriteLine(bag[-8]);
            writer.WriteLine(bag[11]);
            writer.WriteLine(bag[12]);
            writer.WriteLine(bag[13]);
            writer.WriteLine(bag[14]);
            writer.WriteLine(bag[15]);
            writer.WriteLine(bag[16]);
            writer.Close();
        }
    }
}