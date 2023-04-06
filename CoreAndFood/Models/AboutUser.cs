using System.ComponentModel.DataAnnotations;

namespace CoreAndFood.Models
{
    public class AboutUser
    {
         [Key]
        public int AboutUserId { get; set; }

        public string AboutUserName { get; set; }
        public string AboutUserJob { get; set; }
        public string AboutUserPictureUrl { get; set; }
    }
}