using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyrell.Heart.Tests
{
    public class TestBase
    {
        protected IContainer Container { get; private set; }

        public TestBase()
        {
            this.Container = Tyrell.Heart.Tests.Container.Register();
        }
    }
}
