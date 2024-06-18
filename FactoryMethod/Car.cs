namespace FactoryMethod
{
    public class Car : IVehicle
    {
        public void NumberOfWheels()
        {
            Console.WriteLine("The car has 4 wheels");
        }
    }
}
