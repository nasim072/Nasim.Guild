namespace Service.Pricing;

public class PricingThingListService
{
    private readonly IPricingThingListRepository _pricingThingListrRepository;
    private readonly PricingThingServise _pricingThingService;

    public PricingThingListService(IPricingThingListRepository pricingThingListrRepository, PricingThingServise pricingThingService)
    {
        _pricingThingListrRepository = pricingThingListrRepository;
        _pricingThingService = pricingThingService;
    }

    public BaseResponse Create(PricingThingListInDateRequest request)
    {
        var responce = new BaseResponse();
        var model = _pricingThingListrRepository.GetLast();
        model.ChangeListForNewDate(request.Date);
        request.PricingThing.ForEach(x =>
        {
            model.RemovePricing(x.Id);
            model.AddPricing(_pricingThingService.Add(x));
        });

        _pricingThingListrRepository.SaveChange();

        return responce;
    }
}
