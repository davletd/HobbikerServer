
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

using HobbikerServer.Models;

namespace HobbikerServer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CourseItemsController : ControllerBase
	{
			private readonly CourseContext _context;

			public CourseItemsController(CourseContext context)
			{
					_context = context;
			}

			[HttpGet("{id}")]
			public async Task<ActionResult<CourseItem>> GetCourseItem(long id)
			{
					var courseItem = await _context.CourseItems.FindAsync(id);

					if (courseItem == null)
					{
							return NotFound();
					}

					return courseItem;
			}

			[HttpPut("{id}")]
			public async Task<IActionResult> PutCourseItem(long id, [FromBody]CourseItem courseItem)
			{
					if (id != courseItem.Id)
					{
							return BadRequest();
					}

					_context.Entry(courseItem).State = EntityState.Modified;

					try
					{
							await _context.SaveChangesAsync();
					}
					catch (DbUpdateConcurrencyException)
					{
							if (!CourseItemExists(id))
							{
									return NotFound();
							}
							else
							{
									throw;
							}
					}

					return NoContent();
			}

				[HttpPost]
        public async Task<ActionResult<CourseItem>> PostCourseItem(CourseItem courseItem)
        {
            _context.CourseItems.Add(courseItem);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetCourseItem", new { id = courseItem.Id }, courseItem);
            return CreatedAtAction(nameof(GetCourseItem), new { id = courseItem.Id }, courseItem);
        }

			private bool CourseItemExists(long id)
			{
					return _context.CourseItems.Any(e => e.Id == id);
			}

	}

	
}