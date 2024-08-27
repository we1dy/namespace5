using System;

namespace Program
{
	class Program
	{
		public static void Main(string[] args)
		{
			int p, lastInt = 0, input;
			Console.WriteLine("Enter the Number of Rows: ");
			input = int.Parse(Console.ReadLine());

			for (int i = 1; i <= input; i++)
			{
				for (p = 1; p <= i; p++)
				{
					if (lastInt == 1)
					{
						Console.Write("0");
						lastInt = 0;
					}
					else
					{
						Console.Write("1");
						lastInt = 1;
					}
				}
				Console.Write("\n");
			}

			Console.ReadLine();
		}
	}
}
