using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage ="Kategori boş geçilemez !")]
        [StringLength(50,ErrorMessage ="Lütfen 50 karakterden fazla veri girişi yapmayınız!")]
        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public bool Status { get; set; }

        public List<Food> Foods { get; set; }
    }
}
