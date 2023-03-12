using Domain.Pricing;

namespace Service.Pricing;

public class PricingThingRequest
{
    public int Id { get; set; }
    public int ThingId { get; set; }
    public Grade Grade { get; set; }
    public int Pricing { get; set; }

}
