namespace SmartphoneSystem.Entities
{
    //Abstract class to inherit
    public abstract class Smartphone
    {
        //Class Properties 
        public string PhoneNumber { get; set; }
        public string Model { get; private set; }
        public string Imei { get; private set; }
        public int Memory { get; private set; }

        //Constructor class
        protected Smartphone(string phoneNumber, string model, string imei, int memory)
        {
            PhoneNumber = phoneNumber;
            Model = model;
            Imei = imei;
            Memory = memory;
        }

        //Method to write in console the call message
        public void Call()
        {
            Console.WriteLine("Calling...");
        }

        //Method to write in console the receiving call message
        public void ReceiveCall()
        {
            Console.WriteLine("Receiving call...");
        }

        //Abstract method to be implemented in the inheriting class
        public abstract void InstallApp(string appName);
    }
}
