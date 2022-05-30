using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Api
{
    
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {

        }

        public IConfiguration configuration1 { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer((string)Configuration.GetConnectionString("DBConnection")));

            services.AddControllers();
        }
    }
}
