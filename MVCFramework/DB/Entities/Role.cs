using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace MVCFramework.DB.Entities
{
    public class Role
    {
        public IdentityRole IdentityRole { get; set; }
        public List<IdentityRoleClaim<string>> RoleClaims { get; set; }
    }
}
