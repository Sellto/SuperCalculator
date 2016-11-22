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
			var angle = new int();
			try
			{
				angle = Int32.Parse(input[1]);
			}
			catch
			{
				throw new Exception("Angle in sin command must be a integer");
			}
			return Math.Round(Math.Sin(angle * Math.PI / 180), 2);
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
			var angle = new int();
			try
			{
				angle = Int32.Parse(input[1]);
			}
			catch
			{
				throw new Exception("Angle in cos command must be a integer");
			}
			return Math.Round(Math.Cos(angle * Math.PI / 180), 2);
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
			var angle = new int();
			try
			{
				angle = Int32.Parse(input[1]);
			}
			catch
			{
				throw new Exception("Angle in tan command must be a integer");
			}
			return Math.Round(Math.Tan(angle * Math.PI / 180), 2);
		}

	}

	class cotan : Command
	{
		public override string Name
		{
			get { return "Cotangent"; }
		}
	}
}
