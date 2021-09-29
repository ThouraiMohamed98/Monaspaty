using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace MonaspatyF.Models
{
    public partial class HallShop
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Enter This Field")]
        public string Name { get; set; }


        [Required(ErrorMessage ="Enter This Field")]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile photo { get; set; }


        [Required(ErrorMessage ="Enter This Field")]
        public string Street { get; set; }


        [Required(ErrorMessage ="Enter This Field")]
        public string City { get; set; }


        [Required(ErrorMessage ="Enter This Field")]
        public string Station { get; set; }


        [Required(ErrorMessage ="Enter This Field")]
        public string Type { get; set; }
        public int Area { get; set; }
        public string TypeOfShop { get; set; } 


        [Required(ErrorMessage ="Enter This Field")]
        public string description { get; set; }

        [ForeignKey("Owner")]
        public int OwnerId { get; set; }
        public virtual HallShopOwner Owner { get; set; }
 
    }
}
