using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WPR.Domain.Customers;
using WPR.Infrastructure.DataAccess.Common;

namespace WPR.Infrastructure.Modules
{
    public static class Module
    {
        public static void RegisterDependencies(this IServiceCollection collection)
        {
            collection.AddDbContext<ApplicationContext>(x =>
            {
                x.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SecurityPractice;Trusted_Connection=True;MultipleActiveResultSets=true");
            });

            collection.AddIdentity<Customer, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationContext>()
                .AddDefaultTokenProviders();

            collection.AddAuthentication().AddCookie();
        }
    }
}
