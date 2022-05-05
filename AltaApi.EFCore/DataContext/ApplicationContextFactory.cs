using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AltaApi.EFCore.DataContext
{
    public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationDataContext>
    {
        public ApplicationDataContext CreateDbContext(string[] args)
        {
            var contextBuilder = new DbContextOptionsBuilder<ApplicationDataContext>();
            contextBuilder.UseSqlServer("Server = LAPTOP-TEH8DOAU; database = ALTA_APIDB; Integrated Security = True");
            return new ApplicationDataContext(contextBuilder.Options);  
        }
    }
}
