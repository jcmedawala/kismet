using System.ComponentModel.DataAnnotations.Schema;

namespace BookingService.Entities;

[Table("Products")]
public class Product
{
    public Guid Id { get; set; }
    public string BusinessUnit { get; set; }
    public string BookingLegalEntity { get; set; }  
    public string ProductName { get; set; }
    public string AddedBy { get; set; } 
    public DateTime AddedAt { get; set; } = DateTime.UtcNow;

    // nav properties

    public CoreData CoreData { get; set; }
    public Guid CoreDataId { get; set; }
}
