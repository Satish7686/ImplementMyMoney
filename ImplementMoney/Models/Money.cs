using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImplementMoney.Models
{
    public class Money : IMoney
    {
        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string Currency { get; set; }
    }
}