using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkyDrive.Models
{
    public class Note
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        public string Body { get; set; }

        [ForeignKey("Auth")]
        public virtual string UserId { get; set; }
        public virtual Account Auth { get; set; }
    }
}