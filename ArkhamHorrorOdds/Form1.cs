﻿using System;
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
    public partial class btnClear : Form
    {
        Dictionary<int, int> bag = new Dictionary<int, int>();
        public btnClear()
        {
            InitializeComponent();
            cbCampaign.SelectedIndex = 0;
            cbScenario.SelectedIndex = 0;
            cbDifficulty.SelectedIndex = 1;
            cbTokens.SelectedIndex = 0;
            startBag();
            setText();
            setExtras();
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
        private void cbScenario_SelectedIndexChanged(object sender, EventArgs e)
        {
            setExtras();
        }
        private void cbDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            setExtras();
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
            bag[17] = 0;
            bag[18] = 0;
            setText();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            bag[1] = 0;
            bag[0] = 0;
            bag[-1] = 0;
            bag[-2] = 0;
            bag[-3] = 0;
            bag[-4] = 0;
            bag[-5] = 0;
            bag[-6] = 0;
            bag[-7] = 0;
            bag[-8] = 0;
            bag[11] = 0;
            bag[12] = 0;
            bag[13] = 0;
            bag[14] = 0;
            bag[15] = 0;
            bag[16] = 0;
            bag[17] = 0;
            bag[18] = 0;
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
            if ((cbTokens.SelectedIndex == 16 || cbTokens.SelectedIndex == 17) && bag[token] < 10)
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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (cbCampaign.SelectedIndex == 0)
                lblresult.Text = OddsNotZ.scenarioCheck(bag, cbScenario.SelectedIndex, cbDifficulty.SelectedIndex, Convert.ToInt32(numBase.Value), Convert.ToInt32(numBonus.Value), Convert.ToInt32(numStar.Value), Convert.ToInt32(numTest.Value), Convert.ToInt32(numExtra1.Value));
            else
                lblresult.Text = "Unfinished";
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
            bag.Add(17, Int32.Parse(reader.ReadLine())); //Bless
            bag.Add(18, Int32.Parse(reader.ReadLine())); //Curse
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
            writer.WriteLine(bag[17]);
            writer.WriteLine(bag[18]);
            writer.Close();
        }
        private void setExtras()
        {
            if (VarriableCheck.Check(cbCampaign.SelectedIndex, cbScenario.SelectedIndex, cbDifficulty.SelectedIndex))
            {
                lblExtra1.Text = VarriableCheck.label(cbCampaign.SelectedIndex, cbScenario.SelectedIndex, cbDifficulty.SelectedIndex);
                numExtra1.Visible = true;
            }
            else
            {
                lblExtra1.Text = "";
                numExtra1.Visible = false;
            } 
        }
    }
}