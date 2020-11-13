using ShenkinStore.Controllers;
using ShenkinStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShenkinStore.ViewModels
{
    public class KmeansViewModel
    {
        public int[] labels { get; set; }
        public List<Product>  topProduct { get; set; }
    }
}
