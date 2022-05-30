using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Api
{
    
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {

        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DBConnection")));

            services.AddControllers();
        }
    }
}
