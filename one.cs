using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DepartmentStore3
{
    public class DepartmentStore
    {
        static int Main(string[] args)
        {
            long ItemID = 0;
            string Description = "Unknown";
            double Price = 0.00D;

            // Each of the following variable
            // arrays is structured as [2][2][4].
            // Each variable represents:
            // A/ Two major lists: The first major
            //    list represents women items,
            //	  the second major list represents men items,
            // B/ Two minor lists.
            //    Each of the major lists contains two minor lists:
            //	  a/ The first minor list of the first major
            //       list contains adult women items
            //	     The second minor list of the first major
            //       list contains girls items
            //	  b/ The first minor list of the second major
            //       list contains adult men items
            //	     The second minor list of the
            //       second major list contains boys items
            // C/ Each minor list contains four items

            long[][][] ItemNumber = new long[][][]
            {
                new long[][]
                {
                    new long[]{947783, 934687, 973947, 987598, 974937},
                    new long[]{743765, 747635, 765473, 754026, 730302}
                },
                new long[][]
                {
                    new long[]{209579, 267583, 248937, 276057, 267945},
                    new long[]{ 409579, 467583, 448937, 476057, 467945}
                }
            };

            string[][][] ItemName = new string[][][]
            {
                new string[][]
                {
                    new string[]
                    {  
                        "Double-faced wool coat",
                        "Floral Silk Tank Blouse",
                        "Push Up Bra",
                        "Chiffon Blouse",
                        "Bow Belt Skirtsuit"
                    },
                    new string[]
                    {
                        "Cable-knit Sweater",
                        "Jeans with Heart Belt",
                        "Fashionable mini skirt",
                        "Double Dry Pants",
                        "Romantic Flower Dress"
                    }
                },
                new string[][]
                {
                    new string[]
                    {
                        "Cotton Polo Shirt",
                        "Pure Wool Cap",
                        "Striped Cotton Shirt",
                        "Two-Toned Ribbed Crewneck",
                        "Chestnut Italian Shoes"
                    },
                    new string[]
                    {
                        "Under Collar and Placket Jacket",
                        "Country Coat Rugged Wear",
                        "Carpenter Jeans",
                        "Double-Cushion Tennis Shoes",
                        "Stitched Center-Bar Belt"
                    }
                }
            };

            double[][][] UnitPrice = new double[2][][]
            {
                new double[][]
                {
                    new double[]
                    { 275.25, 180.00, 50.00, 265.00, 245.55 },
                    new double[]
                    { 45.55, 25.65, 34.55, 28.55, 24.95 }
                },
                new double[][]
                {
                    new double[]
                    { 45.75, 25.00, 65.55, 9.75, 165.75 },
                    new double[]
                    { 265.15, 35.55, 24.95, 48.75, 32.50 }
                }
            };

            Console.Title = "Fun Department Store";

            Console.Clear();

            Console.WriteLine("|==============================");
            Console.WriteLine("|Fun Department Store");
            Console.WriteLine("|==============================");
            Console.WriteLine("|Receipt");
            Console.WriteLine("|------------------------------");
            Console.WriteLine("|Item Number: {0}", ItemNumber[1][1][1]);
            Console.WriteLine("|Description: {0}", ItemName[1][1][1]);
            Console.WriteLine("|Unit Price:  {0:C}", UnitPrice[1][1][1]);
            Console.WriteLine("|==============================");

            Console.ReadKey();
            return 0;
        }
    }
}
