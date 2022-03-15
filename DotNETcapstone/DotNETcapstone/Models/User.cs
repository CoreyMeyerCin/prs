using System.ComponentModel.DataAnnotations;

namespace DotNETcapstone.Models
{
    public class User
    {
        public int Id { get; set; }
        public static int NextId { get; set; }
        [Required, StringLength(18)]
        public string Username  { get; set; }
        [Required, StringLength(30)]
        public string Password { get; set; }
        [Required, StringLength(30)]
        public string FirstName { get; set; }
        [Required, StringLength(30)]


        public string LastName { get; set; }
        [Required, StringLength(12)]
        public string Phone { get; set; }
        [Required, StringLength(255)]
        public string email { get; set; }
        public bool isReviewer { get; set; }
        public bool isAdmin { get; set; }

        public User() {
            Id = ++NextId; 
        }
    }
}
