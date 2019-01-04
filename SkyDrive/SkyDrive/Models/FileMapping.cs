using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkyDrive.Models
{
    public class FileMapping
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public string File { get; set; }
    }
}