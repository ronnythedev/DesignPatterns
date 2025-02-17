using DecoratorPattern02_AR.Business.Model;

Console.WriteLine("Customer 1: Only wants basic car insurance.");
var customerOneInsurance = new BasicInsurance();
Console.WriteLine($"Customer 1 - Insurance Cost: {customerOneInsurance.Cost()}");

Console.WriteLine("Customer 2: Wants basic car insurance + gap coverage.");
IInsuranceCostProvider customerTwoInsurance = new BasicInsurance();
customerTwoInsurance = new GapCoverageDecorator(customerTwoInsurance);
Console.WriteLine($"Customer 2 - Insurance Cost: {customerTwoInsurance.Cost()}");

Console.WriteLine("Customer 3: Wants basic car insurance + theft protection.");
IInsuranceCostProvider customerThreeInsurance = new BasicInsurance();
customerThreeInsurance = new TheftProtectionDecorator(customerThreeInsurance);
Console.WriteLine($"Customer 3 - Insurance Cost: {customerThreeInsurance.Cost()}");

Console.WriteLine("Customer 4: Wants basic car insurance + tire and wheel protection.");
IInsuranceCostProvider customerFourInsurance = new BasicInsurance();
customerFourInsurance = new TireAndWheelProtectionDecorator(customerFourInsurance);
Console.WriteLine($"Customer 4 - Insurance Cost: {customerFourInsurance.Cost()}");

Console.WriteLine("Customer 5: Wants basic car insurance + key replacement coverage.");
IInsuranceCostProvider customerFiveInsurance = new BasicInsurance();
customerFiveInsurance = new KeyReplacementCoverageDecorator(customerFiveInsurance);
Console.WriteLine($"Customer 5 - Insurance Cost: {customerFiveInsurance.Cost()}");

Console.WriteLine("Customer 6: Wants basic car insurance + gap coverage + theft protection.");
IInsuranceCostProvider customerSixInsurance = new BasicInsurance();
customerSixInsurance = new GapCoverageDecorator(customerSixInsurance);
customerSixInsurance = new TheftProtectionDecorator(customerSixInsurance);
Console.WriteLine($"Customer 6 - Insurance Cost: {customerSixInsurance.Cost()}");

Console.WriteLine("Customer 7: Wants basic car insurance + gap coverage + tire and wheel protection.");
IInsuranceCostProvider customerSevenInsurance = new BasicInsurance();
customerSevenInsurance = new GapCoverageDecorator(customerSevenInsurance);
customerSevenInsurance = new TireAndWheelProtectionDecorator(customerSevenInsurance);
Console.WriteLine($"Customer 7 - Insurance Cost: {customerSevenInsurance.Cost()}");

Console.WriteLine("Customer 8: Wants basic car insurance + gap coverage + theft protection + tire and wheel protection + key replacement coverage.");
IInsuranceCostProvider customerEightInsurance = new BasicInsurance();
customerEightInsurance = new GapCoverageDecorator(customerEightInsurance);
customerEightInsurance = new TheftProtectionDecorator(customerEightInsurance);
customerEightInsurance = new TireAndWheelProtectionDecorator(customerEightInsurance);
customerEightInsurance = new KeyReplacementCoverageDecorator(customerEightInsurance);
Console.WriteLine($"Customer 8 - Insurance Cost: {customerEightInsurance.Cost()}");

Console.WriteLine("Customer 9: Wants basic car insurance + key replacement + tire and wheel protection.");
IInsuranceCostProvider customerNineInsurance = new BasicInsurance();
customerNineInsurance = new KeyReplacementCoverageDecorator(customerNineInsurance);
customerNineInsurance = new TireAndWheelProtectionDecorator(customerNineInsurance);
Console.WriteLine($"Customer 9 - Insurance Cost: {customerNineInsurance.Cost()}");

Console.WriteLine($"Customer 10: Wants basic car insurance + theft protection + key replacement.");
IInsuranceCostProvider customerTenInsurance = new BasicInsurance();
customerTenInsurance = new TheftProtectionDecorator(customerTenInsurance);
customerTenInsurance = new KeyReplacementCoverageDecorator(customerTenInsurance);
Console.WriteLine($"Customer 10 - Insurance Cost: {customerTenInsurance.Cost()}");