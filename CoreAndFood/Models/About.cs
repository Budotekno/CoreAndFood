using System.ComponentModel.DataAnnotations;

namespace CoreAndFood.Models
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        
        public string AboutCommet { get; set; }
        
        public string AboutPicture { get; set; }




    }
}