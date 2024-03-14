using eBrandSale.Domain.Abstractions;

namespace eBrandSale.Domain.Entities;
public sealed class Brand : Entity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
