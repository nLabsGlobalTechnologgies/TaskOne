using eBrandSale.Domain.Abstractions;

namespace eBrandSale.Domain.Entities;
public sealed class Product : Entity
{
    public string Name { get; set; } = string.Empty;

    public ICollection<ProductDetail>? Details { get; set; }
}