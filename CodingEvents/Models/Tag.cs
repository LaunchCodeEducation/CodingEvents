using System;
using System.ComponentModel.DataAnnotations;

namespace CodingEvents.Models
{
    public class Tag
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }

        public ICollection<Event>? Events { get; set; }

        public Tag(string name)
        {
            Name = name;
            Events = new List<Event>();
        }

        public Tag()
        {
        }
    }
}
