
using BookingService.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookingService.Data;

public class DbInitializer
{
    public static void InitDb(WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        SeedData(scope.ServiceProvider.GetService<CoreDataDbContext>());
    }

    private static void SeedData(CoreDataDbContext context)
    {
        context.Database.Migrate();

        if (context.CoreDatas.Any())
        {
            Console.WriteLine("Already have data - no need to seed");
            return;
        }

        var coredatas = new List<CoreData>()
        {
            new CoreData
            {
                Id = Guid.Parse("afbee524-5972-4075-8800-7d1f9d7b0a0c"),
		        AccountNumber = 123123,
                LegalName = "ABC Limited",
                LegalCountry = "USA",
                Agent = "Lisa Fisk",
		        RelationshipManager = "Sachith Jayakody",
		        ReviewType = ReviewType.BAU,
                Product = new Product
                {
                    BusinessUnit = "FTSE Russell",
                    BookingLegalEntity = "D&A",
                    ProductName = "Unavista",
                    AddedBy = "Janaka Medawala"
                }
            },
            new CoreData
            {
                Id = Guid.Parse("c8c3ec17-01bf-49db-82aa-1ef80b833a9f"),
		        AccountNumber = 567456,
                LegalName = "Sberbank JSC",
                LegalCountry = "Russia",
                Agent = "Joshua Bentley",
		        RelationshipManager = "John Doe",
		        ReviewType = ReviewType.PeriodicReview,
                Product = new Product
                {
                    BusinessUnit = "LCH SA",
                    BookingLegalEntity = "LCH Limited",
                    ProductName = "RNS",
                    AddedBy = "Dilka Algama"
                }
            }
        };

        context.AddRange(coredatas);

        context.SaveChanges();
    }
}
