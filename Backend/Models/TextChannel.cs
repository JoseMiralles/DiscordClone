using System.ComponentModel.DataAnnotations;

namespace Intalk.Models
{
    public class TextChannel
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string Title { get; set; }

        public long ServerId { get; internal set; }
        public Server Server { get; set; }
    }

    public class CreateTextChannelRequest
    {
        public string Title { get; set; }
        public long ServerId { get; set; }
    }

    public class TextChannelResponse
    {
        public long Id { get; set; }
        public long ServerId { get; set; }
        public string Title { get; set; }
    }
}