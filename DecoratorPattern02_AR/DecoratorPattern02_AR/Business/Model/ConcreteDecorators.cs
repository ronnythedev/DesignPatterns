namespace DecoratorPattern02_AR.Business.Model;

public class WithGap : InsuranceCostDecorator
{
    public WithGap(IInsuranceCostProvider insuranceCost) : base(insuranceCost) { }

    public override decimal Cost()
    {
        return _InsuranceCostProvider.Cost() + 50;
    }
}

public class WithTheftProtection : InsuranceCostDecorator
{
    public WithTheftProtection(IInsuranceCostProvider insuranceCost) : base(insuranceCost) { }

    public override decimal Cost()
    {
        return _InsuranceCostProvider.Cost() + 30;
    }
}

public class WithTireAndWheelProtection : InsuranceCostDecorator
{
    public WithTireAndWheelProtection(IInsuranceCostProvider insuranceCost) : base(insuranceCost) { }

    public override decimal Cost()
    {
        return _InsuranceCostProvider.Cost() + 20;
    }
}

public class WithKeyReplacementCoverage : InsuranceCostDecorator
{
    public WithKeyReplacementCoverage(IInsuranceCostProvider insuranceCost) : base(insuranceCost) { }

    public override decimal Cost()
    {
        return _InsuranceCostProvider.Cost() + 10;
    }
}