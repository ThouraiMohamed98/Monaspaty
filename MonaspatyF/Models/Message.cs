using System;
using System.ComponentModel.DataAnnotations;

namespace MonaspatyF.Models
{
    public class Message
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="*")]
        [StringLength(50,MinimumLength =10,ErrorMessage ="Short Name")]
        public string name { get; set; }

        [Required(ErrorMessage ="*")]
        [StringLength(12,ErrorMessage ="Phone isn't valid")]
        public string phone { get; set; }

        [Required(ErrorMessage ="*")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$", ErrorMessage = "invalid Email")]
        public string email { get; set; }

        [Required(ErrorMessage ="*")]
        public string subject { get; set; }

        [Required(ErrorMessage ="*")]
        public string UserMessage { get; set; }
    }
}
