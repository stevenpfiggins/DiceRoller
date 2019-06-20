using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoller
{
    public class ProgramUI
    {
        DiceRollerRepository _diceRollerRepo = new DiceRollerRepository();
        bool _isRunning = true;

        public void Run()
        {
            RunMenu();
        }

        private void RunMenu()
        {

            while (_isRunning)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Dice Roller!\n Please choose an option below:\n\t" +
                    "1. Roll one die\n\t" +
                    "2. Roll multiple dice\n\t" +
                    "3. Exit Dice Roller");

                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        SingleDieRoller();
                        break;
                    case 2:
                        MultipleDiceRoller();
                        break;
                    case 3:
                        _isRunning = false;
                        break;
                    default:
                        Console.WriteLine($"{input} is not a valid selection. Press any key to select again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void SingleDieRoller()
        {
            while (_isRunning)
            {
                var dieSelection = SelectDieMenu();
                var rollResult = _diceRollerRepo.GetRandomNumber(dieSelection);
                Console.WriteLine($"You rolled a {rollResult}.");
                Console.WriteLine("Would you like to roll again? (Yes or No)");
                var response = Console.ReadLine().ToLower();
                ReplayOrExitMenu(response);
            }

        }

        private void MultipleDiceRoller()
        {

        }

        private string SelectDieMenu()
        {
            Console.Clear();
            Console.WriteLine("Please select a die to roll:\n\t" +
                "1. d3\n\t" +
                "2. d4\n\t" +
                "3. d6\n\t" +
                "4. d8\n\t" +
                "5. d10\n\t" +
                "6. d10 percentile\n\t" +
                "7. d12\n\t" +
                "8. d20\n\t");
            var dieChoice = int.Parse(Console.ReadLine());
            var dieType = _diceRollerRepo.GetDieChoice(dieChoice);
            return dieType;
        }

        private void ReplayOrExitMenu(string response)
        {
            if (response.Contains("y"))
            {
                _isRunning = true;
            }

            else _isRunning = false;
        }
    }
}
