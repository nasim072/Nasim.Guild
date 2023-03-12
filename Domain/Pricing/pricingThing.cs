namespace Domain.Pricing;

public class PricingThing
{
    public PricingThing(int thingId) => ThingId = thingId;

    public long Id { get; set; }
    public Thing Thing { get; set; }
    public int ThingId { get; set; }
    public List<GradePricing> GradePricings { get; set; }

}
public enum Grade : byte
{
    grade1 = 1, grade2 = 2
}
public class GradePricing
{
    public long PricingThingId { get; set; }
    public Grade Grade { get; set; }
    public int Pricing { get; set; }
}
