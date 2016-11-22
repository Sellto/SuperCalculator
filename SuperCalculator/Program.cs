using System;
using System.Reflection;

namespace SuperCalculator
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			try
			{
				Assembly myLib = Assembly.LoadFrom("../../Library.dll");
				bool escape = false;
				while (!escape)
				{
					Console.Write(">>> ");
					string input = Console.ReadLine();
					if (input != "quit")
					{
						var whitespace = new char[] { ' ', '\t' };
						string[] input_element = input.Split(whitespace);
						try
						{
							Type type = myLib.GetType("Computer.MyCommand." + input_element[0]);
							Object command = Activator.CreateInstance(type, new Object[]{});
							try
							{
								var output = (double)type.InvokeMember("Execute", BindingFlags.InvokeMethod, null, command, new Object[] { input_element });
								Console.WriteLine(" = " + output);
							}
							catch (Exception e)
							{
								Console.ForegroundColor = ConsoleColor.Red;
								e = e.InnerException;
								Console.WriteLine("\n"+e.Message+"\n");
								Console.ResetColor();
							}

						}
						catch
						{
							Console.WriteLine("Invalid Command");
						}
					}
					else
					{
						escape = true;
					}
				}
			}
			catch
			{
				Console.WriteLine("-- Can't Load Library.dll file --");
			}
		}

		public static void Help(Assembly assembly)
		{ 
			foreach (Type type in assembly.GetTypes())
			{
				Console.WriteLine(" - " + type);

			}
		}
	}
}



