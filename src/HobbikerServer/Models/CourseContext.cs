using Microsoft.EntityFrameworkCore;

namespace HobbikerServer.Models
{
	public class CourseContext : DbContext
	{
			public CourseContext(DbContextOptions<CourseContext> options)
					: base(options)
			{
			}

			public DbSet<CourseItem> CourseItems { get; set; }
	}
}