using Domain.Common;

namespace Domain.PricingEntities;

public class Thing : Entity
{
    public string Name { get; }

    public short CategoryId { get; }
    public Category Category { get; }

    public IList<Pricing> Pricing { get; }

    public Thing(string name, short categoryId, Category category)
    {
        Name = name;
        CategoryId = categoryId;
        Category = category;
    }

    public void NewPrice(short price, short gradeId, Grade grade, DateOnly date, byte percent)
    {
        throw new NotImplementedException();
    }

    public void EditPrice(short pricingId, short price)
    {
        throw new NotImplementedException();
    }

    public void Add(Thing newThing)
    {
        throw new NotImplementedException();
    }

    public void Update(Thing editedUpdate)
    {
        throw new NotImplementedException();
    }
}
