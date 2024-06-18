namespace FactoryMethod
{
    public class VehicleFactory
    {
        public static IVehicle Create(VehicleType type)
        {
            return type switch
            {
                VehicleType.Car => new Car(),
                VehicleType.Bike => new Bike(),
                VehicleType.MotorBike => new MotorBike(),
                _ => throw new NotSupportedException($"{type} is not currently supported as a vehicle method"),
            };
        }
    }
}
