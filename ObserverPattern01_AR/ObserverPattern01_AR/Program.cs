using ObserverPattern01_AR.Business.Model;

var dragonEventManager = new DragonEventManager();

var knight = new Knight();
var mage = new Mage(dragonEventManager);
var merchant = new Merchant();

dragonEventManager.AddObserver(knight);
dragonEventManager.AddObserver(mage);
dragonEventManager.AddObserver(merchant);

dragonEventManager.DragonAttacks(60);