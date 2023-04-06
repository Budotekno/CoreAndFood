using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [StringLength(200)]
        public string ContactAdress { get; set; }

        [StringLength(70)]
        public string ContactMail { get; set; }

        [StringLength(25)]
        public string ContactPhone { get; set; }

        [StringLength(1000)]
        public string ContactMaps { get; set; }
    }
}
