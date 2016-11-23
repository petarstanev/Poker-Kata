// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Linq;
using Poker.Properties;

namespace Poker
{
    /// <summary>The program.</summary>
    public class Program
    {
        /// <summary>The main.</summary>
        /// <param name="args">The args.</param>
        public static void Main(string[] args)
        {
            var games = Resources.poker.Split(new[] {"\n", "\r\n"}, StringSplitOptions.RemoveEmptyEntries).ToList();

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            // Score the games here and find out how many player 1 won
            var scorer = new PokerScorer();
            var result = 0;
            
            stopwatch.Stop();
            
            Console.WriteLine(string.Format("Player 1 won {0} games. Calculation took {1}s", result, stopwatch.Elapsed.TotalSeconds));

            Console.ReadLine();
        }
    }
}