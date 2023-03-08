using System;
using System.ComponentModel.DataAnnotations;

namespace CodingEvents.ViewModels
{
	public class AddEventCategoryViewModel
	{
		[Required(ErrorMessage ="Please add a category type")]
		[StringLength(20, MinimumLength =1, ErrorMessage ="Category type should be between 1-20 characters")]
		public string? Name { get; set; }
	}
}

