using System;

namespace courseworkone
{
    class Program
    {
        static void Main(string[] args)

        {
            // creating variables doubles for sales,array to take the store names
            // using a for loop to iterate over the question itself

            Double dubOverallQ1, dubOverallQ2, dubOverallQ3, dubOverallQ4,
                dubTotals1, dubTotals2, dubTotals3, dubTotals4,
                dubstore1Percent, dubstore2Percent, dubstore3Percent, dubstore4Percent,
                dubgrandTotal;

            // two arrays here, strings and a 2 dimensional one for the figures
            String[] storeNames = new string[4];
            int[,] storeSales = new int[4, 4];

            // for loop to iterate over the needed details

            try
            {
                for (int i = 0; i < storeNames.Length; i++)
                {
                    Console.Write("\nPlease enter the name of Store: ");
                    storeNames[i] = Console.ReadLine();
                    Console.Write("Please enter the quarterly sales for " + storeNames[i] + " please enter the digits in thousands i.e 12,000 as 12 :\n");
                    Console.Write("Please enter the Q1 sales for " + storeNames[i] + "\n");
                    storeSales[i, 0] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter the Q2 sales for " + storeNames[i] + "\n");
                    storeSales[i, 1] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter the Q3 sales for " + storeNames[i] + "\n");
                    storeSales[i, 2] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter the Q4 sales for " + storeNames[i] + "\n");
                    storeSales[i, 3] = Convert.ToInt32(Console.ReadLine());
                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message + "Please enter a number");
            }

            // now to calculate the totals for overal sales
            // per store

            dubTotals1 = storeSales[0, 0] + storeSales[0, 1] + storeSales[0, 2] + storeSales[0, 3];
            dubTotals2 = storeSales[1, 0] + storeSales[1, 1] + storeSales[1, 2] + storeSales[1, 3];
            dubTotals3 = storeSales[2, 0] + storeSales[2, 1] + storeSales[2, 2] + storeSales[2, 3];
            dubTotals4 = storeSales[3, 0] + storeSales[3, 1] + storeSales[3, 2] + storeSales[3, 3];
            dubgrandTotal = dubTotals1 + dubTotals2 + dubTotals3 + dubTotals4;

            // totals
            // all stores
            dubOverallQ1 = storeSales[0, 0] + storeSales[1, 0] + storeSales[2, 0] + storeSales[3, 0];
            dubOverallQ2 = storeSales[0, 1] + storeSales[1, 1] + storeSales[2, 1] + storeSales[3, 1];
            dubOverallQ3 = storeSales[0, 2] + storeSales[1, 2] + storeSales[2, 2] + storeSales[3, 2];
            dubOverallQ4 = storeSales[0, 3] + storeSales[1, 3] + storeSales[2, 3] + storeSales[3, 3];

            // doing the percentage math bit

            dubstore1Percent = (dubTotals1 / dubgrandTotal) * 100;
            dubstore2Percent = (dubTotals2 / dubgrandTotal) * 100;
            dubstore3Percent = (dubTotals3 / dubgrandTotal) * 100;
            dubstore4Percent = (dubTotals4 / dubgrandTotal) * 100;

            // all variables have been set so we will now display the table

            Console.WriteLine("\n");
            Console.WriteLine("Sales figures: " + "\t" + storeNames[0] + "\t" + storeNames[1] + "\t" + storeNames[2] + "\t" + storeNames[3] + "\t" + "Overall" + "\n");
            Console.WriteLine("Quarter one: " + "\t" + storeSales[0, 0] + "\t" + storeSales[1, 0] + "\t" + storeSales[2, 0] + "\t" + storeSales[3, 0] + "\t" + dubOverallQ1 + "\n");
            Console.WriteLine("Quarter two: " + "\t" + storeSales[0, 1] + "\t" + storeSales[1, 1] + "\t" + storeSales[2, 1] + "\t" + storeSales[3, 1] + "\t" + dubOverallQ2 + "\n");
            Console.WriteLine("Quarter three: " + "\t" + storeSales[0, 2] + "\t" + storeSales[1, 2] + "\t" + storeSales[2, 2] + "\t" + storeSales[3, 2] + "\t" + dubOverallQ3 + "\n");
            Console.WriteLine("Quarter four: " + "\t" + storeSales[0, 3] + "\t" + storeSales[1, 3] + "\t" + storeSales[2, 3] + "\t" + storeSales[3, 3] + "\t" + dubOverallQ4 + "\n");
            Console.WriteLine("Total: " + "\t\t" + dubTotals1 + "\t" + dubTotals2 + "\t" + dubTotals3 + "\t" + dubTotals4 + "\t" + dubgrandTotal);
            Console.WriteLine("\n");
            Console.WriteLine(" %  Overall: " + "\t" + storeNames[0] + "\t" + storeNames[1] + "\t" + storeNames[2] + "\t" + storeNames[3]);
            Console.WriteLine("\t\t" + Math.Round(dubstore1Percent, 1) + "\t" + Math.Round(dubstore2Percent, 1) + "\t" + Math.Round(dubstore3Percent, 1) + "\t" + Math.Round(dubstore4Percent, 1));
            Console.ReadLine();
        }
    }
}
