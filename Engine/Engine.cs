﻿using System;
using System.Diagnostics;

namespace Engine
{
    public enum YField
    {
        ONES, TWOS, THREES, FOURS, FIVES, SIXES, UPPER_SUB_TOTAL, BONUS, UPPER_TOTAL,
        KIND_3, KIND_4, FULL_HOUSE, S_STRAIGHT, L_STRAIGHT, YATZEE, CHANCE, LOWER_TOTAL, TOTAL
    };

    public class YatzeeEngine
    {
        private const int numberOfPlayers = 2; // antal spillere 
        private const int gameFields = 18;
        private const int numberOfDice = 5;    // Lets just leave at 5 ..for now
        private int throwCount;
 
        private readonly int[] roll;// Det akuelle terningekaste
        private readonly bool[] holdDice; // Det akuelle terningekaste
        private readonly int[,] scoreBoard;
        private readonly bool[,] scoreBoardValidFields;
        private int currentPlayer;
        private readonly Random randomizer;
        // private string gameMessage = "";   // for future use

        public YatzeeEngine()
        {
            roll = new int[numberOfDice];                                     // Antal terninger i kastet
            holdDice = new bool[numberOfDice];                                // Markering af terninger som ikke indgår i næste slag
            scoreBoard = new int[gameFields, numberOfPlayers + 1];            // Index=0 = FeltID,   index=1 Player 1, index=2 Player 2
            scoreBoardValidFields = new Boolean[gameFields, numberOfPlayers]; // Index=0 = FeltID,   index=1 Player 1, index=2 Player 2
            randomizer = new Random();

            InitializeGame();
        }

        public int GetThrowCount() { return throwCount; }

        public int GetCurrentPlayer() { return currentPlayer; }

        public int[,] GetScoreBoard() { return scoreBoard; }

        public Boolean[,] GetScoreBoardValidFields() { return scoreBoardValidFields; }

        public int[] GetThrow() { return roll; }

        public void InitializeGame()
        {
            Array.Fill(roll, 0);
            Array.Fill(holdDice, false);

            for (int i = 0; i < gameFields; ++i)
            {
                for (int j = 0; j < numberOfPlayers + 1; ++j)
                {
                    scoreBoard[i, j] = 0;
                }
                scoreBoard[i, 0] = i;
                for (int j = 0; j < numberOfPlayers; ++j)
                {
                    scoreBoardValidFields[i, j] = true;
                }
            }

            throwCount = 0;
            currentPlayer = 1;
        }

        /*******************************************************************************************
         * Kaster terninger ( dvs. på dem som er lagt fra ) i holdDice
         ******************************************************************************************/
        public void ThrowDice()
        {
            if (throwCount >= 3)    // Do nothing if max amount of throws for this player has been reached
                return;

            for (int x = 0; x < numberOfDice; x++)
            {
                if (holdDice[x] == false)
                {
                    roll[x] = randomizer.Next(1, 6);    // MAGIC NUMBER !!!.. this needs to be changed
                }
            }
            throwCount++;
        }

        public void SetTurn(int n)
        {
            throwCount = 0;
            Array.Fill(roll, 0);
            Array.Fill(holdDice, false);
            currentPlayer = n;
        }

        public void HoldDice(int x)
        {
            holdDice[x - 1] = true;
            Debug.WriteLine("Hold dice nr : {0}", x);
            //client.update(); // FIX UPDATE: to reflect DICE state (hold og not-hold)
        }

        public void SumScores()
        {

            int upper_sub_total;
            int upper_total;
            int lower_total;
            int total;

            for (int x = 1; x <= numberOfPlayers; x++)
            {
                upper_sub_total = 0;
                upper_total = 0;

                lower_total = 0;
                total = 0;

                upper_sub_total += scoreBoard[(int)YField.ONES, x];
                upper_sub_total += scoreBoard[(int)YField.TWOS, x];
                upper_sub_total += scoreBoard[(int)YField.THREES, x];
                upper_sub_total += scoreBoard[(int)YField.FOURS, x];
                upper_sub_total += scoreBoard[(int)YField.FIVES, x];
                upper_sub_total += scoreBoard[(int)YField.SIXES, x];

                Debug.WriteLine("UpperTotal: {0}", upper_total);

                upper_total = upper_sub_total;
                if (upper_sub_total > 63)
                {
                    scoreBoard[(int)YField.BONUS, x] = 35;
                    upper_total = upper_sub_total + 35;
                }


                lower_total += scoreBoard[(int)YField.KIND_3, x];
                lower_total += scoreBoard[(int)YField.KIND_4, x];
                lower_total += scoreBoard[(int)YField.FULL_HOUSE, x];
                lower_total += scoreBoard[(int)YField.S_STRAIGHT, x];
                lower_total += scoreBoard[(int)YField.L_STRAIGHT, x];
                lower_total += scoreBoard[(int)YField.YATZEE, x];
                lower_total += scoreBoard[(int)YField.CHANCE, x];

                total = upper_total + lower_total;

                scoreBoard[(int)YField.UPPER_SUB_TOTAL, x] = upper_total;
                scoreBoard[(int)YField.UPPER_TOTAL, x] = upper_total;

                scoreBoard[(int)YField.LOWER_TOTAL, x] = lower_total;
                scoreBoard[(int)YField.TOTAL, x] = total;
            }
        }

        public void SelectField(YField field)
        {
            if (scoreBoardValidFields[(int)field, currentPlayer - 1] != true)
            {
                return; // currentPlayer forsøgte at sætte en værdi ind hvor der allerede eksisterende en værdi.
            }
            scoreBoardValidFields[(int)field, currentPlayer - 1] = false;

            switch (field)
            {
                case YField.ONES:
                    scoreBoard[(int)YField.ONES, currentPlayer] = ScoreCounter.ScoreSingleSum(1, roll);
                    break;
                case YField.TWOS:
                    scoreBoard[(int)YField.TWOS, currentPlayer] = ScoreCounter.ScoreSingleSum(2, roll);
                    break;
                case YField.THREES:
                    scoreBoard[(int)YField.THREES, currentPlayer] = ScoreCounter.ScoreSingleSum(3, roll);
                    break;
                case YField.FOURS:
                    scoreBoard[(int)YField.FOURS, currentPlayer] = ScoreCounter.ScoreSingleSum(4, roll);
                    break;
                case YField.FIVES:
                    scoreBoard[(int)YField.FIVES, currentPlayer] = ScoreCounter.ScoreSingleSum(5, roll);
                    break;
                case YField.SIXES:
                    scoreBoard[(int)YField.SIXES, currentPlayer] = ScoreCounter.ScoreSingleSum(6, roll);
                    break;
                case YField.KIND_3:
                    scoreBoard[(int)YField.KIND_3, currentPlayer] = ScoreCounter.ScoreKind(3, roll);
                    break;
                case YField.KIND_4:
                    scoreBoard[(int)YField.KIND_4, currentPlayer] = ScoreCounter.ScoreKind(4, roll);
                    break;
                case YField.FULL_HOUSE:
                    scoreBoard[(int)YField.FULL_HOUSE, currentPlayer] = ScoreCounter.ScoreFullHouse(roll);
                    break;
                case YField.S_STRAIGHT:
                    scoreBoard[(int)YField.S_STRAIGHT, currentPlayer] = ScoreCounter.ScoreSmallStraight(roll);
                    break;
                case YField.L_STRAIGHT:
                    scoreBoard[(int)YField.L_STRAIGHT, currentPlayer] = ScoreCounter.ScoreLargeStraight(roll);
                    break;
                case YField.CHANCE:
                    scoreBoard[(int)YField.CHANCE, currentPlayer] = ScoreCounter.ScoreChance(roll);
                    break;
                case YField.YATZEE:
                    scoreBoard[(int)YField.YATZEE, currentPlayer] = ScoreCounter.ScoreYatzee(roll);
                    break;
            }

            SumScores();


            if (currentPlayer == 1)
                SetTurn(2);
            else
                SetTurn(1);
        }
    }
}
