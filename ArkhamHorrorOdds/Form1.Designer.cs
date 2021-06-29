
namespace ArkhamHorrorOdds
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Header = new System.Windows.Forms.Label();
            this.cbCampaign = new System.Windows.Forms.ComboBox();
            this.cbScenario = new System.Windows.Forms.ComboBox();
            this.cbDifficulty = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1182, 35);
            this.Header.TabIndex = 0;
            this.Header.Text = "Arkham Horror Odds Calculator";
            this.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCampaign
            // 
            this.cbCampaign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCampaign.FormattingEnabled = true;
            this.cbCampaign.Items.AddRange(new object[] {
            "Night of the Zealot",
            "The Dunwich Legacy"});
            this.cbCampaign.Location = new System.Drawing.Point(25, 75);
            this.cbCampaign.Name = "cbCampaign";
            this.cbCampaign.Size = new System.Drawing.Size(176, 24);
            this.cbCampaign.TabIndex = 1;
            this.cbCampaign.TabStop = false;
            this.cbCampaign.SelectedIndexChanged += new System.EventHandler(this.cbCampaign_SelectedIndexChanged);
            // 
            // cbScenario
            // 
            this.cbScenario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScenario.FormattingEnabled = true;
            this.cbScenario.Items.AddRange(new object[] {
            "The Gathering",
            "The Midnight Masks",
            "The Devourer Below"});
            this.cbScenario.Location = new System.Drawing.Point(25, 120);
            this.cbScenario.Name = "cbScenario";
            this.cbScenario.Size = new System.Drawing.Size(210, 24);
            this.cbScenario.TabIndex = 2;
            this.cbScenario.TabStop = false;
            // 
            // cbDifficulty
            // 
            this.cbDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDifficulty.FormattingEnabled = true;
            this.cbDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Standard",
            "Hard",
            "Expert"});
            this.cbDifficulty.Location = new System.Drawing.Point(25, 165);
            this.cbDifficulty.Name = "cbDifficulty";
            this.cbDifficulty.Size = new System.Drawing.Size(100, 24);
            this.cbDifficulty.TabIndex = 3;
            this.cbDifficulty.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.cbDifficulty);
            this.Controls.Add(this.cbScenario);
            this.Controls.Add(this.cbCampaign);
            this.Controls.Add(this.Header);
            this.MaximumSize = new System.Drawing.Size(1200, 750);
            this.MinimumSize = new System.Drawing.Size(1200, 750);
            this.Name = "Form1";
            this.Text = "Skill Test Odds";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.ComboBox cbCampaign;
        private System.Windows.Forms.ComboBox cbScenario;
        private System.Windows.Forms.ComboBox cbDifficulty;
    }
}

