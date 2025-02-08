namespace StrategyPattern01_BR.Business.Models;

public class Order
{
    public List <LineItem> LineItems { get; set; } = new List<LineItem>();
    public ShippingDetails ShippingDetails { get; set; }
    public decimal GetTax()
    {
        var destination = ShippingDetails.DestinationCountry.ToLowerInvariant();

        if (destination == "sweden")
        {
            var origin = ShippingDetails.OriginCountry.ToLowerInvariant();

            if (destination == origin)
            {
                return TotalPrice * 0.25m;
            }
        }

        if (destination == "us")
        {
            switch (ShippingDetails.DestinationState.ToLowerInvariant())
            {
                case "la": 
                    return TotalPrice * 0.095m;
                case "ny": 
                    return TotalPrice * 0.04m;
                case "nyc": 
                    return TotalPrice * 0.045m;
                default:
                    return 0;
            }
        }
            
        return 0;
    }
        
    public decimal TotalPrice
    {
        get
        {
            return LineItems.Sum(x => x.UnitPrice * x.Quantity);
        }
    }
}

public class LineItem
{
    public required string Id { get; set; }
    public required string Description { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Quantity { get; set; }
    public ItemType Type { get; set; }
}
    
public enum ItemType
{ 
    Literature,
    Service,
}
    
public class ShippingDetails
{
    public string OriginCountry { get; set; }
    public string DestinationCountry { get; set; }
    public string DestinationState { get; set; }
}