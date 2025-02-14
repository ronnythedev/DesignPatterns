namespace DecoratorPattern02_AR.Business.Model;

public class BasicInsurance : IInsuranceCostProvider
{
    public decimal Cost()
    {
        return 100;
    }
}
