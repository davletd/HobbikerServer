
using System;
using System.Threading.Tasks;

using HobbikerServer;

namespace HobbikerServer.Models {
	public class CourseItem
	{
			public long Id { get; set; }
			public string Name { get; set; }
			public bool IsComplete { get; set; }
	}
}