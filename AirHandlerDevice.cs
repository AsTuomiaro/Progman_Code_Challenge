using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgmanCodeChallenge
{
    public class AirHandlerDevice : Part
    {
        public Fan fan1, fan2;
        public Filter filter1, filter2;
        public Coil coil;
        public HeatExchanger heatExchanger;

        private Part[] partList;
        private IEnumerable<Part> query;

        public AirHandlerDevice()
        {
            fan1 = new Fan();
            fan2 = new Fan();
            filter1 = new Filter();
            filter2 = new Filter();
            coil = new Coil();
            heatExchanger = new HeatExchanger();
 
            partList = new Part[] { fan1, fan2, filter1, filter2, coil, heatExchanger };
            query = partList.OrderBy(a => a.ProductCode);
        }
 
        public void Print()
        {
            Console.WriteLine("This is an Air Handler Device, and it contains these parts: ");
 
            foreach (Part item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}