using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using COMP2007_S2016_TeamProject2.Models;

namespace COMP2007_S2016_TeamProject2.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}