namespace SmartphoneSystem.Entities
{
    //Inherited class 
    public class Iphone : Smartphone
    {
        //Constructor class
        public Iphone(string phoneNumber, string model, string imei, int memory) : base(phoneNumber, model, imei, memory)
        {
        }

        //Implementing the abstract method inherited from the abstract class
        public override void InstallApp(string appName)
        {
            Console.WriteLine($"Installing the app '{appName}' on Iphone");
        }
    }
}
