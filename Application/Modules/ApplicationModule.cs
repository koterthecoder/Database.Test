using Application.Contracts;
using Application.Contracts.Impl;
using Autofac;
using Persistence.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Modules
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly)
                .AsImplementedInterfaces()
                .InstancePerRequest();

            builder.RegisterModule(new PersistenceModule());

            builder.RegisterType<CarsManagementService>()
                .As<ICarsManagementService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<PostsManagementService>()
                .As<IPostsManagementService>()
                .InstancePerLifetimeScope();


        }
    }
}
