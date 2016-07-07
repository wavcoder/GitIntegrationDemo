using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitIntegrationDemo
{
    class Car
    {
        public string Make;
        public string Model;
        public double InitialCost;
        public double TotalPaid;
        public int TopSpeed;
        public bool Convertible;

        public string GetWarrantyData()
        {
            return "This is allot of warranty data...";
        }

        public Boolean PaidInFull()
        {
            return (InitialCost - TotalPaid == 0);
        }

        public void PrintCarData(Car mycar)
        {
            var msg = new StringBuilder();

            msg.AppendLine("Make: " + mycar.Make);
            msg.AppendLine("Model: " + mycar.Model);
            msg.AppendLine("Initial Cost: " + mycar.InitialCost);
            msg.AppendLine("Total Paid: " + mycar.TotalPaid);
            msg.AppendLine("Top Speed: " + mycar.TopSpeed);
            msg.AppendLine("Convertible: " + mycar.Convertible);
            msg.AppendLine("Warranty Data: " + mycar.GetWarrantyData());
            msg.AppendLine("Is the car paid in full? " + (mycar.PaidInFull() ? "Yes" : "No"));

            Console.WriteLine(msg);
        }

        public void PrintCarData()
        {
            var msg = new StringBuilder();

            msg.AppendLine("\nMake2: " + Make);
            msg.AppendLine("Model2: " + Model);
            msg.AppendLine("Initial Cost2: " + InitialCost);
            msg.AppendLine("Total Paid2: " + TotalPaid);
            msg.AppendLine("Top Speed2: " + TopSpeed);
            msg.AppendLine("Convertible2: " + Convertible);
            msg.AppendLine("Warranty Data2: " + GetWarrantyData());
            msg.AppendLine("Is the car paid in full2? " + (PaidInFull() ? "Yes" : "No"));

            Console.WriteLine(msg);
        }

        public void IsCarPaid()
        {
            Console.WriteLine(string.Format("My car is {0}paid", (PaidInFull() ? "" : "Not ")));
        }

    }
}
