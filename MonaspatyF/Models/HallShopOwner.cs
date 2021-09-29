using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace MonaspatyF.Models
{
    public partial class HallShopOwner
    {
        public HallShopOwner()
        {
            HallShops = new HashSet<HallShop>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Enter your National ID")]
        [StringLength(15,ErrorMessage = " invalid National ID")]
        [Remote("checkSSN", "Operation", ErrorMessage = "National ID is Exit")]
        public string SSN { get; set; }

        [Required(ErrorMessage = "Enter your Name")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "invalid Name.Enter Full Name")]
        public string name { get; set; }

        [Required(ErrorMessage = "Enter your phone")]
        [StringLength(12, ErrorMessage = "invalid phone")]
        [RegularExpression(@"^01[0-2,5]\d{8}$" , ErrorMessage = "invalid Phone")]
        public string phone { get; set; }

        [Required(ErrorMessage = "Enter your Email")]
        //[RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$", ErrorMessage = "invalid Email")]
        [EmailAddress]
        [Remote("checkEmail", "Operation", ErrorMessage = "Email is Exit")]
        public string email { get; set; }

        [Required(ErrorMessage = "Enter your Password")]
        public string password { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Enter your confirm Password")]
        [Compare("password", ErrorMessage = "Password not match")]
        public string confirmPassword { get; set; }

        public virtual ICollection<HallShop> HallShops { get; set; }
    }
}
