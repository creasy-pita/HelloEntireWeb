using Autofac;
using Autofac.Configuration;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloEntireWeb
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //// The generic ILogger<TCategoryName> service was added to the ServiceCollection by ASP.NET Core.
            //// It was then registered with Autofac using the Populate method in ConfigureServices.
            //builder.Register(c => new ValuesService(c.Resolve<ILogger<ValuesService>>()))
            //    .As<IValuesService>()
            //    .InstancePerLifetimeScope();
        }

    }
}
