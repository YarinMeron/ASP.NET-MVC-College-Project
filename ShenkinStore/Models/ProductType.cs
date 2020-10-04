using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShenkinStore.Models
{
    public enum ProductType
    {
        Bag,
        [Display(Name = "Side Bag")]
        SideBag,
        Wallet
    }
}
