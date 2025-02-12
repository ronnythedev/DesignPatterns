using ObserverPattern01_BR.Business.Model;

var knight = new Knight();
var mage = new Mage();
var merchant = new Merchant();

var app = new DragonEventManager(knight, mage, merchant);

app.DragonAttacks(100);