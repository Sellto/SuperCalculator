using System;

namespace MyCommand
{
	class sin : Command
	{
		private string input;
		public sin(string input)
		{
			this.input = input; 
		}

		public override string Execute()
		{
			double result = Math.Sin(Int32.Parse(input) * Math.PI / 180.0);
			return result.ToString();
		}

	}
}


namespace MyCommand
{
	class cos : Command
	{
		private string input;
		public cos(string input)
		{
			this.input = input;
		}

		public override string Execute()
		{
			double result = Math.Cos(Int32.Parse(input) * Math.PI / 180.0);
			return result.ToString();
		}

	}
}
