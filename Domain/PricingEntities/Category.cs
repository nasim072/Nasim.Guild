using Domain.Common;

namespace Domain.PricingEntities;

public class Category : Entity
{
    public string Name { get; private set; }

    public short GroupId { get; private set; }
    public Group Group { get; }

    public Category(string name, short groupId)
    {
        Name = name;
        GroupId = groupId;
    }

    public void Update(Category newCategory)
    {
        Name = newCategory.Name;
        GroupId = newCategory.GroupId;
    }
}