namespace DecoratorPattern02_AR.Business.Model;

public class GapCoverageDecorator : InsuranceCostAbstractDecorator
{
    public GapCoverageDecorator(IInsuranceCostProvider insuranceCost) : base(insuranceCost) { }

    public override decimal Cost()
    {
        return InsuranceCostProvider.Cost() + 50;
    }
}

public class TheftProtectionDecorator : InsuranceCostAbstractDecorator
{
    public TheftProtectionDecorator(IInsuranceCostProvider insuranceCost) : base(insuranceCost) { }

    public override decimal Cost()
    {
        return InsuranceCostProvider.Cost() + 30;
    }
}

public class TireAndWheelProtectionDecorator : InsuranceCostAbstractDecorator
{
    public TireAndWheelProtectionDecorator(IInsuranceCostProvider insuranceCost) : base(insuranceCost) { }

    public override decimal Cost()
    {
        return InsuranceCostProvider.Cost() + 20;
    }
}

public class KeyReplacementCoverageDecorator : InsuranceCostAbstractDecorator
{
    public KeyReplacementCoverageDecorator(IInsuranceCostProvider insuranceCost) : base(insuranceCost) { }

    public override decimal Cost()
    {
        return InsuranceCostProvider.Cost() + 10;
    }
}