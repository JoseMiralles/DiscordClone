using System;
using System.ComponentModel.DataAnnotations;

namespace Intalk.Models
{
    public class Message
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public DateTime Created { get; set; }

        [Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        [Required]
        public long TextChannelId { get; set; }
        public TextChannel TextChannel { get; set; }
    }

    public class CreateMessageRequest
    {
        public string Text { get; set; }
        public long TextChannelId { get; set; }
    }

    public class MessageResponse
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public string UserId { get; set; }
        public long TextChannelId { get; set; }

        public DateTime Created { get; set; }
    }
}