﻿using System;

namespace ChristmasWithTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmas = new Christmas();

            var xmasDay = Christmas.Day.Thu;        //Changed this to the style of day names I put into the enum

            //DONE - TODO set Santa's name to Kris Kringle
            xmas.Santa = "Kris Kringle";

            //DONE - TODO Insert 3 presents you would like for xmas.  They must be strings
            xmas.Presents =  new string[3]{"Hot Wheels", "Hiking Boots", "Switch game" }; 

            //DONE - TODO Set the TreeHeight to 10
            xmas.TreeHeight = 10;

            Console.WriteLine($"This year christmas falls on {xmasDay} \n");
            Console.WriteLine($"Our tree will be {xmas.TreeHeight} feet high \n");
            Console.WriteLine("Here are the presents we would like:");

            foreach (var present in xmas.Presents)
            {
                Console.WriteLine($"    {present}");
            }

            Console.WriteLine($"\n We like to call Santa, {xmas.Santa}");
        }
    }
}
