﻿using System;
using System.Collections.Generic;

namespace Lab3App
{
  public class Program
  {
    public static void Main()
    {
      //string input = C1GetProductInput();
      //ChallengeOne(input);

      //string second = C2GetSecondInput();
      //double[] choices = C2Choices(second);
      //ChallengeTwo(choices);

      //C3PrintDesign();

      int[] nums = { 4, 5, 8, 4, 8, 6, 9, 9, 9 };
      int c4Result = C4MostFrequentNumber(nums);
      Console.WriteLine($"The number that appears the most is: {c4Result}!");
    }

    public static string C1GetProductInput()
    {
      string result = "foo";

      Console.WriteLine("Hello, please enter 3 numbers, each separated by a space.");

      string? userInput = Console.ReadLine();

      if (userInput != null)
      {
        result = userInput;
      }

      return result;
    }

    public static int ChallengeOne(string input)
    {
      int product = 1;

      if (input != null)
      {
        string[] numbers = input.Split(' ');

        int n = numbers.Length;

        if (n == 3)
        {
          int[] nums = Array.ConvertAll(numbers, int.Parse);

          foreach (int num in nums)
          {
            product *= num;
          }

          Console.WriteLine("The product of your numbers is: " + product);

          Console.WriteLine("Thanks, Bye!");
        }
        else
        {

          throw new ArgumentException("Please enter 3 numbers.");
        }
      }
      else { throw new ArgumentException("User Input was null."); }

      return product;
    }

    public static string C2GetSecondInput()
    {
      string result = "foo";

      Console.WriteLine("Hello, enter a number between 2 and 10.");

      string? userInput = Console.ReadLine();

      if (userInput != null)
      {
        result = userInput;
      }

      return result;

    }

    public static double[] C2Choices(string numR)
    {
      int rounds = int.Parse(numR);
      double[] numbers = new double[rounds];

      for (int i = 0; i < rounds; i++)
      {
        Console.WriteLine("Enter a number: ");

        string? entry = Console.ReadLine();

        if (entry != null)
        {
          try
          {
            double num = double.Parse(entry);

            while (num < 0)
            {
              Console.WriteLine("Number must be positive. Enter a positive number: ");

              string? redo = Console.ReadLine();

              if (redo != null)
              {
                num = double.Parse(redo);
              }
            }
            numbers[i] = num;
          }
          catch (FormatException ex)
          {
            Console.WriteLine("Please enter a positive number.", ex.Message);
          }
        }
        else { throw new ArgumentException("User input was null."); }
      }
      return numbers;
    }

    public static double ChallengeTwo(double[] numbers)
    {
      double average = 0;

      double sum = 0;

      double rounds = numbers.Length;

      foreach (double num in numbers)
      {
        sum += num;
      }

      average = sum / rounds;

      Console.WriteLine("The average of the numbers is: " + average);

      return average;
    }

    public static bool C2AreNumbersPositive(double[] numbers)
    {
      foreach (double num in numbers)
      {
        if (num < 0)
        {
          return false;
        }
      }
      return true;
    }

    public static void C3PrintDesign()
    {
      int size = 9;
      for (int i = 0; i < size; i++)
      {
        // Calculate number of spaces and asterisks to print
        int spaces = Math.Abs(i - size / 2);
        int asterisks = size - 2 * spaces;

        // Print spaces
        for (int j = 0; j < spaces; j++)
        {
          Console.Write(" ");
        }

        // Print asterisks
        for (int j = 0; j < asterisks; j++)
        {
          Console.Write("*");
        }

        Console.WriteLine();
      }
    }

    static Dictionary<int, int> ArrayToDictionary(int[] numbers)
    {
      var dictionary = new Dictionary<int, int>();

      foreach (int num in numbers)
      {
        dictionary[num] = num;
      }
      return dictionary;
    }

    public static int C4MostFrequentNumber(int[] numbers)
    {
      //Use a dictionary to count the frequency of each number
      Dictionary<int, int> frequencyCount = new Dictionary<int, int>();

      //Iterate through array, check for number dictionary
      //Count it once if it's not there
      foreach (int number in numbers)
      {
        if (frequencyCount.ContainsKey(number))
        {
          frequencyCount[number]++;
        }
        else
        {
          frequencyCount[number] = 1;
        }
      }
 
      int mostFrequentNumber = 0;
      int highestFrequency = 0;

      foreach (KeyValuePair<int, int> entry in frequencyCount)
      {
        if (entry.Value > highestFrequency)
        {
          mostFrequentNumber = entry.Key;
          highestFrequency = entry.Value;
        }
      }

      return mostFrequentNumber;
    }
  }
}

