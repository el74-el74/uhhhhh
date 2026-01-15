// have this at the start of every program
using System;
using System.Reflection.Metadata;
using Maths = System.Math;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Console.Write("enter your name: "); 
      string name = Console.ReadLine();
      Console.Write("enter your age: ");
      int age = Convert.ToInt16(Console.ReadLine()); //if you want to input a number this is the sintax >:( 
      int mynum = (age > 5) ? 6 : (age < 3) ? 8 : 9;
      Console.WriteLine(Maths.Max(5, 10));
      Console.WriteLine(Maths.Min(5, 10));
      Console.WriteLine(name[1]); //outputs second character of name
      string uh = "fdhudtruh";
      Console.WriteLine(uh.IndexOf("d")); //outputs location of letter
      
    }
  }
}