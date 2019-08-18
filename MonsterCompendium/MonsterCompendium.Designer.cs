namespace MonsterCompendium
{
    partial class MonsterCompendium
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
            this.DGVMonsterList = new System.Windows.Forms.DataGridView();
            this.CLBSize = new System.Windows.Forms.CheckedListBox();
            this.LBLSize = new System.Windows.Forms.Label();
            this.LBLType = new System.Windows.Forms.Label();
            this.LBLAlignment = new System.Windows.Forms.Label();
            this.LBLChallenge = new System.Windows.Forms.Label();
            this.CLBType = new System.Windows.Forms.CheckedListBox();
            this.CLBAlignment = new System.Windows.Forms.CheckedListBox();
            this.CLBChallenge = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMonsterList)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVMonsterList
            // 
            this.DGVMonsterList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVMonsterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMonsterList.Location = new System.Drawing.Point(9, 97);
            this.DGVMonsterList.Margin = new System.Windows.Forms.Padding(2);
            this.DGVMonsterList.Name = "DGVMonsterList";
            this.DGVMonsterList.ReadOnly = true;
            this.DGVMonsterList.Size = new System.Drawing.Size(756, 349);
            this.DGVMonsterList.TabIndex = 0;
            this.DGVMonsterList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMonsterList_CellDoubleClick);
            this.DGVMonsterList.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVMonsterList_ColumnHeaderMouseClick);
            // 
            // CLBSize
            // 
            this.CLBSize.FormattingEnabled = true;
            this.CLBSize.Items.AddRange(new object[] {
            "Tiny",
            "Small",
            "Medium",
            "Large",
            "Huge",
            "Gargantuan"});
            this.CLBSize.Location = new System.Drawing.Point(9, 27);
            this.CLBSize.Name = "CLBSize";
            this.CLBSize.Size = new System.Drawing.Size(101, 64);
            this.CLBSize.TabIndex = 1;
            this.CLBSize.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBSize_ItemCheck);
            // 
            // LBLSize
            // 
            this.LBLSize.AutoSize = true;
            this.LBLSize.Location = new System.Drawing.Point(9, 8);
            this.LBLSize.Name = "LBLSize";
            this.LBLSize.Size = new System.Drawing.Size(30, 13);
            this.LBLSize.TabIndex = 2;
            this.LBLSize.Text = "Size:";
            // 
            // LBLType
            // 
            this.LBLType.AutoSize = true;
            this.LBLType.Location = new System.Drawing.Point(118, 8);
            this.LBLType.Name = "LBLType";
            this.LBLType.Size = new System.Drawing.Size(34, 13);
            this.LBLType.TabIndex = 3;
            this.LBLType.Text = "Type:";
            // 
            // LBLAlignment
            // 
            this.LBLAlignment.AutoSize = true;
            this.LBLAlignment.Location = new System.Drawing.Point(220, 8);
            this.LBLAlignment.Name = "LBLAlignment";
            this.LBLAlignment.Size = new System.Drawing.Size(56, 13);
            this.LBLAlignment.TabIndex = 4;
            this.LBLAlignment.Text = "Alignment:";
            // 
            // LBLChallenge
            // 
            this.LBLChallenge.AutoSize = true;
            this.LBLChallenge.Location = new System.Drawing.Point(327, 8);
            this.LBLChallenge.Name = "LBLChallenge";
            this.LBLChallenge.Size = new System.Drawing.Size(57, 13);
            this.LBLChallenge.TabIndex = 5;
            this.LBLChallenge.Text = "Challenge:";
            // 
            // CLBType
            // 
            this.CLBType.FormattingEnabled = true;
            this.CLBType.Items.AddRange(new object[] {
            "Aberration",
            "Beast",
            "Celestial",
            "Construct",
            "Dragon",
            "Elemental",
            "Fey",
            "Fiend",
            "Giant",
            "Humanoid",
            "Monstrosity",
            "Ooze",
            "Plant",
            "Undead"});
            this.CLBType.Location = new System.Drawing.Point(116, 27);
            this.CLBType.Name = "CLBType";
            this.CLBType.Size = new System.Drawing.Size(101, 64);
            this.CLBType.TabIndex = 7;
            this.CLBType.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBType_ItemCheck);
            // 
            // CLBAlignment
            // 
            this.CLBAlignment.FormattingEnabled = true;
            this.CLBAlignment.Items.AddRange(new object[] {
            "L-G",
            "N-G",
            "C-G",
            "L-N",
            "N",
            "C-N",
            "L-E",
            "N-E",
            "C-E",
            "X-E",
            "X-G",
            "L-X",
            "C-X",
            "U"});
            this.CLBAlignment.Location = new System.Drawing.Point(223, 27);
            this.CLBAlignment.Name = "CLBAlignment";
            this.CLBAlignment.Size = new System.Drawing.Size(101, 64);
            this.CLBAlignment.TabIndex = 8;
            this.CLBAlignment.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBAlignment_ItemCheck);
            // 
            // CLBChallenge
            // 
            this.CLBChallenge.FormattingEnabled = true;
            this.CLBChallenge.Items.AddRange(new object[] {
            "0",
            "1/8",
            "1/4",
            "1/2",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.CLBChallenge.Location = new System.Drawing.Point(330, 27);
            this.CLBChallenge.Name = "CLBChallenge";
            this.CLBChallenge.Size = new System.Drawing.Size(101, 64);
            this.CLBChallenge.TabIndex = 9;
            this.CLBChallenge.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBChallenge_ItemCheck);
            // 
            // MonsterCompendium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 457);
            this.Controls.Add(this.CLBChallenge);
            this.Controls.Add(this.CLBAlignment);
            this.Controls.Add(this.CLBType);
            this.Controls.Add(this.LBLChallenge);
            this.Controls.Add(this.LBLAlignment);
            this.Controls.Add(this.LBLType);
            this.Controls.Add(this.LBLSize);
            this.Controls.Add(this.CLBSize);
            this.Controls.Add(this.DGVMonsterList);
            this.Name = "MonsterCompendium";
            this.Text = "Monster Compendium";
            this.Load += new System.EventHandler(this.MonsterCompendium_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMonsterList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVMonsterList;
        private System.Windows.Forms.CheckedListBox CLBSize;
        private System.Windows.Forms.Label LBLSize;
        private System.Windows.Forms.Label LBLType;
        private System.Windows.Forms.Label LBLAlignment;
        private System.Windows.Forms.Label LBLChallenge;
        private System.Windows.Forms.CheckedListBox CLBType;
        private System.Windows.Forms.CheckedListBox CLBAlignment;
        private System.Windows.Forms.CheckedListBox CLBChallenge;
    }
}

