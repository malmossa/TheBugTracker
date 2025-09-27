using System.ComponentModel.DataAnnotations;

namespace TheBugTracker.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Guid? ImageId { get; set; }
        public virtual ImageUpload? Image {  get; set; }
        public virtual ICollection<ApplicationUser> Members { get; set; } = [];

        // TODO: many projects
        // TODO: many invites
    }
}
