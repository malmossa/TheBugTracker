using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace TheBugTracker.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        public Guid? ProfilePictureId { get; set; }
        public virtual FileUpload? ProfilePicture { get; set; }

        public int CompanyId { get; set; }
        public virtual Company? Company { get; set; }

        public virtual ICollection<Project> Projects { get; set; } = [];
    }

}
