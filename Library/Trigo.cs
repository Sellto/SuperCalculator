using System;

namespace Computer.MyCommand
{
	class sin : Command
	{
		public override string Name
		{
			get { return "Sinus";}
		}
		public override double Execute(string[] input)
		{
			return Math.Round(Math.Sin(Int32.Parse(input[1]) * Math.PI / 180), 2) ;
		}

	}

	class cos : Command
	{
		public override string Name
		{
			get { return "Cosinus"; }
		}
		public override double Execute(string[] input)
		{
			return Math.Round(Math.Cos(Int32.Parse(input[1]) * Math.PI / 180), 2);
		}

	}

	class tan : Command
	{
		public override string Name
		{
			get { return "Tangent"; }
		}
		public override double Execute(string[] input)
		{
			return Math.Round(Math.Tan(Int32.Parse(input[1]) * Math.PI / 180), 2);
		}

	}
}
