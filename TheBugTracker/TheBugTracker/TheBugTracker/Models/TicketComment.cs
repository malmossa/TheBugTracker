﻿using System.ComponentModel.DataAnnotations;

namespace TheBugTracker.Models
{
    public class TicketComment
    {
        private DateTimeOffset _created;

        public int Id { get; set; }

        [Required]
        public string? Content { get; set; }

        public DateTimeOffset Created 
        { 
            get => _created;
            set => _created = value.ToUniversalTime();
        }

        public int TicketId { get; set; }

        public virtual Ticket? Ticket { get; set; }

        [Required]
        public string? UserId { get; set; }

        public virtual ApplicationUser? User { get; set; }
    }
}
