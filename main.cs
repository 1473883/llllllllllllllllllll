using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main()
    {
      //create array for months of the year
      string[] months = new string[12] 
      {"Jan", "Feb", "March", "April", "May", "June", "July", "August", "September", 
      "October", "November", "December"};

      //initialise prng with a time-dependent default seed value
      Random rnd = new Random();

      // will create a number between 1 and 12
      int month = rnd.Next (1, 13);

      //output the random month name 
      Console.WriteLine("Month is {0}", months[month-1]);

      //create array for day in the momth
      string[] days = new string[30]
      {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", 
      "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"};

      //intialise prng with a time dependent seed value
      Random jnd = new Random();

      // will create a number between 1 and 30
      int day = jnd.Next (1, 31);

      //output the random day number
      Console.WriteLine("Day is {0}", days[day-1]);
      RangeTest();
    }

  public static void RangeTest() {
    IEnumerable<int> squares = Enumerable.Range (1, 10).Select(x => x * x);

    foreach (int num in squares)
    {
      Console.WriteLine(num);
    }

    /*
     this code produces the following output:
     1
     4
     9
     16
     25
     36
     49
     64
     81
     100
     */
  }
}