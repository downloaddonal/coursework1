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
                dubstore1percent, dubstore2percent, dubstore3percent, dubstore4percent,
                dubgrandtotal;

            // two arrays here, strings and a 2 dimensional one for the figures
            String[] Storenames = new string[4];
            int[,] StoreSales = new int[4, 4];

            // for loop to iterate over the needed details
            for (int i = 0; i < Storenames.Length; i++)
            {
                Console.Write("\nPlease enter the name of Store: ");
                Storenames[i] = Console.ReadLine();
                Console.Write("Please enter the quarterly sales for " + Storenames[i] + " please enter the digits in thousands i.e 12,000 as 12 :\n");
                Console.Write("Please enter the Q1 sales for " + Storenames[i] + "\n");
                StoreSales[i, 0] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the Q2 sales for " + Storenames[i] + "\n");
                StoreSales[i, 1] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the Q3 sales for " + Storenames[i] + "\n");
                StoreSales[i, 2] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the Q4 sales for " + Storenames[i] + "\n");
                StoreSales[i, 3] = Convert.ToInt32(Console.ReadLine());
            }

            // now to calculate the totals for overal sales
            // per store

            dubTotals1 = StoreSales[0, 0] + StoreSales[0, 1] + StoreSales[0, 2] + StoreSales[0, 3];
            dubTotals2 = StoreSales[1, 0] + StoreSales[1, 1] + StoreSales[1, 2] + StoreSales[1, 3];
            dubTotals3 = StoreSales[2, 0] + StoreSales[2, 1] + StoreSales[2, 2] + StoreSales[2, 3];
            dubTotals4 = StoreSales[3, 0] + StoreSales[3, 1] + StoreSales[3, 2] + StoreSales[3, 3];
            dubgrandtotal = dubTotals1 + dubTotals2 + dubTotals3 + dubTotals4;

            // totals
            // all stores
            dubOverallQ1 = StoreSales[0, 0] + StoreSales[1, 0] + StoreSales[2, 0] + StoreSales[3, 0];
            dubOverallQ2 = StoreSales[0, 1] + StoreSales[1, 1] + StoreSales[2, 1] + StoreSales[3, 1];
            dubOverallQ3 = StoreSales[0, 2] + StoreSales[1, 2] + StoreSales[2, 2] + StoreSales[3, 2];
            dubOverallQ4 = StoreSales[0, 3] + StoreSales[1, 3] + StoreSales[2, 3] + StoreSales[3, 3];

            // doing the percentage math bit

            dubstore1percent = (dubTotals1 / dubgrandtotal) * 100;
            dubstore2percent = (dubTotals2 / dubgrandtotal) * 100;
            dubstore3percent = (dubTotals3 / dubgrandtotal) * 100;
            dubstore4percent = (dubTotals4 / dubgrandtotal) * 100;

            // all variables have been set so we will now display the table

            Console.WriteLine("\n");
            Console.WriteLine("Sales figures: " + "\t" + Storenames[0] + "\t" + Storenames[1] + "\t" + Storenames[2] + "\t" + Storenames[3] + "\t" + "Overall" + "\n");
            Console.WriteLine("Quarter one: " + "\t" + StoreSales[0, 0] + "\t" + StoreSales[1, 0] + "\t" + StoreSales[2, 0] + "\t" + StoreSales[3, 0] + "\t" + dubOverallQ1 + "\n");
            Console.WriteLine("Quarter two: " + "\t" + StoreSales[0, 1] + "\t" + StoreSales[1, 1] + "\t" + StoreSales[2, 1] + "\t" + StoreSales[3, 1] + "\t" + dubOverallQ2 + "\n");
            Console.WriteLine("Quarter three: " + "\t" + StoreSales[0, 2] + "\t" + StoreSales[1, 2] + "\t" + StoreSales[2, 2] + "\t" + StoreSales[3, 2] + "\t" + dubOverallQ3 + "\n");
            Console.WriteLine("Quarter four: " + "\t" + StoreSales[0, 3] + "\t" + StoreSales[1, 3] + "\t" + StoreSales[2, 3] + "\t" + StoreSales[3, 3] + "\t" + dubOverallQ4 + "\n");
            Console.WriteLine("Total: " + "\t\t" + dubTotals1 + "\t" + dubTotals2 + "\t" + dubTotals3 + "\t" + dubTotals4 + "\t" + dubgrandtotal);
            Console.WriteLine("\n");
            Console.WriteLine(" %  Overall: " + "\t" + Storenames[0] + "\t" + Storenames[1] + "\t" + Storenames[2] + "\t" + Storenames[3]);
            Console.WriteLine("\t\t" + Math.Round(dubstore1percent, 1) + "\t" + Math.Round(dubstore2percent, 1) + "\t" + Math.Round(dubstore3percent, 1) + "\t" + Math.Round(dubstore4percent, 1));
            Console.ReadLine();
        }
    }
}

