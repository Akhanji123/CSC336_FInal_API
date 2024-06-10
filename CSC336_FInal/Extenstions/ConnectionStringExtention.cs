using _DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CSC336_FInal.Extenstions
{
    public static class ConnectionStringExtention
    {
        public static IServiceCollection AddDB(this IServiceCollection service, ConfigurationManager config)
        {
            var ConnectionString = config.GetConnectionString("DefaultConnection");
            service.AddDbContext<AirplaneSystemContext>(options =>
                options.UseSqlServer(ConnectionString)
                );

            return service;
        }
    }
}
