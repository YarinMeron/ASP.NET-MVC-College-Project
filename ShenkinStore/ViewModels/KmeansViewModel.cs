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
        public List<Product> topproducts { get; set; }
    }
}
