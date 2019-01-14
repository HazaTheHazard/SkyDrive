using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkyDrive.Models
{
    public class FileMapping
    {
        public int ID { get; set; }

        [Required]
        public string File { get; set; }

        [ForeignKey("Auth")]
        public virtual string UserId { get; set; }
        public virtual Account Auth { get; set; }
    }
}