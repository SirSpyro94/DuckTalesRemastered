namespace DuckTalesRemasteredPSN
{
    partial class Main
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTMoney = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDifficulty = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUnlockAllChar = new System.Windows.Forms.CheckBox();
            this.cbConceptArt = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSketches = new System.Windows.Forms.CheckBox();
            this.cbPencil = new System.Windows.Forms.CheckBox();
            this.cbPaintings = new System.Windows.Forms.CheckBox();
            this.cbMusic = new System.Windows.Forms.CheckBox();
            this.cbTVShow1 = new System.Windows.Forms.CheckBox();
            this.cbTVShow2 = new System.Windows.Forms.CheckBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(93, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 9);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 12;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTMoney);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbDifficulty);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 71);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MoDz";
            // 
            // txtTMoney
            // 
            this.txtTMoney.Location = new System.Drawing.Point(85, 46);
            this.txtTMoney.Name = "txtTMoney";
            this.txtTMoney.Size = new System.Drawing.Size(109, 20);
            this.txtTMoney.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Money -";
            // 
            // cbDifficulty
            // 
            this.cbDifficulty.FormattingEnabled = true;
            this.cbDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cbDifficulty.Location = new System.Drawing.Point(85, 19);
            this.cbDifficulty.Name = "cbDifficulty";
            this.cbDifficulty.Size = new System.Drawing.Size(67, 21);
            this.cbDifficulty.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Difficulty -";
            // 
            // cbUnlockAllChar
            // 
            this.cbUnlockAllChar.AutoSize = true;
            this.cbUnlockAllChar.Location = new System.Drawing.Point(6, 19);
            this.cbUnlockAllChar.Name = "cbUnlockAllChar";
            this.cbUnlockAllChar.Size = new System.Drawing.Size(128, 17);
            this.cbUnlockAllChar.TabIndex = 6;
            this.cbUnlockAllChar.Text = "Unlock All Characters";
            this.cbUnlockAllChar.UseVisualStyleBackColor = true;
            // 
            // cbConceptArt
            // 
            this.cbConceptArt.AutoSize = true;
            this.cbConceptArt.Location = new System.Drawing.Point(6, 42);
            this.cbConceptArt.Name = "cbConceptArt";
            this.cbConceptArt.Size = new System.Drawing.Size(133, 17);
            this.cbConceptArt.TabIndex = 19;
            this.cbConceptArt.Text = "Unlock All Concept Art";
            this.cbConceptArt.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAll);
            this.groupBox2.Controls.Add(this.cbTVShow2);
            this.groupBox2.Controls.Add(this.cbTVShow1);
            this.groupBox2.Controls.Add(this.cbMusic);
            this.groupBox2.Controls.Add(this.cbPaintings);
            this.groupBox2.Controls.Add(this.cbPencil);
            this.groupBox2.Controls.Add(this.cbSketches);
            this.groupBox2.Controls.Add(this.cbUnlockAllChar);
            this.groupBox2.Controls.Add(this.cbConceptArt);
            this.groupBox2.Location = new System.Drawing.Point(12, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 132);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unlocks";
            // 
            // cbSketches
            // 
            this.cbSketches.AutoSize = true;
            this.cbSketches.Location = new System.Drawing.Point(6, 65);
            this.cbSketches.Name = "cbSketches";
            this.cbSketches.Size = new System.Drawing.Size(122, 17);
            this.cbSketches.TabIndex = 20;
            this.cbSketches.Text = "Unlock All Sketches";
            this.cbSketches.UseVisualStyleBackColor = true;
            // 
            // cbPencil
            // 
            this.cbPencil.AutoSize = true;
            this.cbPencil.Location = new System.Drawing.Point(6, 88);
            this.cbPencil.Name = "cbPencil";
            this.cbPencil.Size = new System.Drawing.Size(149, 17);
            this.cbPencil.TabIndex = 21;
            this.cbPencil.Text = "Unlock All Pencil Renders";
            this.cbPencil.UseVisualStyleBackColor = true;
            // 
            // cbPaintings
            // 
            this.cbPaintings.AutoSize = true;
            this.cbPaintings.Location = new System.Drawing.Point(6, 111);
            this.cbPaintings.Name = "cbPaintings";
            this.cbPaintings.Size = new System.Drawing.Size(181, 17);
            this.cbPaintings.TabIndex = 22;
            this.cbPaintings.Text = "Unlock All Background Paintings";
            this.cbPaintings.UseVisualStyleBackColor = true;
            // 
            // cbMusic
            // 
            this.cbMusic.AutoSize = true;
            this.cbMusic.Location = new System.Drawing.Point(183, 19);
            this.cbMusic.Name = "cbMusic";
            this.cbMusic.Size = new System.Drawing.Size(105, 17);
            this.cbMusic.TabIndex = 23;
            this.cbMusic.Text = "Unlock All Music";
            this.cbMusic.UseVisualStyleBackColor = true;
            // 
            // cbTVShow1
            // 
            this.cbTVShow1.AutoSize = true;
            this.cbTVShow1.Location = new System.Drawing.Point(183, 42);
            this.cbTVShow1.Name = "cbTVShow1";
            this.cbTVShow1.Size = new System.Drawing.Size(146, 17);
            this.cbTVShow1.TabIndex = 24;
            this.cbTVShow1.Text = "Unlock All TV Show Art 1";
            this.cbTVShow1.UseVisualStyleBackColor = true;
            // 
            // cbTVShow2
            // 
            this.cbTVShow2.AutoSize = true;
            this.cbTVShow2.Location = new System.Drawing.Point(183, 65);
            this.cbTVShow2.Name = "cbTVShow2";
            this.cbTVShow2.Size = new System.Drawing.Size(146, 17);
            this.cbTVShow2.TabIndex = 25;
            this.cbTVShow2.Text = "Unlock All TV Show Art 2";
            this.cbTVShow2.UseVisualStyleBackColor = true;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(201, 103);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(128, 23);
            this.btnAll.TabIndex = 26;
            this.btnAll.Text = "Unlock All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 257);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DuckTales Remastered - Save";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbDifficulty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbUnlockAllChar;
        private System.Windows.Forms.CheckBox cbConceptArt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbSketches;
        private System.Windows.Forms.CheckBox cbPencil;
        private System.Windows.Forms.CheckBox cbPaintings;
        private System.Windows.Forms.CheckBox cbMusic;
        private System.Windows.Forms.CheckBox cbTVShow2;
        private System.Windows.Forms.CheckBox cbTVShow1;
        private System.Windows.Forms.Button btnAll;
    }
}

