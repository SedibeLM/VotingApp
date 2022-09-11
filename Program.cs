using System;

namespace VotingApplication

{
    class Program
    {
        static void Main(string[] args)
        {
            int yesCounter = 2;
            int noCounter = 3;
            int maybeCounter = 4;

            int total = yesCounter + noCounter + maybeCounter;

            var yesPercent = yesCounter * 100.0 / total;
            var noPercent = noCounter * 100.0 / total;
            var maybePercent = maybeCounter * 100.0 / total;

            var yesPercentRoundUp = Math.Round(yesPercent, 2);
            var noPercentRoundUp = Math.Round(noPercent, 2);
            var maybePercentRoundUp = Math.Round(maybePercent, 2);

            var excess = Math.Round(100 - yesPercent - noPercent - maybePercent, 2);

            Console.WriteLine($"Excess: {excess}");

            

            if (yesCounter > noCounter)
            {
                if (yesCounter > maybeCounter)
                {
                    Console.WriteLine($"Yes won");
                    yesPercent += excess;
                }
                else if (maybeCounter > yesCounter)
                {
                    Console.WriteLine($"Maybe won");
                    maybePercent += excess;
                }
            }
            else
            {
                Console.WriteLine($"Draw");
                noPercent += excess;
            };

            if (noCounter > yesCounter)
            {
                if (noCounter > maybeCounter)
                {
                    Console.WriteLine($"No won");
                    noPercent += excess;
                }
                else if (maybeCounter > noCounter)
                {
                    Console.WriteLine($"Maybe won");
                    maybePercent += excess;
                }

            }
            else
            {
                Console.WriteLine($"DRAW");
                yesPercent += excess;
            }

            if (maybeCounter > yesCounter)
            {
                Console.WriteLine($"Maybe won");
                maybePercent += excess;
            }
            else
            {
                Console.WriteLine($"Draw");
        }
            Console.WriteLine($"Yes counts:  {yesCounter}, Percentage: {yesPercent}%");
            Console.WriteLine($"No counts:  {noCounter}, Percentage: {noPercent} %");
            Console.WriteLine($"Maybe counts: {maybeCounter}, Percentage: {maybePercent}%");

            Console.WriteLine($"Total Percentage: {yesPercent + noPercent + maybePercent}");
        }           
    }
       
}

    

