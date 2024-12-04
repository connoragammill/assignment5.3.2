using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment5._3._2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());
			int howManyWays = ClimbStairs(n);//This calls the 'ClimbStairs()' method
			Console.WriteLine(howManyWays);

		}
		static int ClimbStairs(int n)
		{
			if (n == 0 || n == 1)//Handles the cases where 'n' is '0' or '1'
			{
				return 1;
			}

			int[] waysToClimb = new int[n + 1];//Creates an array to store the number of ways to reach each step
			waysToClimb[0] = 1;//Initializes the base in the if statement for '0'
			waysToClimb[1] = 1;//Initializes the base in the if statement for '1'

			for (int i = 2; i <= n; i++)
			{
				waysToClimb[i] = waysToClimb[i - 1] + waysToClimb[i - 2];
			}

			return waysToClimb[n];//This will return how many ways or combinations of steps for 'n', the number the user inputs
		}
	}
}
