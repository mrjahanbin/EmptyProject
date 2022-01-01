using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EmptyConsole5
{
    public class ProgramBase
    {
        public static ServiceProvider services { get; set; }


        public static void ConfigureServices()
        {
            services = new ServiceCollection()
            .AddDbContext<DBContext>(o =>
                o.UseSqlServer("Data Source = .;User Id=sa;Password=123; Initial Catalog = DB5; Integrated Security = false;Trust Server Certificate = true; MultipleActiveResultSets = True"))
            .BuildServiceProvider(validateScopes: true);

        }

        public static void DisposeServiceProvider()
        {
            if (services != null)
            {
                services.Dispose();
                services = null;
            }
        }

        public static DBContext StartDb()
        {
            #region Variables
            ConfigureServices();
            IServiceScope scope = services.CreateScope();
            #endregion
            DBContext _DBContext = scope.ServiceProvider.GetRequiredService<DBContext>();

            return _DBContext;
        }
    }
}