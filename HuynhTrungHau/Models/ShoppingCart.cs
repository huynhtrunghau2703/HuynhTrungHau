using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Build.Framework;

namespace HuynhTrungHau.Models
{
    [Table("ShoppingCart")]
    public class ShoppingCart
    {
       

            public int Id { get; set; }
            [Required]
            public string UserId { get; set; }
            public bool IsDeleted { get; set; } = false;

            public ICollection<CartDetail> CartDetails { get; set; }

        
    }
}
