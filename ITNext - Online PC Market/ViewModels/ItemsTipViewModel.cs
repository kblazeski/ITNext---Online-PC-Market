using ITNext___Online_PC_Market.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITNext___Online_PC_Market.ViewModels
{
    public class ItemsTipViewModel
    {
        public Item item { get; set; }
        public IEnumerable<Tip> categories { get; set; }
    }
}