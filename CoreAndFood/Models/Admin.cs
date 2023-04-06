using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Models
{
    public class Admin
    {
        [Key]
        public int  AdminId{ get; set; }

        [StringLength(30)]
        public string  UserName { get; set; }

        [StringLength(30)]
        public string UserPassword { get; set; }

        [StringLength(1)]
        public string Role { get; set; }
    }
}
