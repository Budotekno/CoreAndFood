using System.ComponentModel.DataAnnotations;

namespace CoreAndFood.Models
{
    public class AboutList
    {
         [Key]
        public int AboutListId { get; set; }
        
        public string AboutListMadde { get; set; }
    }
}