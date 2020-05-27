using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSample.DIVariant
{
    public class CarService : ICarService
    {
        public List<ICar> GetAllCars()
        {
            // ER macht hier irgendwas. 
            List<ICar> list = new List<ICar>();
            
            return list;
        }

        public void RepairCar(ICar car)
        {
            //Es wird fröhlich repariert
        }
    }
}
