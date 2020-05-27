using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSample.DIVariant
{
    public interface ICarService
    {
        List<ICar> GetAllCars();

        void RepairCar(ICar car);
    }
}
