using eShopSolution.Ultilities.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace eShopSolution.Data.EF
{
    class EShopSolutionDbContextFactory : IDesignTimeDbContextFactory<EShopDbContext>
    {
        public EShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory()) // requires Microsoft.Extensions.Configuration.Json
                    .AddJsonFile("appsettings.json") // requires Microsoft.Extensions.Configuration.Json
                    .Build(); // requires Microsoft.Extensions.Configuration.EnvironmentVariables

            var connectionStrings = configuration.GetConnectionString(SystemConstants.MainConnectionString);
            var optionsBuilder = new DbContextOptionsBuilder<EShopDbContext>();
            optionsBuilder.UseSqlServer(connectionStrings);

            return new EShopDbContext(optionsBuilder.Options);
        }
    }
}
