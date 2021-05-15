using System.ComponentModel.DataAnnotations;

namespace Intalk.Models
{
    public class TextChannel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string Title { get; set; }

        public long ServerId { get; internal set; }
        public Server Server { get; set; }
    }
}