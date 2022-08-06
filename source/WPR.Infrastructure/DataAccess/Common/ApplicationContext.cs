using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WPR.Domain.Customers;

namespace WPR.Infrastructure.DataAccess.Common
{
    public sealed class ApplicationContext : IdentityDbContext<Customer>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
