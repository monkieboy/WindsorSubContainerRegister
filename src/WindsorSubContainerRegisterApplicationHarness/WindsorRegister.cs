using Castle.MicroKernel.Registration;
using Castle.Windsor;
using WindsorSubContainerRegister;

namespace WindsorSubContainerRegisterApplicationHarness
{
    public class WindsorRegister : IWindsorRegister
    {
        public IWindsorContainer WindsorContainer { get; set; }

        public void Register()
        {
            WindsorContainer = new WindsorContainer();
            WindsorContainer.Register(Component.For<IPrintManager>().ImplementedBy<PrintManager>().LifeStyle.Transient);
            WindsorContainer.Register(Component.For<IGreeter>().ImplementedBy<Greeter>().LifeStyle.Transient);
        }
    }
}