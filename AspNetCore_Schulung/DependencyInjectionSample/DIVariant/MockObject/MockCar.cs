using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSample.DIVariant.MockObject
{
    public class MockCar : ICar
    {
        public string Brand
        {
            get
            {
                return "Fiat";
            }
            set
            {

            }
        }
               
        public string Modell 
        {
            get
            {
                return "500";
            }

            set => throw new NotImplementedException(); 
        }
        public string Color 
        { 
            get
            {
                return "Rot";
            }
            set => throw new NotImplementedException(); 
        }
        public DateTime Baujahr 
        { 
            get
            {
                return DateTime.Now;
            } 
            set => throw new NotImplementedException(); 
        }
    }
}
