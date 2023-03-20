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

            public double CostDelivery()
            {
                throw new NotImplementedException();
            }

            public void Deliver()
            {
                throw new NotImplementedException();
            }

            public double Distance()
            {
                throw new NotImplementedException();
            }

            public double FuelConsumption()
            {
                throw new NotImplementedException();
            }
        }
        public class SeaVessels : ITransport
        {
            public double CostDelivery()
            {
                throw new NotImplementedException();
            }

            public void Deliver()
            {
                throw new NotImplementedException();
            }

            public double Distance()
            {
                throw new NotImplementedException();
            }

            public double FuelConsumption()
            {
                throw new NotImplementedException();
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
