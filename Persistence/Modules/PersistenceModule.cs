using Autofac;
using Domain.Interfaces;
using Domain.Models;
using Persistence.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Modules
{
    public class PersistenceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DomainContext>().AsSelf().InstancePerLifetimeScope();

            builder.RegisterType<CarsRepository>().As<IRepository<Car>>().InstancePerLifetimeScope();
            builder.RegisterType<PostsRepository>().As<IRepository<Post>>().InstancePerLifetimeScope();
        }

    }
}
