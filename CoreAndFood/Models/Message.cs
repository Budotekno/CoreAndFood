using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Models
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }

        [StringLength(40)]
        public string MessageName { get; set; }

        [StringLength(40)]
        public string MessageSurname { get; set; }

        [StringLength(70)]
        public string MessageMail { get; set; }

        [StringLength(70)]
        public string MessageSubject { get; set; }

        [StringLength(700)]
        public string MessageLongMessage { get; set; }
    }
}
