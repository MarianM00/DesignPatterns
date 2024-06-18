namespace FactoryMethod
{
    public class Bike : IVehicle
    {
        public void NumberOfWheels()
        {
            Console.WriteLine("The bike has 2 wheels");
        }
    }
}
