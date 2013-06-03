using System;
using System.Globalization;
using System.Reflection;
using FluentAssertions;
using NUnit.Framework;
using WindsorSubContainerRegisterApplicationHarness;
using System.Linq;

namespace WindsorSubContainerRegister.Tests
{
	[TestFixture]
	public class SubContainerRegisterWindsorContainer
	{
	    private SubContainerRegister register;

	    [SetUp]
		public void SetUp()
		{
            register = new SubContainerRegister();

	        var reg = (IWindsorRegister)Activator.CreateInstance(typeof(WindsorRegister));
            register.Wrap(reg);
		}

        [Test]
        public void TestingSomething()
        {
            register.AppContainer.Should().NotBeNull();
        }
	}
}
