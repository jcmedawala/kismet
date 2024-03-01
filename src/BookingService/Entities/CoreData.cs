namespace BookingService.Entities;

public class CoreData
{
    public Guid Id { get; set; }
    public int AccountNumber { get; set; }
    public string LegalName { get; set; }
    public string LegalCountry { get; set; }
    public string Agent { get; set; }
    public string RelationshipManager { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public DateTime TargetDate { get; set; } = DateTime.UtcNow;
    public Product Product { get; set; }
    public ReviewType ReviewType { get; set; }
}
