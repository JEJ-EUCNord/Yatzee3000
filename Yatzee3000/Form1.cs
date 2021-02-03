using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;


namespace Engine
{
    public partial class Form1 : Form
    {
        readonly YatzeeEngine ye;
        readonly ScoreField[] theScore;

        public Form1()
        {
            InitializeComponent();
            ye = new YatzeeEngine();

            theScore = new ScoreField[18];

            dataGrid.Enabled = false;
            //dataGrid.ColumnCount = 3;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            UpdateScoreBoard();
            dataGrid.DataSource = theScore;
        }

        private void Throw_Click(object sender, EventArgs e)
        {
            if (holdDice1.Checked)
                ye.HoldDice(1);
            if (holdDice2.Checked)
                ye.HoldDice(2);
            if (holdDice3.Checked)
                ye.HoldDice(3);
            if (holdDice4.Checked)
                ye.HoldDice(4);
            if (holdDice5.Checked)
                ye.HoldDice(5);

            ye.ThrowDice();

            UpdateGUI();
        }

        public void UpdateScoreBoard()
        {

            int[,] theData = ye.GetScoreBoard();
            int height = theData.GetLength(0);

            for (int r = 0; r < height; r++)
            {
                theScore[r] = new ScoreField(
                    GetLabel(r),
                    theData[r, 1],
                    theData[r, 2]);
            }

            dataGrid.Update();
            dataGrid.Refresh();
        }

        private string GetLabel(int field)
        {
            string[] labels = { "Enere", "Toere", "Treere", "Fire'ere", "Femmere", "Seksere", "(sub)Total", "Bonus", "Øvretotal", "3 ENS", "4 ENS", "Full House", "L.Straight", "S.Straight", "Yatzee", "Chance", "Nedre total", "Total", "", "" };

            return labels[(int)field];
        }

        private void Ones_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.ONES);
            UpdateGUI();        }

        private void Twos_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.TWOS);
            UpdateGUI();
        }

        private void Threes_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.THREES);
            UpdateGUI();
        }

        private void Fours_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.FOURS);
            UpdateGUI();
        }

        private void Fives_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.FIVES);
            UpdateGUI();
        }

        private void Sixes_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.SIXES);
            UpdateGUI();
        }

        private void Kind3_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.KIND_3);
            UpdateGUI();
        }

        private void Kind4_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.KIND_4);
            UpdateGUI();
        }

        private void FullHouse_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.FULL_HOUSE);
            UpdateGUI();
        }

        private void LStraight_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.S_STRAIGHT);
            UpdateGUI();
        }

        private void SStraight_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.L_STRAIGHT);
            UpdateGUI();
        }

        private void Yatzee_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.YATZEE);
            UpdateGUI();
        }

        // Implementing the YatzeeClient interface
        public void UpdateGUI()
        {
            int[] th = ye.GetThrow();
            dice1.Text = "" + th[0];
            dice2.Text = "" + th[1];
            dice3.Text = "" + th[2];
            dice4.Text = "" + th[3];
            dice5.Text = "" + th[4];
            labelKast.Text = "Kast Nr.: " + ye.GetThrowCount();
            labelTur.Text = "Spiller Nr.: " + ye.GetCurrentPlayer();
            holdDice1.Checked = false;
            holdDice2.Checked = false;
            holdDice3.Checked = false;
            holdDice4.Checked = false;
            holdDice5.Checked = false;
            //==============================================================================================================
            UpdateScoreBoard();
        }
    }
}
