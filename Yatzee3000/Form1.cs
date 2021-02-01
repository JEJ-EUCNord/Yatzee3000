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

namespace Yatzee3000
{
    public partial class Form1 : Form, YatzeeClient
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

            updateScoreBoard();
            dataGrid.DataSource = theScore;
        }

        private void button1_Click(object sender, EventArgs e)
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

            ye.throwDice();
        }

        public void updateScoreBoard() {

            int[,] theData = ye.getScoreBoard();

            int height = theData.GetLength(0);

            
            for (int r = 0; r < height; r++)
            {
                theScore[r] = new ScoreField(
                    getLabel(r),
                    theData[r,1], 
                    theData[r,2] );
            }

            dataGrid.Update();
            dataGrid.Refresh();
        }

        private string getLabel(int field) {
            string[] labels = { "Enere", "Toere", "Treere", "Fire'ere", "Femmere", "Seksere", "(sub)Total", "Bonus", "Øvretotal", "3 ENS", "4 ENS","Full House","L.Straight","S.Straight","Yatzee","Chance", "Nedre total", "Total","","" };


            return labels[(int)field];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.ONES);
        }

        // Implementing the YatzeeClient interface
        public void update() 
        {
            int[] th = ye.GetThrow();
            dice1.Text = ""+ th[0];
            dice2.Text = ""+ th[1];
            dice3.Text = ""+ th[2];
            dice4.Text = ""+ th[3];
            dice5.Text = ""+ th[4];
            labelKast.Text = "Kast Nr.: "+ ye.getThrowCount();
            labelTur.Text = "Spiller Nr.: " + ye.getCurrentPlayer();
            holdDice1.Checked = false;
            holdDice2.Checked = false;
            holdDice3.Checked = false;
            holdDice4.Checked = false;
            holdDice5.Checked = false;
            //==============================================================================================================
            updateScoreBoard();
        }

        private void btTwos_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.TWOS);
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.THREES);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.FOURS);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.FIVES);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.SIXES);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.KIND3);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.KIND4);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.S_STRAIGHT);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.L_STRAIGHT);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.YATZEE);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.CHANCE);
        }

        private void HoldDice2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dice1_Click(object sender, EventArgs e)
        {

        }

        private void holdDice1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dice2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btFullHouse_Click(object sender, EventArgs e)
        {
            ye.SelectField(YField.FHOUSE);
        }
    }
}
