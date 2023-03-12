using Domain.Common;

namespace Domain.PricingEntities;

public class Group : Entity<byte>
{
    public string Name { get; }

    public Group(short id, string name)
    {
        Name = name;
    }

    public void Update(Group newGroup)
    {
        throw new NotImplementedException();
    }

    public IList<Pricing> GetPricing(DateOnly date)
    {
        throw new NotImplementedException();
    }
}