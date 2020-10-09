using ShenkinStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShenkinStore.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Product> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}
