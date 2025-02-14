namespace DecoratorPattern02_AR.Business.Model;

public class InsuranceCostDecorator : IInsuranceCostProvider
{
    protected IInsuranceCostProvider _InsuranceCostProvider;
    
    public InsuranceCostDecorator(IInsuranceCostProvider InsuranceCostProvider)
    {
        _InsuranceCostProvider = InsuranceCostProvider;
    }
    
    public virtual decimal Cost()
    {
        return _InsuranceCostProvider.Cost();
    }
}
