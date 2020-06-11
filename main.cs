using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter a number");
    string x = Console.ReadLine();
    Console.WriteLine ("Enter another number");
    string y = Console.ReadLine();
    int x1 = Convert.ToInt32(x);
    int y1 = Convert.ToInt32(y);
    Console.WriteLine ("Sum: " + (x1+y1));
    Console.WriteLine ("Difference: " + (x1-y1));
    Console.WriteLine ("Product: " + (x1*y1));
    Console.WriteLine ("Quotient: " + (x1/y1));
    Console.WriteLine ("Remainder: " + (x1%y1));




  }
}