using Microsoft.EntityFrameworkCore;

namespace CarManager.Data
{
	public class CarContext : DbContext
	{
		public CarContext(DbContextOptions<CarContext> options) : base(options)
		{
		}

		public DbSet<Car> Cars { get; set; }
	}
}