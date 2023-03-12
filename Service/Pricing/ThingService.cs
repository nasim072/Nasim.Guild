using Domain.Pricing;

namespace Service.Pricing;

public class ThingService
{
    public readonly IThingRepository _thingRepository;

    public ThingService(IThingRepository thingRepository)
    {
        _thingRepository = thingRepository;
    }

    public BaseResponse Add(ThingRequest request)
    {
        var responce = new BaseResponse();
        var model = new Thing(request.Name, request.Percent);
        _thingRepository.Add(model);
        _thingRepository.SaveChange();
        return responce;
    }
    public BaseResponse Edit(ThingRequest request)
    {
        var responce = new BaseResponse();
        var model = _thingRepository.GetBy(request.Id);
        model.Edit(request.Name, request.Percent);
        _thingRepository.SaveChange();

        return responce;
    }

    public void Remove(int id)
    {
        var model = _thingRepository.GetBy(id);
        model.Remove();
        _thingRepository.SaveChange();

    }
}
