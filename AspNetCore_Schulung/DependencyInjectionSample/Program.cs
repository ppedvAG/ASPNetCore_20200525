using DependencyInjectionSample.DIVariant;
using DependencyInjectionSample.DIVariant.MockObject;
using System;

namespace DependencyInjectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarService carService = new CarService();

            //Dummy Klasse ist in 5 Minuten geschrieben
            ICar mockCar = new MockCar();

            //Dauert vielleicht 2 Tage
            ICar dasFertigeCarObject = new Car();


            carService.RepairCar(mockCar);

            carService.RepairCar(dasFertigeCarObject);



            Console.WriteLine("Hello World!");
        }
    }
}
