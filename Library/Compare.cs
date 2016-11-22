using System;

namespace Computer.MyCommand
{
	public class max : Command
	{
		public override string Name
		{
			get { return "Maximum";}
		}
		public override double Execute(string[] input)
		{
			try
			{
				int max = Int32.Parse(input[1]);
				for (int i = 2; i < input.Length; i++)
				{
					if (Int32.Parse(input[i]) > max)
					{
						max = Int32.Parse(input[i]);
					}
				}
				return max;
			}
			catch
			{
				throw new Exception("Check if all of parameters are integer");
			}
		}
	}

	public class min : Command
	{
		public override string Name
		{
			get { return "Minimum"; }
		}
		public override double Execute(string[] input)
		{
			try
			{
				int min = Int32.Parse(input[1]);
				for (int i = 2; i < input.Length; i++)
				{
					if (Int32.Parse(input[i]) < min)
					{
						min = Int32.Parse(input[i]);
					}
				}
				return min;
			}
			catch
			{
				throw new Exception("Check if all of parameters are integer");
			}
		}
	}
}
