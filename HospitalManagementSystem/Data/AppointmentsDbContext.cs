using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem.Data
{
    public class AppointmentsDbContext : DbContext
    {
        public AppointmentsDbContext(DbContextOptions<AppointmentsDbContext> options) : base(options) { }
    }
}
