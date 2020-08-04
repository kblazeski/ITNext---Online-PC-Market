using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITNext___Online_PC_Market.Models
{
    public class Tip
    {
        public int Id { get; set; }
        [Display(Name = "Категорија на продукт")]
        public string Name { get; set; }
    }
}