using Castle.Windsor;

namespace WindsorSubContainerRegister
{
    public interface IWindsorRegister
    {
        void Register();
        IWindsorContainer WindsorContainer { get; set; }
    }
}