namespace FactoryMethod
{
    public class MotorBike : IVehicle
    {
        public void NumberOfWheels()
        {
            Console.WriteLine("The MotorBike has 2 wheels");
        }
    }
}
