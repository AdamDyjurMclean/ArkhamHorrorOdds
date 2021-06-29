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
        public Form1()
        {
            InitializeComponent();
            cbCampaign.SelectedIndex = 0;
            cbScenario.SelectedIndex = 0;
            cbDifficulty.SelectedIndex = 1;
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
    }
}
