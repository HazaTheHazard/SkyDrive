using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkyDrive.Models
{
    public class Auth
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
    }
}