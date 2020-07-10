using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using SICOFDataAccess.Infraestructure;
using SICOFDataAccess.Infraestructure.RepositoryEntities.IRepository;
using SICOFDataAccess.Infraestructure.RepositoryEntities.Repository;
using SICOFBusiness.Interface;
using SICOFBusiness.Business;
using SICOFDataAccess.Interface;
using SICOFDataAccess.ModuleDataAccess;

namespace SICOFBusiness
{
    public static class DependencyInjection
    {


        public static IServiceCollection AddDbContextBusiness(this IServiceCollection services, string connectionString)
        {
          
            services.AddDbContext<DataBaseContext>(
                options => options.UseSqlServer(connectionString, x => x.MigrationsAssembly("SICOFAPI")));
            return services;
        }

        public static IServiceCollection AddInfrastructureBusiness(this IServiceCollection services)
        {
            // Business
            services.AddTransient<IGestionVersionBusiness, GestionVersionBusiness>();           
            
            
            //DataAccess
            services.AddTransient<IGestionVersionDataAccess, GestionVersionDataAccess>();


            //Entities
            services.AddTransient<IVersionRepository, VersionRepository>();
            
            return services;
        }
    }
}
