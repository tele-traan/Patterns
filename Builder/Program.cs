using Builder;

Manufacturer renaultManufacturer = new("Подмосковный завод \"Renault\"");
Manufacturer kznHeliManufacturer = new("Казанский вертолётный завод");

CarFactory carFactory = new();
renaultManufacturer.Compose(carFactory);
Vehicle renault = carFactory.GetComposedVehicle();

HelicopterFactory heliFactory = new();
kznHeliManufacturer.Compose(heliFactory);
Vehicle helicopter = heliFactory.GetComposedVehicle();


renault.Display();
helicopter.Display();