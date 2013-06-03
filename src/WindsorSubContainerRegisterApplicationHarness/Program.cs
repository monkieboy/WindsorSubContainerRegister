using System;
using Castle.Windsor;

namespace WindsorSubContainerRegisterApplicationHarness
{
	class Program
	{
		static void Main(string[] args)
		{
			Register();
			ConsoleKeyInfo key;
			Console.WriteLine("press 'Q' to quit....");
			do
			{
				key = Console.ReadKey();
				if ( key.KeyChar == 'Q' || key.KeyChar == 'q' )
				{
					break;
				}
			} while ( true );
		}

		private static void Register()
		{
			IWindsorContainer windsorContainer = new WindsorContainer();
		}
	}
}
