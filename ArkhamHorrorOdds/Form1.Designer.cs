
namespace ArkhamHorrorOdds
{
    partial class MainForm
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
            this.CbCampaign = new System.Windows.Forms.ComboBox();
            this.CbScenario = new System.Windows.Forms.ComboBox();
            this.CbDifficulty = new System.Windows.Forms.ComboBox();
            this.txtBag = new System.Windows.Forms.RichTextBox();
            this.cbTokens = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.numBase = new System.Windows.Forms.NumericUpDown();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.numBonus = new System.Windows.Forms.NumericUpDown();
            this.lblStar = new System.Windows.Forms.Label();
            this.numStar = new System.Windows.Forms.NumericUpDown();
            this.BtnDefault = new System.Windows.Forms.Button();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.lblExtra1 = new System.Windows.Forms.Label();
            this.numExtra1 = new System.Windows.Forms.NumericUpDown();
            this.lblTest = new System.Windows.Forms.Label();
            this.numTest = new System.Windows.Forms.NumericUpDown();
            this.BtnReset = new System.Windows.Forms.Button();
            this.lblExtra2 = new System.Windows.Forms.Label();
            this.numExtra2 = new System.Windows.Forms.NumericUpDown();
            this.lblExtra3 = new System.Windows.Forms.Label();
            this.numExtra3 = new System.Windows.Forms.NumericUpDown();
            this.lblPoison = new System.Windows.Forms.Label();
            this.cbPoison = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExtra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExtra2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExtra3)).BeginInit();
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
            // CbCampaign
            // 
            this.CbCampaign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCampaign.FormattingEnabled = true;
            this.CbCampaign.Items.AddRange(new object[] {
            "Night of the Zealot",
            "The Dunwich Legacy",
            "The Path to Carcosa",
            "The Forgotten Age",
            "The Circle Undone",
            "The Dream-Eaters",
            "The Innsmouth Conspiracy"});
            this.CbCampaign.Location = new System.Drawing.Point(25, 75);
            this.CbCampaign.Name = "CbCampaign";
            this.CbCampaign.Size = new System.Drawing.Size(210, 24);
            this.CbCampaign.TabIndex = 1;
            this.CbCampaign.TabStop = false;
            this.CbCampaign.SelectedIndexChanged += new System.EventHandler(this.CbCampaign_SelectedIndexChanged);
            // 
            // CbScenario
            // 
            this.CbScenario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbScenario.FormattingEnabled = true;
            this.CbScenario.Items.AddRange(new object[] {
            "The Gathering",
            "The Midnight Masks",
            "The Devourer Below"});
            this.CbScenario.Location = new System.Drawing.Point(25, 120);
            this.CbScenario.Name = "CbScenario";
            this.CbScenario.Size = new System.Drawing.Size(276, 24);
            this.CbScenario.TabIndex = 2;
            this.CbScenario.TabStop = false;
            this.CbScenario.SelectedIndexChanged += new System.EventHandler(this.CbScenario_SelectedIndexChanged);
            // 
            // CbDifficulty
            // 
            this.CbDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDifficulty.FormattingEnabled = true;
            this.CbDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Standard",
            "Hard",
            "Expert"});
            this.CbDifficulty.Location = new System.Drawing.Point(25, 165);
            this.CbDifficulty.Name = "CbDifficulty";
            this.CbDifficulty.Size = new System.Drawing.Size(100, 24);
            this.CbDifficulty.TabIndex = 3;
            this.CbDifficulty.TabStop = false;
            this.CbDifficulty.SelectedIndexChanged += new System.EventHandler(this.CbDifficulty_SelectedIndexChanged);
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
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(587, 413);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 24);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(668, 413);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 24);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
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
            // BtnDefault
            // 
            this.BtnDefault.Location = new System.Drawing.Point(448, 59);
            this.BtnDefault.Name = "BtnDefault";
            this.BtnDefault.Size = new System.Drawing.Size(183, 30);
            this.BtnDefault.TabIndex = 14;
            this.BtnDefault.Text = "Set Campaign Default";
            this.BtnDefault.UseVisualStyleBackColor = true;
            this.BtnDefault.Click += new System.EventHandler(this.BtnDefault_Click);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalculate.Location = new System.Drawing.Point(884, 285);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(211, 41);
            this.BtnCalculate.TabIndex = 15;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
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
            this.numExtra1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
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
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(637, 59);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(106, 30);
            this.BtnReset.TabIndex = 21;
            this.BtnReset.Text = "Clear";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // lblExtra2
            // 
            this.lblExtra2.AutoSize = true;
            this.lblExtra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtra2.Location = new System.Drawing.Point(870, 382);
            this.lblExtra2.Name = "lblExtra2";
            this.lblExtra2.Size = new System.Drawing.Size(0, 24);
            this.lblExtra2.TabIndex = 23;
            this.lblExtra2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numExtra2
            // 
            this.numExtra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numExtra2.Location = new System.Drawing.Point(1013, 380);
            this.numExtra2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numExtra2.Name = "numExtra2";
            this.numExtra2.Size = new System.Drawing.Size(82, 28);
            this.numExtra2.TabIndex = 22;
            this.numExtra2.Visible = false;
            // 
            // lblExtra3
            // 
            this.lblExtra3.AutoSize = true;
            this.lblExtra3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtra3.Location = new System.Drawing.Point(870, 416);
            this.lblExtra3.Name = "lblExtra3";
            this.lblExtra3.Size = new System.Drawing.Size(0, 24);
            this.lblExtra3.TabIndex = 25;
            this.lblExtra3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numExtra3
            // 
            this.numExtra3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numExtra3.Location = new System.Drawing.Point(1013, 414);
            this.numExtra3.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numExtra3.Name = "numExtra3";
            this.numExtra3.Size = new System.Drawing.Size(82, 28);
            this.numExtra3.TabIndex = 24;
            this.numExtra3.Visible = false;
            // 
            // lblPoison
            // 
            this.lblPoison.AutoSize = true;
            this.lblPoison.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoison.Location = new System.Drawing.Point(870, 450);
            this.lblPoison.Name = "lblPoison";
            this.lblPoison.Size = new System.Drawing.Size(0, 24);
            this.lblPoison.TabIndex = 27;
            this.lblPoison.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblPoison.Visible = false;
            // 
            // cbPoison
            // 
            this.cbPoison.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPoison.FormattingEnabled = true;
            this.cbPoison.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cbPoison.Location = new System.Drawing.Point(995, 452);
            this.cbPoison.Name = "cbPoison";
            this.cbPoison.Size = new System.Drawing.Size(100, 24);
            this.cbPoison.TabIndex = 28;
            this.cbPoison.TabStop = false;
            this.cbPoison.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.cbPoison);
            this.Controls.Add(this.lblPoison);
            this.Controls.Add(this.lblExtra3);
            this.Controls.Add(this.numExtra3);
            this.Controls.Add(this.lblExtra2);
            this.Controls.Add(this.numExtra2);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.numTest);
            this.Controls.Add(this.lblExtra1);
            this.Controls.Add(this.numExtra1);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.BtnDefault);
            this.Controls.Add(this.lblStar);
            this.Controls.Add(this.numStar);
            this.Controls.Add(this.lblBonus);
            this.Controls.Add(this.numBonus);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.numBase);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.cbTokens);
            this.Controls.Add(this.txtBag);
            this.Controls.Add(this.CbDifficulty);
            this.Controls.Add(this.CbScenario);
            this.Controls.Add(this.CbCampaign);
            this.Controls.Add(this.Header);
            this.MaximumSize = new System.Drawing.Size(1200, 750);
            this.MinimumSize = new System.Drawing.Size(1200, 750);
            this.Name = "MainForm";
            this.Text = "Skill Test Odds";
            ((System.ComponentModel.ISupportInitialize)(this.numBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExtra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExtra2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExtra3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.ComboBox CbCampaign;
        private System.Windows.Forms.ComboBox CbScenario;
        private System.Windows.Forms.ComboBox CbDifficulty;
        private System.Windows.Forms.RichTextBox txtBag;
        private System.Windows.Forms.ComboBox cbTokens;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.NumericUpDown numBase;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.NumericUpDown numBonus;
        private System.Windows.Forms.Label lblStar;
        private System.Windows.Forms.NumericUpDown numStar;
        private System.Windows.Forms.Button BtnDefault;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Label lblExtra1;
        private System.Windows.Forms.NumericUpDown numExtra1;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.NumericUpDown numTest;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Label lblExtra2;
        private System.Windows.Forms.NumericUpDown numExtra2;
        private System.Windows.Forms.Label lblExtra3;
        private System.Windows.Forms.NumericUpDown numExtra3;
        private System.Windows.Forms.Label lblPoison;
        private System.Windows.Forms.ComboBox cbPoison;
    }
}

