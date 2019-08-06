using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGameApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var game = new NumberGame(Console.ReadLine());
            do
            {
                var resultAry = game.PLay(Console.ReadLine()); ;
                Console.WriteLine(
                    string.Join(" ", resultAry.Select(n => n.ToString()))
                );

            } while (!game.IsOver);
            Console.WriteLine(game.ResultLabel);
        }
    }

    public class NumberGame
    {
        private const string RESULT_LABEL_WIN = "win";
        private const string RESULT_LABEL_LOSE = "lose";
        private const int MAX_PLAY_COUNT = 5;

        private char[] answers;
        private int playCount;
        private bool isWin;

        public bool IsOver { get => isWin || playCount == MAX_PLAY_COUNT; }
        public string ResultLabel { get => isWin ? RESULT_LABEL_WIN : RESULT_LABEL_LOSE; }

        public NumberGame(string answer)
        {
            this.answers = answer.ToCharArray();
            this.playCount = 0;
        }

        public int[] PLay(string input)
        {
            this.playCount++;

            var inputs = input.ToCharArray();
            var placeMatch = 0;
            var numberMatch = 0;
            for (int i = 0; i < inputs.Length; i++)
            {
                if (inputs[i].Equals(answers[i]))
                {
                    placeMatch += 1;
                }
                else if (answers.Contains(inputs[i]))
                {
                    numberMatch += 1;
                }
            }
            if (placeMatch == answers.Length)
            {
                this.isWin = true;
            }
            return new int[] { placeMatch, numberMatch };
        }
    }
}
