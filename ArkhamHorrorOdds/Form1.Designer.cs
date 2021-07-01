
namespace ArkhamHorrorOdds
{
    partial class btnClear
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
            this.numBase = new System.Windows.Forms.NumericUpDown();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.numBonus = new System.Windows.Forms.NumericUpDown();
            this.lblStar = new System.Windows.Forms.Label();
            this.numStar = new System.Windows.Forms.NumericUpDown();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.lblExtra1 = new System.Windows.Forms.Label();
            this.numExtra1 = new System.Windows.Forms.NumericUpDown();
            this.lblTest = new System.Windows.Forms.Label();
            this.numTest = new System.Windows.Forms.NumericUpDown();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExtra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTest)).BeginInit();
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
            this.cbScenario.SelectedIndexChanged += new System.EventHandler(this.cbScenario_SelectedIndexChanged);
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
            this.cbDifficulty.SelectedIndexChanged += new System.EventHandler(this.cbDifficulty_SelectedIndexChanged);
            // 
            // txtBag
            // 
            this.txtBag.BackColor = System.Drawing.SystemColors.Window;
            this.txtBag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBag.Location = new System.Drawing.Point(448, 95);
            this.txtBag.Name = "txtBag";
            this.txtBag.ReadOnly = true;
            this.txtBag.Size = new System.Drawing.Size(295, 311);
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
            "Elder Sign",
            "Bless",
            "Curse"});
            this.cbTokens.Location = new System.Drawing.Point(448, 412);
            this.cbTokens.Name = "cbTokens";
            this.cbTokens.Size = new System.Drawing.Size(120, 24);
            this.cbTokens.TabIndex = 5;
            this.cbTokens.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(587, 413);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 24);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(668, 413);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 24);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // numBase
            // 
            this.numBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBase.Location = new System.Drawing.Point(1013, 95);
            this.numBase.Name = "numBase";
            this.numBase.Size = new System.Drawing.Size(82, 28);
            this.numBase.TabIndex = 8;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.Location = new System.Drawing.Point(908, 97);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(90, 24);
            this.lblBase.TabIndex = 9;
            this.lblBase.Text = "Base Skill";
            this.lblBase.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonus.Location = new System.Drawing.Point(880, 146);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(118, 24);
            this.lblBonus.TabIndex = 11;
            this.lblBonus.Text = "Bonus Value";
            this.lblBonus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numBonus
            // 
            this.numBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBonus.Location = new System.Drawing.Point(1013, 144);
            this.numBonus.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numBonus.Name = "numBonus";
            this.numBonus.Size = new System.Drawing.Size(82, 28);
            this.numBonus.TabIndex = 10;
            // 
            // lblStar
            // 
            this.lblStar.AutoSize = true;
            this.lblStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStar.Location = new System.Drawing.Point(840, 196);
            this.lblStar.Name = "lblStar";
            this.lblStar.Size = new System.Drawing.Size(157, 24);
            this.lblStar.TabIndex = 13;
            this.lblStar.Text = "Elder Sign Bonus";
            this.lblStar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numStar
            // 
            this.numStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numStar.Location = new System.Drawing.Point(1013, 194);
            this.numStar.Name = "numStar";
            this.numStar.Size = new System.Drawing.Size(82, 28);
            this.numStar.TabIndex = 12;
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(448, 59);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(183, 30);
            this.btnDefault.TabIndex = 14;
            this.btnDefault.Text = "Set Campaign Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(884, 285);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(211, 41);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblresult
            // 
            this.lblresult.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(0, 468);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(1182, 185);
            this.lblresult.TabIndex = 16;
            this.lblresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExtra1
            // 
            this.lblExtra1.AutoSize = true;
            this.lblExtra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtra1.Location = new System.Drawing.Point(870, 348);
            this.lblExtra1.Name = "lblExtra1";
            this.lblExtra1.Size = new System.Drawing.Size(0, 24);
            this.lblExtra1.TabIndex = 18;
            this.lblExtra1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numExtra1
            // 
            this.numExtra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numExtra1.Location = new System.Drawing.Point(1013, 346);
            this.numExtra1.Name = "numExtra1";
            this.numExtra1.Size = new System.Drawing.Size(82, 28);
            this.numExtra1.TabIndex = 17;
            this.numExtra1.Visible = false;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.Location = new System.Drawing.Point(950, 242);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(46, 24);
            this.lblTest.TabIndex = 20;
            this.lblTest.Text = "Test";
            this.lblTest.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numTest
            // 
            this.numTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTest.Location = new System.Drawing.Point(1013, 240);
            this.numTest.Name = "numTest";
            this.numTest.Size = new System.Drawing.Size(82, 28);
            this.numTest.TabIndex = 19;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(637, 59);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 30);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "Clear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.numTest);
            this.Controls.Add(this.lblExtra1);
            this.Controls.Add(this.numExtra1);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.lblStar);
            this.Controls.Add(this.numStar);
            this.Controls.Add(this.lblBonus);
            this.Controls.Add(this.numBonus);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.numBase);
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
            this.Name = "btnClear";
            this.Text = "Skill Test Odds";
            ((System.ComponentModel.ISupportInitialize)(this.numBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExtra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.NumericUpDown numBase;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.NumericUpDown numBonus;
        private System.Windows.Forms.Label lblStar;
        private System.Windows.Forms.NumericUpDown numStar;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Label lblExtra1;
        private System.Windows.Forms.NumericUpDown numExtra1;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.NumericUpDown numTest;
        private System.Windows.Forms.Button btnReset;
    }
}

