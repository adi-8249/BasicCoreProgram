﻿using System;

namespace BasicCodeProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("1:flip coin percentage");
            Console.WriteLine("2:Leapyear program");
            Console.WriteLine("3:poweroftwo program");
            Console.WriteLine("4:Harmonic number");
            Console.WriteLine("5:Primefactor");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    FlipCoinProgram flipcoin = new FlipCoinProgram();
                    flipcoin.FlipCoinPercentage();
                    break;
                case 2:
                    LeapYearProgram leapyear = new LeapYearProgram();
                    leapyear.LeapYear();
                    break;
                case 3:
                    PowerOfTwo poweroftwo = new PowerOfTwo();
                    PowerOfTwo powerOfTwo = new PowerOfTwo();
                    Console.WriteLine("Enter the number to check its 2's power=");
                    int input = Convert.ToInt32(Console.ReadLine());
                    int result = powerOfTwo.PowerOfTwoResult(input);
                    Console.WriteLine("result is=" + result);
                    break;
                case 4:
                    HarmonicNumber harmonicnumber = new HarmonicNumber();
                    harmonicnumber.HarmonicNumberProgram();
                    break;
                case 5:
                    FactorProgram factor = new FactorProgram();
                    factor.PrimeFactor();
                    break;

            }
           
        }
    }
}
