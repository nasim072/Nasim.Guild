using Domain.Pricing;

namespace Service.Pricing;

public interface IPricingThingListRepository
{
    PricingThingListInDate GetLast();
    void Add(PricingThingListInDate pricingThingListInDate);
    void Remove(int id);
    void SaveChange();

}
