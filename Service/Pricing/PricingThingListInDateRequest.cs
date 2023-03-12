namespace Service.Pricing;

public class PricingThingListInDateRequest
{
    public List<PricingThingRequest> PricingThing { get; set; }
    public DateOnly Date { get; set; }


}