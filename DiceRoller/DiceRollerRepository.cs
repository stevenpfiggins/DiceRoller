using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoller
{
    public class DiceRollerRepository
    {
        readonly Random random = new Random();

        public List<int> GetDiceRollResultsList(string dieChoice, int numberOfDiceChoice)
        {
            var diceRollResults = new List<int>();

            for (int i = 0; i < numberOfDiceChoice; i++)
            {
                var rollResult = GetRandomNumber(dieChoice);
                diceRollResults.Add(rollResult);
            }

            return diceRollResults;
        }

        public int GetRandomNumber(string s)
        {
            int result;

            switch (s)
            {
                case "d3":
                    result = random.Next(1, 4);
                    break;
                case "d4":
                    result = random.Next(1, 5);
                    break;
                case "d6":
                    result = random.Next(1, 7);
                    break;
                case "d8":
                    result = random.Next(1, 9);
                    break;
                case "d10":
                    result = random.Next(1, 11);
                    break;
                case "d10 percentile":
                    result = random.Next(1, 11);
                    break;
                case "d12":
                    result = random.Next(1, 13);
                    break;
                case "d20":
                    result = random.Next(1, 21);
                    break;
                default:
                    result = random.Next();
                    break;
            }

            return result;
        }

        public string GetDieChoice(int i)
        {
            string choice;

            switch (i)
            {
                case 1:
                    choice = "d3";
                    break;
                case 2:
                    choice = "d4";
                    break;
                case 3:
                    choice = "d6";
                    break;
                case 4:
                    choice = "d8";
                    break;
                case 5:
                    choice = "d10";
                    break;
                case 6:
                    choice = "d10 percentile";
                    break;
                case 7:
                    choice = "d12";
                    break;
                case 8:
                    choice = "d20";
                    break;
                default:
                    choice = "random number";
                    break;
            }

            return choice;
        }
    }
}
