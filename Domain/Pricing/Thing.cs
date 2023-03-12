namespace Domain.Pricing;

public class Thing
{
    public int Id { get; }
    public string Name { get; set; }
    public byte Percent { get; set; }
    public bool IsActive { get; set; }
    public Thing( string name, byte percent)
    {
        Name = name;
        Percent = percent;
        IsActive = true;
    }
    public void Edit(string name , byte percent)
    {
        Name = name;
        Percent = percent;
    }
    public void Remove()
    {
        IsActive = false;
    }
   
}
