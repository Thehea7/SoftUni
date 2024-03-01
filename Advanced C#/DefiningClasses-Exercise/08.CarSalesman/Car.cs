using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; } = "n/a";

        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Model}:");
            sb.AppendLine($" {Engine.Model}:");
            sb.AppendLine($"  Power: {Engine.Power}");
            if (Engine.Displacement == 0)
                sb.AppendLine($"  Displacement: n/a");
            else
                sb.AppendLine($"  Displacement: {Engine.Displacement}");
            sb.AppendLine($"  Efficiency: {Engine.Efficiency}");
            if (Weight == 0)
                sb.AppendLine($" Weight: n/a");
            else
                sb.AppendLine($" Weight: {Weight}");
            sb.AppendLine($" Color: {Color}");

            return sb.ToString().TrimEnd();
        }
    }
}
