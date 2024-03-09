using Blog.Web.Data.Entities.Identity;
using Microsoft.AspNetCore.Identity;

public class RoleEntity : IdentityRole<int>
{
    public virtual ICollection<UserRoleEntity> UserRoles { get; set; }
}