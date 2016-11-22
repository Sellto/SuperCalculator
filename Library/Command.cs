using System;
using Computer;

namespace Computer.MyCommand
{
	public abstract class Command : Computer
	{
		public abstract string Name
		{get;}

		public virtual double Execute(string[] input)
		{
			throw new Exception("This Command exist but not action are implemented");
		}
	}
}
