﻿using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int max = 0;
        int min = 0;

        Console.Write("Enter first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            max = firstNumber;
            min = secondNumber;
        }
        else
        {
            max = secondNumber;
            min = firstNumber;
        }
        Console.WriteLine("max = " + max + " и " + "min = " + min);

    }
}