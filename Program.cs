namespace ProgmanCodeChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var airHandlerDevice = new AirHandlingDevice();

            airHandlerDevice.fan1.ProductCode = "234563456";
            airHandlerDevice.fan1.Description = "Thid is a fan. Yay!";
            airHandlerDevice.fan1.FanType = Fan.FanTypeSetting.Axial;
            airHandlerDevice.fan1.FanSpeed = Fan.FanSpeedSetting.Normal;

            airHandlerDevice.fan2.ProductCode = "345675678";
            airHandlerDevice.fan2.Description = "Thid is another fan. Yay!";
            airHandlerDevice.fan2.FanType = Fan.FanTypeSetting.Radial;
            airHandlerDevice.fan2.FanSpeed = Fan.FanSpeedSetting.Fast;
 
            airHandlerDevice.filter1.ProductCode = "567893450";
            airHandlerDevice.filter1.Description = "This is a filter. Yay!";
            airHandlerDevice.filter1.Property1 = "Something";
            airHandlerDevice.filter1.Property2 = "Something more";


            airHandlerDevice.filter2.ProductCode = "678903458";
            airHandlerDevice.filter2.Description = "This is another filter. Yay!";
            airHandlerDevice.filter2.Property1 = "Something else";
            airHandlerDevice.filter2.Property2 = "Jessica";


            airHandlerDevice.coil.ProductCode = "789345678";
            airHandlerDevice.coil.Description = "Just a coil";
            airHandlerDevice.coil.Property1 = Coil.Property1Setting.Something;
            airHandlerDevice.coil.Property2 = Coil.Property2Setting.More;
            
            airHandlerDevice.heatExchanger.ProductCode = "456890567";
            airHandlerDevice.heatExchanger.Description = "thingy... I don't know.";
            airHandlerDevice.heatExchanger.Property1 = "blah blah";
            airHandlerDevice.heatExchanger.Property2 = "Yay!";
            
            airHandlerDevice.Print();
        }
    }
}
