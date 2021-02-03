using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class ScoreCounter
    {
        static public int ScoreSingleSum(int n, int[] r)
        {
            int sum = 0;

            for (int x = 0; x < r.Length; x++)
            {
                if (r[x] == n)
                    sum += n;
            }
            return sum;
        }

        static public int ScoreKind(int antal, int[] r)
        {
            int sum = 0;
            int count = 0;
            int currDiceNum = -1;
            int offset = 0;

            for (int x = 0; x < r.Length; x++)
            {
                currDiceNum = r[x];

                for (int n = offset; n < r.Length; x++)
                {
                    if (r[n] == currDiceNum)
                    {
                        count++;
                        sum += currDiceNum;
                    }
                    if (count == antal)
                    {
                        return sum;
                    }
                    // terningen opstår iikke 'antal' gange.
                }
                count = 0;
                sum = 0;
                offset++;
            }
            return 0;
        }

        static public int ScoreFullHouse(int[] r)
        {
            Boolean check2 = false; // sandt hvis vi har 3 ens
            Boolean check3 = false; // sandt hvis vi har 2 ens
            int[] counts = new int[6]; // bruger denne til at holde styr på antallet af forekomster

            for (int i = 0; i < r.Length; i++)
                counts[r[i] - 1]++;

            foreach (int i in counts)
            {
                check2 |= (i == 2); //fundet to styk af en given terning..
                check3 |= (i == 3); //fundet tre styk... Bingo ! :)
            }

            if (check2 && check3)
                return 25; // FULL HOUSE GIVER 25 POINT
            return 0;
        }

        static public int ScoreSmallStraight(int[] r)
        {
            int[] counts = new int[6]; // bruger denne til at holde styr på antallet af forekomster
            int forekomster = 0;

            for (int i = 0; i < r.Length; i++)
                counts[r[i] - 1]++;


            // Der må KUN være 1 terning som går igen...
            foreach (int i in counts)
            {
                if (i > 1)
                    forekomster++;
            }
            if (forekomster == 1)
                return 30;
            return 0;
        }

        static public int ScoreLargeStraight(int[] r)
        {
            int[] counts = new int[6]; // bruger denne til at holde styr på antallet af forekomster

            for (int i = 0; i < r.Length; i++)
                counts[r[i] - 1]++;

            foreach (int i in counts)
            {
                if (i > 1)
                    return 0;
            }

            return 40;
        }

        static public int ScoreChance(int[] r)
        {
            int sum = 0;

            for (int x = 0; x < r.Length; x++)
            {
                sum += r[x];
            }
            return sum;
        }

        static public int ScoreYatzee(int[] r)
        {
            for (int x = 0; x < r.Length - 1; x++)
                if (r[x] != r[x + 1])
                    return 0;
            return 50;
        }
    }
}
