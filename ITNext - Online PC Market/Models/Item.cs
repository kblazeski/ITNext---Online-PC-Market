using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITNext___Online_PC_Market.Models
{
    public class Item
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Внесете име на продуктот!")]
        [Display(Name = "Име на продукт")]
        [DataType(DataType.MultilineText)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Внесете опис на продуктот!")]
        [Display(Name = "Опис на продукт")]
        public string Desc { get; set; }
        [Required(ErrorMessage = "Внесете слика на продуктот!")]
        [Display(Name="Линк со слика")]
        public string ImgURL { get; set; }
        [Required(ErrorMessage = "Внесете број на продукти во залиха!")]
        [Range(0,10000)]
        [Display(Name = "Број на продукти во залиха")]
        public int Stock { get; set; }
        [Required(ErrorMessage = "Внесете цена на продуктот!")]
        [Display(Name="Цена")]
        public int Price { get; set; }
        [Display(Name = "Категорија на продукт")]
        public Tip Tip { get; set; }
        public int TipId { get; set; }
    }
}