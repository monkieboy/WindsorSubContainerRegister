using System;

namespace WindsorSubContainerRegisterApplicationHarness
{
    public class PrintManager : IPrintManager
    {
        private readonly IGreeter greeter;

        public PrintManager(IGreeter greeter)
        {
            this.greeter = greeter;
        }

        public void Initiate()
        {
            Console.WriteLine(greeter.Greet());
        }
    }
}