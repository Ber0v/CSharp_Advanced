
namespace CarManufacturer
{
    public class Car
    {
        private Engine engine;
        private Tire[] tires;

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public Tire[] Tires
        {
            get { return tires; }
            set { tires = value; }
        }
    }
}