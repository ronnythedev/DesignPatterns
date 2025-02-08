using StrategyPattern01_BR.Business.Models;

var order = new Order
{
    ShippingDetails = new ShippingDetails
    {
        OriginCountry = "Costa Rica",
        DestinationCountry = "Sweden"
    }
};

order.LineItems.Add(new LineItem
{
    Id = "Book1",
    Description = "CSharp Book",
    Quantity = 1,
    Type = ItemType.Literature,
    UnitPrice = 100
});

order.LineItems.Add(new LineItem
{
    Id = "Service1",
    Description = "Create a website",
    Quantity = 1,
    Type = ItemType.Service,
    UnitPrice = 100
});

Console.WriteLine(order.GetTax());
