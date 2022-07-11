using System;
using System.Collections.Generic;
// using PingPong.Models;

namespace  PingPong
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a number: ");
      string stringNum = Console.ReadLine();
      int num = int.Parse(stringNum);
      List<string> pingPongList = new List<string>(0);

      for (int index = 1; index <= num; index++)  
      {
        if (index % 3 == 0 && index % 5 == 0)
        {
          pingPongList.Add("ping-pong");
        }
        else if (index % 3 == 0)
        {
          pingPongList.Add("ping");
        }
        else if (index % 5 == 0)
        {
          pingPongList.Add("pong");
        }
        else
        {
          pingPongList.Add(Convert.ToString(index));
        }
        Console.WriteLine(pingPongList[(index-1)]);
      }
    }
  }
}