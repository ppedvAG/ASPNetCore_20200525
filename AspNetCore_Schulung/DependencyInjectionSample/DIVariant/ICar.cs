using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSample.DIVariant
{
    public interface ICar
    {
        string Brand { get; set; }
        string Modell { get; set; }
        string Color { get; set; }

        DateTime Baujahr { get; set; }
    }
}
