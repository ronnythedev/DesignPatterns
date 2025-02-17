namespace DecoratorPattern02_AR.Business.Model;

public abstract class InsuranceCostAbstractDecorator : IInsuranceCostProvider
{
    protected readonly IInsuranceCostProvider InsuranceCostProvider;

    protected InsuranceCostAbstractDecorator(IInsuranceCostProvider insuranceCostProvider)
    {
        InsuranceCostProvider = insuranceCostProvider;
    }

    public abstract decimal Cost();
}
