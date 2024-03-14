using eBrandSale.Domain.Abstractions;

namespace eBrandSale.Domain.Entities;
public sealed class ProductDetail : Entity
{
    public string ProductId { get; set; } = string.Empty;
    public Product? Product { get; set; }
    public string PropertyName { get; set; } = string.Empty;//Beden Renk gibi İsimler
    public string PropertyValue { get; set; } = string.Empty;// Kırmızı S M XL gibi özellikler
}
