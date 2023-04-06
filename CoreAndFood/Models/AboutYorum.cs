using System.ComponentModel.DataAnnotations;

namespace CoreAndFood.Models
{
    public class AboutYorum
    {
         [Key]
        public int AboutYorumId { get; set; }
        
        public string AboutYorumCommet { get; set; }
        public string AboutYorumName { get; set; }
    }
}