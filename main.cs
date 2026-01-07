// have this at the start of every program
using System;
using System.Reflection.Metadata;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!"); 
      Console.ReadLine("enter your name: ");
      int age = Convert.ToInt16(Console.ReadLine()); //if you want to input a number this is the sintax >:( 
      int mynum = (age > 5) ? 6 : (age < 3) ? 8 : 9;
    }
  }
}