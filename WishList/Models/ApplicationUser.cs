using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace WishList.Models
{
    public class ApplicationUser : IdentityUser
    {
        virtual public ICollection<Item> Items { get; set; }
    }
}
