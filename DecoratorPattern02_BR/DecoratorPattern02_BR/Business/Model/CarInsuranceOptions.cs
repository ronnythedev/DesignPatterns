namespace DecoratorPattern02_BR.Business.Model;

public class BasicInsurance
{
    public virtual decimal Cost()
    {
        return 100;
    }
}

public class WithGap : BasicInsurance
{
    public override decimal Cost()
    {
        return base.Cost() + 50;
    }
}

public class WithTheftProtection : BasicInsurance
{
    public override decimal Cost()
    {
        return base.Cost() + 30;
    }
}

public class WithTireAndWheelProtection : BasicInsurance
{
    public override decimal Cost()
    {
        return base.Cost() + 20;
    }
}

public class WithKeyReplacementCoverage : BasicInsurance
{
    public override decimal Cost()
    {
        return base.Cost() + 10;
    }
}

public class WithGapAndTheftProtection : BasicInsurance
{
    public override decimal Cost()
    {
        return base.Cost() + 50 + 30;
    }
}

public class WithGapAndTireAndWheelProtection : BasicInsurance
{
    public override decimal Cost()
    {
        return base.Cost() + 50 + 20;
    }
}

public class WithGapTheftTireAndWheelKeyProtection : BasicInsurance
{
    public override decimal Cost()
    {
        return base.Cost() + 50 + 30 + 20 + 10;
    }
}

// ... at this point you see the problem right? The number of combinations is growing exponentially

