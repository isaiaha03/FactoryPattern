namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of vehicle do you want to drive? (Car or Truck)");
            string userVehicle = Console.ReadLine();

            IVehicle vehicle = VehicleFactory.GetVehicle(userVehicle);
            vehicle.Drive();
        }
    }
}
