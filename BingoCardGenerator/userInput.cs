using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoCardGenerator
{
    class userInput
    {
         string[,] cstmUserInput = new string[5, 5];

        public string eachSquareInput (string usrInput)
        {
            //display to user which square they are entering into
            int[,] squareCoords;

            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("Enter your text for square ");
            }

            return usrInput;
        }

    }

    class bingoCardTitle
    {
        public static string Title(string cardTitle)
        {
            Console.WriteLine("Please enter the title for your bingo card: ");
            Console.ReadLine();
            return cardTitle;
        }
    }
}
