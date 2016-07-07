using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitIntegrationDemo
{
    public class Bicycle
    {
        public string Make;
        public string Color;
        public int WheelCount;
        public bool SissyBar;
        public bool Horn;

        public void PrintBicycleData()
        {
            var msg = new StringBuilder();
            msg.AppendLine("\nBicycle Make: " + Make);
            msg.AppendLine("Bicycle Color: " + Color);
            msg.AppendLine("Bicycle Wheel Count: " + WheelCount);
            msg.AppendLine("Bicycle has SissyBar: " + SissyBar);
            msg.AppendLine("Bicycle has Horn: " + Horn);
            Console.WriteLine(msg);
        }
    }
}
