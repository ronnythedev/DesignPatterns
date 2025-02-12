using ObserverPattern01_AR.Business.Model;

var dragonEventManager = new DragonEventManager();

var knight = new Knight();
var mage = new Mage(dragonEventManager);
var merchant = new Merchant();
var rogue = new Rogue();
var priest = new Priest();

dragonEventManager.AddObserver(knight);
dragonEventManager.AddObserver(mage);
dragonEventManager.AddObserver(merchant);
dragonEventManager.AddObserver(rogue);
dragonEventManager.AddObserver(priest);

dragonEventManager.DragonAttacks(60);