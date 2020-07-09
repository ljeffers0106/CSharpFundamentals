using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdManChallenge
{
    class BirdMan
    {
        static void Main(string[] args)
        {
            int totalPoints = 5000;
            int totalLives = 3;

                        
            bool vulnerableBirdHunter1 = true;
            bool vulnerableBirdHunter2 = true;
            bool vulnerableBirdHunter3 = true;
            bool vulnerableBirdHunter4 = true;
            bool keepLooping = true;


            while (keepLooping)
            {
                Console.WriteLine("Input a valid string from choices ");
                string inputValue = Console.ReadLine();
                switch(inputValue)
                {
                    case "VulnerableBirdHunter":
                        WhichNumberNow(inputValue);
                        break;
                    case "CreatedIbis":
                        totalPoints += 100;
                        break;
                    case "GreatKiskudee":
                        totalPoints += 300;
                        break;
                    case "RedCrossbill":
                        totalPoints += 500;
                        break;
                    case "RedneckedPhalarope":
                        totalPoints += 700;
                        break;
                    case "EveningGrosbeak":
                        totalPoints += 1000;
                        break;
                    case "GreaterPrairieChicken":
                        totalPoints += 2000;
                        break;
                    case "IcelandGull":
                        totalPoints += 3000;
                        break;
                    case "OrangeBelliedParrot":
                        totalPoints += 5000;
                        break;
                    default:
                        totalPoints += 10;
                        break;
                }
                if (totalPoints >= 10000)
                {
                    totalLives += 1;
                    keepLooping = false;
                }
               
                Console.WriteLine($" Lives =  {totalLives} .");
                Console.WriteLine($" Total Points = {totalPoints}.");
                
                
                Console.ReadKey();

            }

        void WhichNumberNow(string userInput)
            {
                if (vulnerableBirdHunter1 == true)
                {
                    totalPoints += 200;
                    vulnerableBirdHunter1 = false;
                    return;
                }
                if (vulnerableBirdHunter2 == true)
                {
                    totalPoints += 400;
                    vulnerableBirdHunter2 = false;
                    return;
                }
                if (vulnerableBirdHunter3 == true)
                {
                    totalPoints += 800;
                    vulnerableBirdHunter3 = false;
                    return;
                }
                if (vulnerableBirdHunter4 == true)
                {
                    totalPoints += 1600;
                    vulnerableBirdHunter4 = false;
                    return;
                }
            }

        }
        

    }

}
