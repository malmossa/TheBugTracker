﻿using System.ComponentModel.DataAnnotations;

namespace TheBugTracker.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Guid? ImageId { get; set; }
        public virtual FileUpload? Image {  get; set; }
        public virtual ICollection<ApplicationUser> Members { get; set; } = [];

        public virtual ICollection<Project> Projects { get; set; } = [];

        // TODO: many invites
    }
}
