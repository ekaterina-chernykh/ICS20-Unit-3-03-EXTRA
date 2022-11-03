// Created by: Ekaterina
// Created on: Oct 2022
//
// This program calculates volume of a sphere

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double radius;
        double volume;

        Console.WriteLine("This program calculates the volume of sphere");
        Console.WriteLine(" ");

        Console.WriteLine("Formula: V = 4/3πr³ ");
        Console.WriteLine(" ");
        Console.Write("Enter radius: ");
        radius = Convert.ToDouble(Console.ReadLine());

        volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);

        Console.WriteLine(" ");
        Console.WriteLine("Your volume will be: " + volume.ToString("0.00") + " units³");

        Console.WriteLine("\nDone.");
    }
}