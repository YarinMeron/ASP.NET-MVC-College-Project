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
        //[Required(ErrorMessage = "Please enter name"), MaxLength(20)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "UserName is Requierd."),MaxLength(20)]
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
        //[Required(ErrorMessage = "Please enter Email Adress")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is Requierd.")]

        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string Email { get; set; }
        [Display(Name = "Phone - (Optional)")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
         [Display(Name = "User Type")]
          public UserType userType { get; set; }
       
        [NotMapped]
        public string SuccessMessege { get; set; }
        public DateTime CreatedOn { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
