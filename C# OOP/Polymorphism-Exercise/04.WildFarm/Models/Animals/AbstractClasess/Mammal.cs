namespace _04_WildFarm.Models.Animals.AbstractClasess
{
    public abstract class Mammal : Animal
    {
        public string LivingRegion { get; protected set; }
        protected Mammal(string name, double weight,  string livingRegion) : base(name, weight)
        {
            LivingRegion = livingRegion;
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
