namespace Engine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Throw = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ones = new System.Windows.Forms.Button();
            this.Twos = new System.Windows.Forms.Button();
            this.Threes = new System.Windows.Forms.Button();
            this.Fours = new System.Windows.Forms.Button();
            this.Fives = new System.Windows.Forms.Button();
            this.Sixes = new System.Windows.Forms.Button();
            this.Kind3 = new System.Windows.Forms.Button();
            this.Kind4 = new System.Windows.Forms.Button();
            this.dice5 = new System.Windows.Forms.Button();
            this.dice4 = new System.Windows.Forms.Button();
            this.dice3 = new System.Windows.Forms.Button();
            this.dice2 = new System.Windows.Forms.Button();
            this.dice1 = new System.Windows.Forms.Button();
            this.diceBox = new System.Windows.Forms.GroupBox();
            this.LStraight = new System.Windows.Forms.Button();
            this.SStraight = new System.Windows.Forms.Button();
            this.Yatzee = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.labelKast = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.holdDice1 = new System.Windows.Forms.CheckBox();
            this.holdDice2 = new System.Windows.Forms.CheckBox();
            this.holdDice3 = new System.Windows.Forms.CheckBox();
            this.holdDice4 = new System.Windows.Forms.CheckBox();
            this.holdDice5 = new System.Windows.Forms.CheckBox();
            this.messageField = new System.Windows.Forms.Label();
            this.labelTur = new System.Windows.Forms.Label();
            this.FullHouse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.diceBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Throw
            // 
            this.Throw.Location = new System.Drawing.Point(761, 415);
            this.Throw.Name = "Throw";
            this.Throw.Size = new System.Drawing.Size(75, 59);
            this.Throw.TabIndex = 0;
            this.Throw.Text = "Kast !";
            this.Throw.UseVisualStyleBackColor = true;
            this.Throw.Click += new System.EventHandler(this.Throw_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(423, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 226);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Ones
            // 
            this.Ones.Location = new System.Drawing.Point(307, 13);
            this.Ones.Name = "Ones";
            this.Ones.Size = new System.Drawing.Size(86, 23);
            this.Ones.TabIndex = 4;
            this.Ones.Text = "<- 1\'ERE";
            this.Ones.UseVisualStyleBackColor = true;
            this.Ones.Click += new System.EventHandler(this.Ones_Click);
            // 
            // Twos
            // 
            this.Twos.Location = new System.Drawing.Point(307, 42);
            this.Twos.Name = "Twos";
            this.Twos.Size = new System.Drawing.Size(86, 23);
            this.Twos.TabIndex = 4;
            this.Twos.Text = "<- 2\'ERE";
            this.Twos.UseVisualStyleBackColor = true;
            this.Twos.Click += new System.EventHandler(this.Twos_Click);
            // 
            // Threes
            // 
            this.Threes.Location = new System.Drawing.Point(307, 71);
            this.Threes.Name = "Threes";
            this.Threes.Size = new System.Drawing.Size(86, 23);
            this.Threes.TabIndex = 4;
            this.Threes.Text = "<- 3\'ERE";
            this.Threes.UseVisualStyleBackColor = true;
            this.Threes.Click += new System.EventHandler(this.Threes_Click);
            // 
            // Fours
            // 
            this.Fours.Location = new System.Drawing.Point(307, 100);
            this.Fours.Name = "Fours";
            this.Fours.Size = new System.Drawing.Size(86, 23);
            this.Fours.TabIndex = 4;
            this.Fours.Text = "<- 4\'ERE";
            this.Fours.UseVisualStyleBackColor = true;
            this.Fours.Click += new System.EventHandler(this.Fours_Click);
            // 
            // Fives
            // 
            this.Fives.Location = new System.Drawing.Point(307, 129);
            this.Fives.Name = "Fives";
            this.Fives.Size = new System.Drawing.Size(86, 23);
            this.Fives.TabIndex = 4;
            this.Fives.Text = "<- 5\'ERE";
            this.Fives.UseVisualStyleBackColor = true;
            this.Fives.Click += new System.EventHandler(this.Fives_Click);
            // 
            // Sixes
            // 
            this.Sixes.Location = new System.Drawing.Point(307, 158);
            this.Sixes.Name = "Sixes";
            this.Sixes.Size = new System.Drawing.Size(86, 23);
            this.Sixes.TabIndex = 4;
            this.Sixes.Text = "<- 6\'ERE";
            this.Sixes.UseVisualStyleBackColor = true;
            this.Sixes.Click += new System.EventHandler(this.Sixes_Click);
            // 
            // Kind3
            // 
            this.Kind3.Location = new System.Drawing.Point(307, 187);
            this.Kind3.Name = "Kind3";
            this.Kind3.Size = new System.Drawing.Size(86, 23);
            this.Kind3.TabIndex = 4;
            this.Kind3.Text = "<- 3 ENS ";
            this.Kind3.UseVisualStyleBackColor = true;
            this.Kind3.Click += new System.EventHandler(this.Kind3_Click);
            // 
            // Kind4
            // 
            this.Kind4.Location = new System.Drawing.Point(307, 216);
            this.Kind4.Name = "Kind4";
            this.Kind4.Size = new System.Drawing.Size(86, 23);
            this.Kind4.TabIndex = 4;
            this.Kind4.Text = "<- 4 ENS";
            this.Kind4.UseVisualStyleBackColor = true;
            this.Kind4.Click += new System.EventHandler(this.Kind4_Click);
            // 
            // dice5
            // 
            this.dice5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dice5.Location = new System.Drawing.Point(349, 22);
            this.dice5.Name = "dice5";
            this.dice5.Size = new System.Drawing.Size(75, 68);
            this.dice5.TabIndex = 4;
            this.dice5.Text = "X";
            this.dice5.UseVisualStyleBackColor = true;
            // 
            // dice4
            // 
            this.dice4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dice4.Location = new System.Drawing.Point(268, 22);
            this.dice4.Name = "dice4";
            this.dice4.Size = new System.Drawing.Size(75, 68);
            this.dice4.TabIndex = 4;
            this.dice4.Text = "X";
            this.dice4.UseVisualStyleBackColor = true;
            // 
            // dice3
            // 
            this.dice3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dice3.Location = new System.Drawing.Point(187, 22);
            this.dice3.Name = "dice3";
            this.dice3.Size = new System.Drawing.Size(75, 68);
            this.dice3.TabIndex = 4;
            this.dice3.Text = "X";
            this.dice3.UseVisualStyleBackColor = true;
            // 
            // dice2
            // 
            this.dice2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dice2.Location = new System.Drawing.Point(106, 22);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(75, 68);
            this.dice2.TabIndex = 4;
            this.dice2.Text = "X";
            this.dice2.UseVisualStyleBackColor = true;
            // 
            // dice1
            // 
            this.dice1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dice1.Location = new System.Drawing.Point(25, 22);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(75, 68);
            this.dice1.TabIndex = 4;
            this.dice1.Text = "X";
            this.dice1.UseVisualStyleBackColor = true;
            // 
            // diceBox
            // 
            this.diceBox.Controls.Add(this.dice1);
            this.diceBox.Controls.Add(this.dice2);
            this.diceBox.Controls.Add(this.dice3);
            this.diceBox.Controls.Add(this.dice4);
            this.diceBox.Controls.Add(this.dice5);
            this.diceBox.Location = new System.Drawing.Point(412, 270);
            this.diceBox.Name = "diceBox";
            this.diceBox.Size = new System.Drawing.Size(453, 105);
            this.diceBox.TabIndex = 5;
            this.diceBox.TabStop = false;
            this.diceBox.Text = "Terningeslag";
            // 
            // LStraight
            // 
            this.LStraight.Location = new System.Drawing.Point(307, 273);
            this.LStraight.Name = "LStraight";
            this.LStraight.Size = new System.Drawing.Size(86, 23);
            this.LStraight.TabIndex = 4;
            this.LStraight.Text = "<- Ll Streg";
            this.LStraight.UseVisualStyleBackColor = true;
            this.LStraight.Click += new System.EventHandler(this.LStraight_Click);
            // 
            // SStraight
            // 
            this.SStraight.Location = new System.Drawing.Point(307, 302);
            this.SStraight.Name = "SStraight";
            this.SStraight.Size = new System.Drawing.Size(86, 23);
            this.SStraight.TabIndex = 4;
            this.SStraight.Text = "<- St. Streg";
            this.SStraight.UseVisualStyleBackColor = true;
            this.SStraight.Click += new System.EventHandler(this.SStraight_Click);
            // 
            // Yatzee
            // 
            this.Yatzee.Location = new System.Drawing.Point(307, 331);
            this.Yatzee.Name = "Yatzee";
            this.Yatzee.Size = new System.Drawing.Size(86, 23);
            this.Yatzee.TabIndex = 4;
            this.Yatzee.Text = "<- Yatzee";
            this.Yatzee.UseVisualStyleBackColor = true;
            this.Yatzee.Click += new System.EventHandler(this.Yatzee_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(307, 360);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(86, 23);
            this.button19.TabIndex = 4;
            this.button19.Text = "<- Chance";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // labelKast
            // 
            this.labelKast.AutoSize = true;
            this.labelKast.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKast.Location = new System.Drawing.Point(564, 240);
            this.labelKast.Name = "labelKast";
            this.labelKast.Size = new System.Drawing.Size(86, 30);
            this.labelKast.TabIndex = 6;
            this.labelKast.Text = "Kast Nr:";
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Enabled = false;
            this.dataGrid.Location = new System.Drawing.Point(13, 13);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(288, 468);
            this.dataGrid.TabIndex = 2;
            this.dataGrid.Text = "dataGridView1";
            // 
            // holdDice1
            // 
            this.holdDice1.Appearance = System.Windows.Forms.Appearance.Button;
            this.holdDice1.AutoSize = true;
            this.holdDice1.Location = new System.Drawing.Point(438, 381);
            this.holdDice1.Name = "holdDice1";
            this.holdDice1.Size = new System.Drawing.Size(69, 25);
            this.holdDice1.TabIndex = 7;
            this.holdDice1.Text = "-- Hold --";
            this.holdDice1.UseVisualStyleBackColor = true;
            // 
            // holdDice2
            // 
            this.holdDice2.Appearance = System.Windows.Forms.Appearance.Button;
            this.holdDice2.AutoSize = true;
            this.holdDice2.Location = new System.Drawing.Point(518, 381);
            this.holdDice2.Name = "holdDice2";
            this.holdDice2.Size = new System.Drawing.Size(75, 25);
            this.holdDice2.TabIndex = 7;
            this.holdDice2.Text = " -- Hold -- ";
            this.holdDice2.UseVisualStyleBackColor = true;
            // 
            // holdDice3
            // 
            this.holdDice3.Appearance = System.Windows.Forms.Appearance.Button;
            this.holdDice3.AutoSize = true;
            this.holdDice3.Location = new System.Drawing.Point(600, 381);
            this.holdDice3.Name = "holdDice3";
            this.holdDice3.Size = new System.Drawing.Size(75, 25);
            this.holdDice3.TabIndex = 7;
            this.holdDice3.Text = " -- Hold -- ";
            this.holdDice3.UseVisualStyleBackColor = true;
            // 
            // holdDice4
            // 
            this.holdDice4.Appearance = System.Windows.Forms.Appearance.Button;
            this.holdDice4.AutoSize = true;
            this.holdDice4.Location = new System.Drawing.Point(681, 381);
            this.holdDice4.Name = "holdDice4";
            this.holdDice4.Size = new System.Drawing.Size(72, 25);
            this.holdDice4.TabIndex = 7;
            this.holdDice4.Text = " -- Hold --";
            this.holdDice4.UseVisualStyleBackColor = true;
            // 
            // holdDice5
            // 
            this.holdDice5.Appearance = System.Windows.Forms.Appearance.Button;
            this.holdDice5.AutoSize = true;
            this.holdDice5.Location = new System.Drawing.Point(761, 381);
            this.holdDice5.Name = "holdDice5";
            this.holdDice5.Size = new System.Drawing.Size(72, 25);
            this.holdDice5.TabIndex = 7;
            this.holdDice5.Text = " -- Hold --";
            this.holdDice5.UseVisualStyleBackColor = true;
            // 
            // messageField
            // 
            this.messageField.AutoSize = true;
            this.messageField.Location = new System.Drawing.Point(412, 441);
            this.messageField.Name = "messageField";
            this.messageField.Size = new System.Drawing.Size(0, 15);
            this.messageField.TabIndex = 8;
            // 
            // labelTur
            // 
            this.labelTur.AutoSize = true;
            this.labelTur.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTur.Location = new System.Drawing.Point(427, 238);
            this.labelTur.Name = "labelTur";
            this.labelTur.Size = new System.Drawing.Size(80, 30);
            this.labelTur.TabIndex = 9;
            this.labelTur.Text = "Spiller :";
            // 
            // FullHouse
            // 
            this.FullHouse.Location = new System.Drawing.Point(307, 245);
            this.FullHouse.Name = "FullHouse";
            this.FullHouse.Size = new System.Drawing.Size(86, 23);
            this.FullHouse.TabIndex = 10;
            this.FullHouse.Text = "<- Fuldt Hus";
            this.FullHouse.UseVisualStyleBackColor = true;
            this.FullHouse.Click += new System.EventHandler(this.FullHouse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 486);
            this.Controls.Add(this.FullHouse);
            this.Controls.Add(this.labelTur);
            this.Controls.Add(this.messageField);
            this.Controls.Add(this.holdDice5);
            this.Controls.Add(this.holdDice4);
            this.Controls.Add(this.holdDice3);
            this.Controls.Add(this.holdDice2);
            this.Controls.Add(this.holdDice1);
            this.Controls.Add(this.labelKast);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.Yatzee);
            this.Controls.Add(this.SStraight);
            this.Controls.Add(this.LStraight);
            this.Controls.Add(this.diceBox);
            this.Controls.Add(this.Kind4);
            this.Controls.Add(this.Kind3);
            this.Controls.Add(this.Sixes);
            this.Controls.Add(this.Fives);
            this.Controls.Add(this.Fours);
            this.Controls.Add(this.Threes);
            this.Controls.Add(this.Twos);
            this.Controls.Add(this.Ones);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.Throw);
            this.Name = "Form1";
            this.Text = "Yatzee3000 v0.1c";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.diceBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Throw;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Ones;
        private System.Windows.Forms.Button Twos;
        private System.Windows.Forms.Button Threes;
        private System.Windows.Forms.Button Fours;
        private System.Windows.Forms.Button Fives;
        private System.Windows.Forms.Button Sixes;
        private System.Windows.Forms.Button Kind3;
        private System.Windows.Forms.Button Kind4;
        private System.Windows.Forms.Button dice5;
        private System.Windows.Forms.Button dice4;
        private System.Windows.Forms.Button dice3;
        private System.Windows.Forms.Button dice2;
        private System.Windows.Forms.Button dice1;
        private System.Windows.Forms.GroupBox diceBox;
        private System.Windows.Forms.Button LStraight;
        private System.Windows.Forms.Button SStraight;
        private System.Windows.Forms.Button Yatzee;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Label labelKast;
        private System.Windows.Forms.CheckBox holdDice1;
        private System.Windows.Forms.CheckBox holdDice2;
        private System.Windows.Forms.CheckBox holdDice3;
        private System.Windows.Forms.CheckBox holdDice4;
        private System.Windows.Forms.CheckBox holdDice5;
        private System.Windows.Forms.Label messageField;
        private System.Windows.Forms.Label labelTur;
        private System.Windows.Forms.Button FullHouse;
    }
}

