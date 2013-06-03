using System;
using Castle.Windsor;

namespace WindsorSubContainerRegister
{
    public interface ISubContainerRegister
    {
        IWindsorContainer AppContainer { get; }
        void Wrap(IWindsorRegister windsorRegister);
    }
}