namespace Domain.Common;

public interface IEntity
{
    bool IsActive { get; }
    DateTime? DeleteAt { get; }
}

public class Entity : Entity<short>
{
}

public class Entity<T> : IEntity
{
    public T Id { get; protected set; }
    public bool IsActive { get; private set; }
    public DateTime? DeleteAt { get; private set; }

    public void Delete()
    {
        IsActive = false;
        DeleteAt = DateTime.Now;
    }
}