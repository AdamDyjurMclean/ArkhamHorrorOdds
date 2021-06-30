
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
            this.txtBag = new System.Windows.Forms.RichTextBox();
            this.cbTokens = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
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
            // txtBag
            // 
            this.txtBag.BackColor = System.Drawing.SystemColors.Window;
            this.txtBag.Location = new System.Drawing.Point(448, 95);
            this.txtBag.Name = "txtBag";
            this.txtBag.ReadOnly = true;
            this.txtBag.Size = new System.Drawing.Size(295, 280);
            this.txtBag.TabIndex = 4;
            this.txtBag.Text = "";
            // 
            // cbTokens
            // 
            this.cbTokens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTokens.FormattingEnabled = true;
            this.cbTokens.Items.AddRange(new object[] {
            "+1",
            "0",
            "-1",
            "-2",
            "-3",
            "-4",
            "-5",
            "-6",
            "-7",
            "-8",
            "Skull",
            "Cultest",
            "Tablet",
            "Elder Thing",
            "Auto Fail",
            "Elder Sign"});
            this.cbTokens.Location = new System.Drawing.Point(448, 381);
            this.cbTokens.Name = "cbTokens";
            this.cbTokens.Size = new System.Drawing.Size(120, 24);
            this.cbTokens.TabIndex = 5;
            this.cbTokens.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(587, 382);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 24);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(668, 382);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 24);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbTokens);
            this.Controls.Add(this.txtBag);
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
        private System.Windows.Forms.RichTextBox txtBag;
        private System.Windows.Forms.ComboBox cbTokens;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
    }
}

