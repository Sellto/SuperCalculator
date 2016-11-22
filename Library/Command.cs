using System;
using Computer;

namespace Computer.MyCommand
{
	public abstract class Command : Computer
	{
		public abstract string Name
		{get;}

		public abstract double Execute(string[] input);
	}
}
