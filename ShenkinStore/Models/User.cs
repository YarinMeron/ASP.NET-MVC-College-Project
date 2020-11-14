using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShenkinStore.Models
{
    public class User
    {
  
        public int UserId { get; set; }
        [Display(Name = "User Name")]
        [DataType(DataType.Text)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "User Name is Requierd."),MaxLength(20)]
        public string UserName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is Requierd.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again !")]
        [NotMapped]
        public string ConfirmedPassword { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is Requierd.")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email is not valid.")]
        public string Email { get; set; }
        [Display(Name = "Phone - (Optional)")]
        [DataType(DataType.PhoneNumber)]
       
         [RegularExpression(@"(\+[0-9]{2}|\+[0-9]{2}\(0\)|\(\+[0-9]{2}\)\(0\)|00[0-9]{2}|0)([0-9]{9}|[0-9\-\s]{9,18})", ErrorMessage = "Phone Number is not valid.")]
        public string Phone { get; set; }
         [Display(Name = "User Type")]
         public UserType userType { get; set; }
       
        public DateTime CreatedOn { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}