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
    public partial class Form1 : Form, IYatzeeClient
    {
        YatzeeEngine ye;
        ScoreField[] theScore;
        public Form1()
        {
            InitializeComponent();
            ye = new YatzeeEngine();
            ye.RegisterClient(this);

            theScore = new ScoreField[18];

            dataGrid.Enabled = false;
            //dataGrid.ColumnCount = 3;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            UpdateScoreBoard();
            dataGrid.DataSource = theScore;
        }

        private void Button1_Click(object sender, EventArgs e)
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

        private void Button3_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.ONES);
        }

        // Implementing the YatzeeClient interface
        public void Update()
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

        private void BtTwos_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.TWOS);
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.THREES);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.FOURS);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.FIVES);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.SIXES);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.KIND3);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.KIND4);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.S_STRAIGHT);
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.L_STRAIGHT);
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.YATZEE);
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.CHANCE);
        }

        private void HoldDice2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Dice1_Click(object sender, EventArgs e)
        {

        }

        private void HoldDice1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Dice2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtFullHouse_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.FHOUSE);
        }
    }
}
