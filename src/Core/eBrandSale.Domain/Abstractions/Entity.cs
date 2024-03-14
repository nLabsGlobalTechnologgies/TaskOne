namespace eBrandSale.Domain.Abstractions;
public abstract class Entity
{
    public string Id { get; private set; } = Guid.NewGuid().ToString();
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
}
