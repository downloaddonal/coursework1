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
                   dubStore1Percent, dubStore2Percent, dubStore3Percent, dubStore4Percent,
                   dubGrandTotal;

            // two arrays here, strings and a 2 dimensional one for the figures
            String[] storeNames = new string[4];
            int[,] storeSales = new int[4, 4];

            // for loop to iterate over the needed details

            try
            {
                for (int i = 0; i < storeNames.Length; i++)
                {
                    Console.WriteLine("Please enter the name of Store: ");
                    storeNames[i] = Console.ReadLine();
                    Console.WriteLine("Please enter the quarterly sales for " + storeNames[i] + " please enter the digits in thousands i.e 12,000 as 12 : ");
                    //another for loop instead of copy and pasting the same code for the question 4 times
                    for (int j = 0; j < storeNames.Length; j++)
                    {
                        Console.Write("Please enter the Q" + (j +1) + " sales for " + storeNames[i]);
                        storeSales[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine("\n" + ex.Message + "Please enter a number");
                Console.WriteLine("Program will now close press any key to exit");
                Console.ReadKey();
                return;
            }

            // now to calculate the totals for overal sales
            // per store
            dubTotals1 = storeSales[0, 0] + storeSales[0, 1] + storeSales[0, 2] + storeSales[0, 3];
            dubTotals2 = storeSales[1, 0] + storeSales[1, 1] + storeSales[1, 2] + storeSales[1, 3];
            dubTotals3 = storeSales[2, 0] + storeSales[2, 1] + storeSales[2, 2] + storeSales[2, 3];
            dubTotals4 = storeSales[3, 0] + storeSales[3, 1] + storeSales[3, 2] + storeSales[3, 3];
            dubGrandTotal = dubTotals1 + dubTotals2 + dubTotals3 + dubTotals4;

            // totals
            // all stores
            dubOverallQ1 = storeSales[0, 0] + storeSales[1, 0] + storeSales[2, 0] + storeSales[3, 0];
            dubOverallQ2 = storeSales[0, 1] + storeSales[1, 1] + storeSales[2, 1] + storeSales[3, 1];
            dubOverallQ3 = storeSales[0, 2] + storeSales[1, 2] + storeSales[2, 2] + storeSales[3, 2];
            dubOverallQ4 = storeSales[0, 3] + storeSales[1, 3] + storeSales[2, 3] + storeSales[3, 3];

            // doing the percentage math bit
            dubStore1Percent = dubTotals1 / dubGrandTotal * 100;
            dubStore2Percent = dubTotals2 / dubGrandTotal * 100;
            dubStore3Percent = dubTotals3 / dubGrandTotal * 100;
            dubStore4Percent = dubTotals4 / dubGrandTotal * 100;

            // all variables have been set so we will now display the table
            Console.WriteLine("Sales figures: " + "\t" + storeNames[0] + "\t" + storeNames[1] + "\t" + storeNames[2] + "\t" + storeNames[3] + "\t" + "Overall");
            Console.WriteLine("Quarter one: " + "\t" + storeSales[0, 0] + "\t" + storeSales[1, 0] + "\t" + storeSales[2, 0] + "\t" + storeSales[3, 0] + "\t" + dubOverallQ1);
            Console.WriteLine("Quarter two: " + "\t" + storeSales[0, 1] + "\t" + storeSales[1, 1] + "\t" + storeSales[2, 1] + "\t" + storeSales[3, 1] + "\t" + dubOverallQ2);
            Console.WriteLine("Quarter three: " + "\t" + storeSales[0, 2] + "\t" + storeSales[1, 2] + "\t" + storeSales[2, 2] + "\t" + storeSales[3, 2] + "\t" + dubOverallQ3);
            Console.WriteLine("Quarter four: " + "\t" + storeSales[0, 3] + "\t" + storeSales[1, 3] + "\t" + storeSales[2, 3] + "\t" + storeSales[3, 3] + "\t" + dubOverallQ4);
            Console.WriteLine("Total: " + "\t\t" + dubTotals1 + "\t" + dubTotals2 + "\t" + dubTotals3 + "\t" + dubTotals4 + "\t" + dubGrandTotal);
            Console.WriteLine(" %  Overall: " + "\t" + storeNames[0] + "\t" + storeNames[1] + "\t" + storeNames[2] + "\t" + storeNames[3]);
            Console.WriteLine("\t\t" + Math.Round(dubStore1Percent, 1) + "\t" + Math.Round(dubStore2Percent, 1) + "\t" + Math.Round(dubStore3Percent, 1) + "\t" + Math.Round(dubStore4Percent, 1));
            Console.ReadLine();
        }
    }
}
