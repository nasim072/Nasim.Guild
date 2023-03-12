using Domain.Pricing;

namespace Service.Pricing;

public class PricingThingServise
{
    private readonly IPricingThingRepository pricingThingRepository;
    public PricingThing Add(PricingThingRequest request)
    {
        return new PricingThing(request.ThingId, request.Grade, request.Pricing);
    }


}
