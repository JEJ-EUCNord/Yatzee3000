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
            this.Thow = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btOnes = new System.Windows.Forms.Button();
            this.btTwos = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.dice5 = new System.Windows.Forms.Button();
            this.dice4 = new System.Windows.Forms.Button();
            this.dice3 = new System.Windows.Forms.Button();
            this.dice2 = new System.Windows.Forms.Button();
            this.dice1 = new System.Windows.Forms.Button();
            this.diceBox = new System.Windows.Forms.GroupBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
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
            this.btFullHouse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.diceBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Thow
            // 
            this.Thow.Location = new System.Drawing.Point(761, 415);
            this.Thow.Name = "Thow";
            this.Thow.Size = new System.Drawing.Size(75, 59);
            this.Thow.TabIndex = 0;
            this.Thow.Text = "Kast !";
            this.Thow.UseVisualStyleBackColor = true;
            this.Thow.Click += new System.EventHandler(this.Throw_Click);
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
            // btOnes
            // 
            this.btOnes.Location = new System.Drawing.Point(307, 13);
            this.btOnes.Name = "btOnes";
            this.btOnes.Size = new System.Drawing.Size(86, 23);
            this.btOnes.TabIndex = 4;
            this.btOnes.Text = "<- 1\'ERE";
            this.btOnes.UseVisualStyleBackColor = true;
            this.btOnes.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btTwos
            // 
            this.btTwos.Location = new System.Drawing.Point(307, 42);
            this.btTwos.Name = "btTwos";
            this.btTwos.Size = new System.Drawing.Size(86, 23);
            this.btTwos.TabIndex = 4;
            this.btTwos.Text = "<- 2\'ERE";
            this.btTwos.UseVisualStyleBackColor = true;
            this.btTwos.Click += new System.EventHandler(this.BtTwos_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(307, 71);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "<- 3\'ERE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(307, 100);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "<- 4\'ERE";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(307, 129);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(86, 23);
            this.button7.TabIndex = 4;
            this.button7.Text = "<- 5\'ERE";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(307, 158);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(86, 23);
            this.button8.TabIndex = 4;
            this.button8.Text = "<- 6\'ERE";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(307, 187);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(86, 23);
            this.button9.TabIndex = 4;
            this.button9.Text = "<- 3 ENS ";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(307, 216);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(86, 23);
            this.button10.TabIndex = 4;
            this.button10.Text = "<- 4 ENS";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Button10_Click);
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
            this.dice2.Click += new System.EventHandler(this.Dice2_Click);
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
            this.dice1.Click += new System.EventHandler(this.Dice1_Click);
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
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(307, 273);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(86, 23);
            this.button16.TabIndex = 4;
            this.button16.Text = "L.Straigth";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.Button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(307, 302);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(86, 23);
            this.button17.TabIndex = 4;
            this.button17.Text = "S.Straight";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.Button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(307, 331);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(86, 23);
            this.button18.TabIndex = 4;
            this.button18.Text = "<- Yatzee";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.Button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(307, 360);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(86, 23);
            this.button19.TabIndex = 4;
            this.button19.Text = "<- Chance";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.Button19_Click);
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
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick);
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
            this.holdDice1.CheckedChanged += new System.EventHandler(this.HoldDice1_CheckedChanged);
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
            this.holdDice2.CheckedChanged += new System.EventHandler(this.HoldDice2_CheckedChanged);
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
            this.messageField.Click += new System.EventHandler(this.Label1_Click);
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
            // btFullHouse
            // 
            this.btFullHouse.Location = new System.Drawing.Point(307, 245);
            this.btFullHouse.Name = "btFullHouse";
            this.btFullHouse.Size = new System.Drawing.Size(86, 23);
            this.btFullHouse.TabIndex = 10;
            this.btFullHouse.Text = "<- FullHouse";
            this.btFullHouse.UseVisualStyleBackColor = true;
            this.btFullHouse.Click += new System.EventHandler(this.BtFullHouse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 486);
            this.Controls.Add(this.btFullHouse);
            this.Controls.Add(this.labelTur);
            this.Controls.Add(this.messageField);
            this.Controls.Add(this.holdDice5);
            this.Controls.Add(this.holdDice4);
            this.Controls.Add(this.holdDice3);
            this.Controls.Add(this.holdDice2);
            this.Controls.Add(this.holdDice1);
            this.Controls.Add(this.labelKast);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.diceBox);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btTwos);
            this.Controls.Add(this.btOnes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.Thow);
            this.Name = "Form1";
            this.Text = "Yatzee3000 v0.1c";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.diceBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Thow;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btOnes;
        private System.Windows.Forms.Button btTwos;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button dice5;
        private System.Windows.Forms.Button dice4;
        private System.Windows.Forms.Button dice3;
        private System.Windows.Forms.Button dice2;
        private System.Windows.Forms.Button dice1;
        private System.Windows.Forms.GroupBox diceBox;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Label labelKast;
        private System.Windows.Forms.CheckBox holdDice1;
        private System.Windows.Forms.CheckBox holdDice2;
        private System.Windows.Forms.CheckBox holdDice3;
        private System.Windows.Forms.CheckBox holdDice4;
        private System.Windows.Forms.CheckBox holdDice5;
        private System.Windows.Forms.Label messageField;
        private System.Windows.Forms.Label labelTur;
        private System.Windows.Forms.Button btFullHouse;
    }
}

