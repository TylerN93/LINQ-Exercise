using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace LINQ

{
    public class Program
    {
        static void Main(string[] args)
        {
            var games = new List <string> () { "Madden", "NBA", "Call Of Duty", "Fortnight" };

            //var order = games.OrderBy();

            games = games.OrderBy(g => g.Length).ToList();

            for (int i = 0; i< games.Count; i++)

            {
                Console.WriteLine($"{games[i]}");
            }
            
        }
    }
}
