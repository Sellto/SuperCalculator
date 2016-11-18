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
				//ShowLibrary(myLib);
				bool escape = false;
				while (!escape)
				{
					Console.Write(">>> ");
					string input = Console.ReadLine();
					if (input != "quit")
					{
						char[] whitespace = new char[] { ' ', '\t' };
						string[] input_element = input.Split(whitespace);
						try
						{
							Type type = myLib.GetType("MyCommand." + input_element[0]);
							Object command = Activator.CreateInstance(type, new Object[] {input_element[1]});
							string output = (string)type.InvokeMember("Execute", BindingFlags.InvokeMethod, null, command, new Object[] { });
							Console.WriteLine(" = " + output);
						}
						catch
						{
							Console.WriteLine("Command Not Found");
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

		public static void ShowLibrary(Assembly assembly)
		{ 
			Console.WriteLine("Commande disponible :");
			foreach (Type type in assembly.GetTypes())
			{
				Console.WriteLine(" - " + type);
				foreach (MemberInfo member in type.GetMembers())
				{
					Console.WriteLine(" ----- " + member.Name);
				}

			}
		}
	}
}



