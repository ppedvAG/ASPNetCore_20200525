using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSample.Old
{
    [Obsolete]
    public class CarService
    {
        public void RepairCar (Car car)
        {
            //...Macht irgendwas
        }
    }
}
