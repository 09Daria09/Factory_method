using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method
{
    abstract class CreateTransport
    {
        public abstract ITransport Create();
    }

    class SeaCreator : CreateTransport
    {
        public override ITransport Create()
        {
            return new SeaVessels();
        }
    }
    class RoadCreator : CreateTransport
    {
        public override ITransport Create()
        {
            return new Truck();
        }
    }
    public class Truck : ITransport
    {
        public double Cost { get; set; }
        public string Del { get; set; }
        public double Dist { get; set; }
        public double Fuel { get; set; }
        public Truck(double cost, string del, double dist, double fuel)
        {
            Cost = cost;
            Del = del;
            Dist = dist;
            Fuel = fuel;
        }
        public Truck() { }

        public double CostDelivery()
        {
            return Cost;
        }
        public void Deliver()
        {
            Console.WriteLine(Del);
        }
        public double Distance()
        {
            return Dist;
        }
        public double FuelConsumption()
        {
            return Fuel;
        }
    }
    public class SeaVessels : ITransport
    {
        public double Cost { get; set; }
        public string Del { get; set; }
        public double Dist { get; set; }
        public double Fuel { get; set; }

        public double CostDelivery()
        {
            return Cost;
        }

        public void Deliver()
        {
            Console.WriteLine(Del);
        }

        public double Distance()
        {
            return Dist;
        }

        public double FuelConsumption()
        {
            return Fuel;
        }
    }
    public interface ITransport
    {
        void Deliver();
        double FuelConsumption();
        double CostDelivery();
        double Distance();
    }


    public class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
