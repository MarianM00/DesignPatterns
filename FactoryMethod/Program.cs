using FactoryMethod;

IVehicle vehicle = VehicleFactory.Create(VehicleType.Car);
vehicle.NumberOfWheels();