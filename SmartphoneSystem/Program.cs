using SmartphoneSystem.Entities;

namespace SmartphoneSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiating the class polymorphically and testing the methods
            Console.WriteLine("Smartphone Nokia:");
            Smartphone nokia = new Nokia(phoneNumber: "123456", model: "Model 1", imei: "1111111111", memory: 64);
            nokia.Call();
            nokia.InstallApp("Whatsapp");
            nokia.ReceiveCall();

            Console.WriteLine();

            Console.WriteLine("Smartphone Iphone:");
            Smartphone iphone = new Iphone(phoneNumber: "654321", model: "Model 2", imei: "222222222", memory: 256);
            iphone.Call();
            iphone.InstallApp("Telegram");
            iphone.ReceiveCall();
        }
    }
}
