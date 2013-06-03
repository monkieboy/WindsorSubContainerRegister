using System;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace WindsorSubContainerRegisterApplicationHarness
{
	class Program
	{
	    static void Main(string[] args)
		{
	        var windsorRegister = new WindsorRegister();
	        windsorRegister.Register();
            var m = windsorRegister.WindsorContainer.Resolve<IPrintManager>();
            m.Initiate();
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
	}
}
