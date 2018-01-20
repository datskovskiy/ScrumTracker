﻿using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using BusinessLayer;
using BusinessLayer.Contracts.Interfaces;

namespace WebSite.Util
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);


            builder.RegisterType<ManagerDepartament>().As<IManagerDepartament>().InstancePerLifetimeScope();
            builder.RegisterType<ManagerTeam>().As<IManagerTeam>().InstancePerLifetimeScope();
            builder.RegisterType<ManagerUserTeamPos>().As<IManagerUserTeamPos>().InstancePerLifetimeScope();
            builder.RegisterType<ManagerUser>().As<IManagerUser>().InstancePerLifetimeScope();
            builder.RegisterType<ManagerProject>().As<IManagerProject>().InstancePerLifetimeScope();
            builder.RegisterType<ManagerPosition>().As<IManagerPosition>().InstancePerLifetimeScope();
            builder.RegisterType<ManagerIssue>().As<IManagerIssue>().InstancePerLifetimeScope();
            builder.RegisterType<ManagerSprint>().As<IManagerSprint>().InstancePerLifetimeScope();
            builder.RegisterType<ManagerIssue>().As<IManagerIssue>().InstancePerLifetimeScope();
            builder.RegisterType<ManagerComment>().As<IManagerComment>().InstancePerLifetimeScope();
            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}