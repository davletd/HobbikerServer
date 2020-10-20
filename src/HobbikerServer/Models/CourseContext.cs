using Microsoft.EntityFrameworkCore;

namespace HobbikerServer.Models
{
	public class TodoContext : DbContext
	{
			public TodoContext(DbContextOptions<TodoContext> options)
					: base(options)
			{
			}

			public DbSet<CourseItem> TodoItems { get; set; }
	}
}