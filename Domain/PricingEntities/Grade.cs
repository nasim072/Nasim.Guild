using Domain.Common;

namespace Domain.PricingEntities;

public class Grade : Entity<byte>
{
    public string Name { get; }

    public Grade(string name)
    {
        Name = name;
    }
}