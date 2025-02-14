using DecoratorPattern02_BR.Business.Model;

Console.WriteLine("Customer 1: Only wants basic car insurance.");
var customerOneInsurance = new BasicInsurance();
Console.WriteLine($"Customer 1 - Insurance Cost: {customerOneInsurance.Cost()}");

Console.WriteLine("Customer 2: Wants basic car insurance + gap coverage.");
var customerTwoInsurance = new WithGap();
Console.WriteLine($"Customer 2 - Insurance Cost: {customerTwoInsurance.Cost()}");

Console.WriteLine("Customer 3: Wants basic car insurance + theft protection.");
var customerThreeInsurance = new WithTheftProtection();
Console.WriteLine($"Customer 3 - Insurance Cost: {customerThreeInsurance.Cost()}");

Console.WriteLine("Customer 4: Wants basic car insurance + tire and wheel protection.");
var customerFourInsurance = new WithTireAndWheelProtection();
Console.WriteLine($"Customer 4 - Insurance Cost: {customerFourInsurance.Cost()}");

Console.WriteLine("Customer 5: Wants basic car insurance + key replacement coverage.");
var customerFiveInsurance = new WithKeyReplacementCoverage();
Console.WriteLine($"Customer 5 - Insurance Cost: {customerFiveInsurance.Cost()}");

Console.WriteLine("Customer 6: Wants basic car insurance + gap coverage + theft protection.");
var customerSixInsurance = new WithGapAndTheftProtection();
Console.WriteLine($"Customer 6 - Insurance Cost: {customerSixInsurance.Cost()}");

Console.WriteLine("Customer 7: Wants basic car insurance + gap coverage + tire and wheel protection.");
var customerSevenInsurance = new WithGapAndTireAndWheelProtection();
Console.WriteLine($"Customer 7 - Insurance Cost: {customerSevenInsurance.Cost()}");

Console.WriteLine("Customer 8: Wants basic car insurance + gap coverage + theft protection + tire and wheel protection + key replacement coverage.");
var customerEightInsurance = new WithGapTheftTireAndWheelKeyProtection();
Console.WriteLine($"Customer 8 - Insurance Cost: {customerEightInsurance.Cost()}");

Console.WriteLine("Customer 9: Wants basic car insurance + key replacement + tire and wheel protection.");
Console.WriteLine("This is not possible with the current implementation. Call IT to fix it by creating a new class.");