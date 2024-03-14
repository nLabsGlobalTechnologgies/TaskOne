using eBrandSale.Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace eBrandSale.Domain.Entities;
public sealed class AppUser : IdentityUser<string>
{
    public AppUser()
    {
        Id = Guid.NewGuid().ToString();
    }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName => string.Join(" ", FirstName, LastName);

    public bool IsSeller { get; set; } = false;
    public UserRole UserRole { get; set; } = UserRole.SystemAdmin;
}
