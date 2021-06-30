using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            bag.Add(1, 0);
            bag.Add(0, 0);
            bag.Add(-1, 0);
            bag.Add(-2, 0);
            bag.Add(-3, 0);
            bag.Add(-4, 0);
            bag.Add(-5, 0);
            bag.Add(-6, 0);
            bag.Add(-8, 0);
            bag.Add(11, 0); //Skull
            bag.Add(12, 0); //Cultest
            bag.Add(13, 0); //Tablet
            bag.Add(14, 0); //Elder Thing
            bag.Add(15, 0); //Auto Fail
            bag.Add(16, 0); //Elder Sign
        }

        private void cbCampaign_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbScenario.Items.Clear();
            string[] scenarios = ScenarioNames.getList(cbCampaign.SelectedIndex);
            foreach(string s in scenarios)
            {
                cbScenario.Items.Add(s);
            }
            if(cbScenario.Items.Count > 0)
                cbScenario.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int token = TokenNumber.convert(cbTokens.SelectedIndex);
            bag[token]++;
            setText();
        }

        private void setText()
        {
            txtBag.Text = TextBoxString.textBox(bag);
        }
    }
}