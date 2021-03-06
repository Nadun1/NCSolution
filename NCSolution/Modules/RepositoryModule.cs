﻿using Autofac;
using NCSolution.BussinessLayer.Contracts;
using NCSolution.BussinessLayer.Interface;
using NCSolution.DataAccessLayer;
using NCSolution.DataAccessLayer.Common;
using NCSolution.DataAccessLayer.Interface;
using NCSolution.DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;

namespace NCSolution.Modules
{

    public class RepositoryModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof(NCSolutionDbContext)).As(typeof(DbContext)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork)).InstancePerRequest();

            builder.RegisterType(typeof(LoginUserRepository)).As(typeof(ILoginUserRepository)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(LoginUserService)).As(typeof(ILoginUserService)).InstancePerLifetimeScope();

            builder.RegisterType(typeof(ExamRepository)).As(typeof(IExamRepository)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(ExamService)).As(typeof(IExamService)).InstancePerLifetimeScope();








        }
    }
}