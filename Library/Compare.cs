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
	}

	public class min : Command
	{
		public override string Name
		{
			get { return "Minimum"; }
		}
		public override double Execute(string[] input)
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
	}
}
