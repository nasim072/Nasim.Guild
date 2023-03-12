using System.Xml.Serialization;

namespace Domain.Pricing;

public class PricingThingListInDate
{
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    public List<PricingThing> PricingThings { get; set; }
    public PricingThingListInDate( DateOnly date)
    {
        PricingThings = new List<PricingThing>();
        Date = date;
    }
    public void AddPricing(PricingThing pricingThing)
    {
        var CheckHavingPricingThing = PricingThings.SingleOrDefault(p => p.Id == pricingThing.Id);
        if(CheckHavingPricingThing is null)
          PricingThings.Add(pricingThing);
    }
    public void RemovePricing(int id)
    {
        var pricingThing = PricingThings.SingleOrDefault(p => p.Id == id);
        if(pricingThing is not null)
            PricingThings.Remove(pricingThing);
    }
  
    public void ChangeListForNewDate(DateOnly date)
    {
        Date = date;
        Id = 0;
    }
}
