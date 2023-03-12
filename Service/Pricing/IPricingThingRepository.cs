  using Domain.Pricing;

namespace Service.Pricing;

public interface IPricingThingRepository
{
   PricingThing Get(int id);
    void Add(PricingThing pricingThing);
    void SaveChange();

}
