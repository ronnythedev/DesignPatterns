using DecoratorPattern02_AR.Business.Model;

Console.WriteLine("Customer 1: Only wants basic car insurance.");
var customerOneInsurance = new BasicInsurance();
Console.WriteLine($"Customer 1 - Insurance Cost: {customerOneInsurance.Cost()}");

Console.WriteLine("Customer 2: Wants basic car insurance + gap coverage.");
IInsuranceCostProvider customerTwoInsurance = new BasicInsurance();
customerTwoInsurance = new WithGap(customerTwoInsurance);
Console.WriteLine($"Customer 2 - Insurance Cost: {customerTwoInsurance.Cost()}");

Console.WriteLine("Customer 3: Wants basic car insurance + theft protection.");
IInsuranceCostProvider customerThreeInsurance = new BasicInsurance();
customerThreeInsurance = new WithTheftProtection(customerThreeInsurance);
Console.WriteLine($"Customer 3 - Insurance Cost: {customerThreeInsurance.Cost()}");

Console.WriteLine("Customer 4: Wants basic car insurance + tire and wheel protection.");
IInsuranceCostProvider customerFourInsurance = new BasicInsurance();
customerFourInsurance = new WithTireAndWheelProtection(customerFourInsurance);
Console.WriteLine($"Customer 4 - Insurance Cost: {customerFourInsurance.Cost()}");

Console.WriteLine("Customer 5: Wants basic car insurance + key replacement coverage.");
IInsuranceCostProvider customerFiveInsurance = new BasicInsurance();
customerFiveInsurance = new WithKeyReplacementCoverage(customerFiveInsurance);
Console.WriteLine($"Customer 5 - Insurance Cost: {customerFiveInsurance.Cost()}");

Console.WriteLine("Customer 6: Wants basic car insurance + gap coverage + theft protection.");
IInsuranceCostProvider customerSixInsurance = new BasicInsurance();
customerSixInsurance = new WithGap(customerSixInsurance);
customerSixInsurance = new WithTheftProtection(customerSixInsurance);
Console.WriteLine($"Customer 6 - Insurance Cost: {customerSixInsurance.Cost()}");

Console.WriteLine("Customer 7: Wants basic car insurance + gap coverage + tire and wheel protection.");
IInsuranceCostProvider customerSevenInsurance = new BasicInsurance();
customerSevenInsurance = new WithGap(customerSevenInsurance);
customerSevenInsurance = new WithTireAndWheelProtection(customerSevenInsurance);
Console.WriteLine($"Customer 7 - Insurance Cost: {customerSevenInsurance.Cost()}");

Console.WriteLine("Customer 8: Wants basic car insurance + gap coverage + theft protection + tire and wheel protection + key replacement coverage.");
IInsuranceCostProvider customerEightInsurance = new BasicInsurance();
customerEightInsurance = new WithGap(customerEightInsurance);
customerEightInsurance = new WithTheftProtection(customerEightInsurance);
customerEightInsurance = new WithTireAndWheelProtection(customerEightInsurance);
customerEightInsurance = new WithKeyReplacementCoverage(customerEightInsurance);
Console.WriteLine($"Customer 8 - Insurance Cost: {customerEightInsurance.Cost()}");

Console.WriteLine("Customer 9: Wants basic car insurance + key replacement + tire and wheel protection.");
IInsuranceCostProvider customerNineInsurance = new BasicInsurance();
customerNineInsurance = new WithKeyReplacementCoverage(customerNineInsurance);
customerNineInsurance = new WithTireAndWheelProtection(customerNineInsurance);
Console.WriteLine($"Customer 9 - Insurance Cost: {customerNineInsurance.Cost()}");

Console.WriteLine($"Customer 10: Wants basic car insurance + theft protection + key replacement.");
IInsuranceCostProvider customerTenInsurance = new BasicInsurance();
customerTenInsurance = new WithTheftProtection(customerTenInsurance);
customerTenInsurance = new WithKeyReplacementCoverage(customerTenInsurance);
Console.WriteLine($"Customer 10 - Insurance Cost: {customerTenInsurance.Cost()}");