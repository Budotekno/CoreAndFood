using System.ComponentModel.DataAnnotations;

namespace CoreAndFood.Models
{
    public class ServiceList
    {
         [Key]
        public int ServiceListId { get; set; }
        
        public string ServiceListMadde { get; set; }
    }
}