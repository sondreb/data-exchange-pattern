using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyrell.Heart.Models;

namespace Tyrell.Heart.Tests
{
    public class Container
    {
        public static IContainer Register()
        {
            var builder = new ContainerBuilder();

            // This will register Logger and other framework types.
            //FrameworkContainer.RegisterFrameworkTypes(builder);

            builder.RegisterType<Aorta>();

            var container = builder.Build();

            return container;
        }
    }
}
