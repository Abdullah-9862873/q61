using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	//Question 61
	internal class Program
	{
		static void Main(string[] args)
		{
			int a, b, c, d, e;
			a = 10; b = 20; c = 15; d = 8; e = 40;

			{
				//Part1

				int f = (a + b / (c - 5)) / ((d + 7) / (e - 37) % 3);
				Console.WriteLine(f);
				Console.ReadLine();
			}
			{
				//Part 2
				int f = a + b / c - 5 / d + 7 / e - 37 % 3;
				Console.WriteLine(f);
				Console.ReadLine();
			}
			{
				//Part 3
				int f = a * (b * b) - (c * b) + d;
				Console.WriteLine(f);
				Console.ReadLine();
			}
		}
	}
}