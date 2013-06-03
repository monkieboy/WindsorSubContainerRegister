using System;
using Castle.Windsor;

namespace WindsorSubContainerRegister
{
    public class SubContainerRegister : ISubContainerRegister
    {
		public IWindsorContainer AppContainer { get; private set; }

        public void Wrap(IWindsorRegister windsorRegister)
	    {
	        AppContainer = windsorRegister.WindsorContainer;
	    }
	}
}
