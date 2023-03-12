using Domain.Common;

namespace Domain.PricingEntities;

public class Pricing : Entity<long>
{
    public Pricing(Thing thing, int thingId, Grade grade, int gradeId, short price, DateOnly date, byte percent, short changes)
    {
        Thing = thing;
        ThingId = thingId;
        Grade = grade;
        GradeId = gradeId;
        Price = price;
        Date = date;
        Percent = percent;
        Changes = changes;
    }

    public Thing Thing { get; }
    public int ThingId { get; }

    public Grade Grade { get; }
    public int GradeId { get; }

    public short Price { get; }
    public DateOnly Date { get; }

    public byte Percent { get;  }
    public short Changes { get; }
}