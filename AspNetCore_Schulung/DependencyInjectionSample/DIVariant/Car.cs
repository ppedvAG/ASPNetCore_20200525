using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSample.DIVariant
{
    public class Car : ICar
    {
        public string Brand { get; set; }
        public string Modell { get; set; }
        public string Color { get; set; }
        public DateTime Baujahr { get; set; }
    }
}
