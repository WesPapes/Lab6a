using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Convert Celcius to Fahrenheit Program");
    double[] celcius = new double[7];
    Console.WriteLine("Enter 7 Celcius Temperatures");

    for (int i = 0; i<7; i++)
    {
      celcius[i] = Convert.ToDouble(Console.ReadLine());
    }
    Console.WriteLine("The values you entered are");

    for (int i = 0; i<7; i++)
    {
      Console.WriteLine("{0}", celcius[i]);
    }
    double[] fahrenheit = new double[7];

    for (int i = 0; i<7; i++)
    {
      fahrenheit[i] = celcius[i];
      fahrenheit[i] = celcius[i]* 9/5 + 32;
    }
    Console.WriteLine("Temperature in Fahrenheit-sorted in descending order");
    Array.Sort(fahrenheit);
    Array.Reverse(fahrenheit);

    for (int i = 0; i<7; i++)
    {
      Console.WriteLine("{0}", fahrenheit[i]);
    }
    double sum = fahrenheit.Sum();
    int length = fahrenheit.Length;
    double avg = sum / length;
    Console.WriteLine ("Average weekly temperature is " + avg + " degrees Fahrenheit");
    }
  }