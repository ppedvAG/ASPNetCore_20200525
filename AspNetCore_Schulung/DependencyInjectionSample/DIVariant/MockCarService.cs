using DependencyInjectionSample.DIVariant.MockObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSample.DIVariant
{
    public class MockCarService : ICarService
    {
        public List<ICar> GetAllCars()
        {
            return new List<MockCar>(); 
        }

        public void RepairCar(ICar car)
        {
            throw new NotImplementedException();
        }
    }
}
