using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ReactTest.Authorization.Roles;
using ReactTest.Authorization.Users;
using ReactTest.MultiTenancy;

namespace ReactTest.EntityFrameworkCore
{
    public class ReactTestDbContext : AbpZeroDbContext<Tenant, Role, User, ReactTestDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ReactTestDbContext(DbContextOptions<ReactTestDbContext> options)
            : base(options)
        {
        }
    }
}
