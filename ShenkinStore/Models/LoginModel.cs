using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShenkinStore.Models
{
    public class LoginModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "UserName is Requierd.")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is Requierd.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
