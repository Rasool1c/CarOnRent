using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CarOnRent
{
    [TestClass]
    public class CarTests
    {
        List <SingleFamily> singleFamily = new List<SingleFamily>();
        List<MultiUnit> multiUnits = new List<MultiUnit>();
        List<Car> carOnRent = new List<Car>();
        [TestMethod]
        public void SingleFamilyTest()
        {
            singleFamily.Add(new SingleFamily("Audi", "R8", 2022, 9000, 5, 2, "YES", "YES", "YES", "YES"));
            singleFamily.Add(new SingleFamily("Toyota", "Supra", 2017, 7000, 14, 2, "YES", "YES", "YES", "YES"));
            singleFamily.Add(new SingleFamily("BMW", "Z4", 2021, 6000, 12, 2, "YES", "YES", "YES", "YES"));
            singleFamily.Add(new SingleFamily("Mercedes", "Benz-GT", 2022, 9000, 13, 2, "YES", "YES", "YES", "YES"));
            singleFamily.Add(new SingleFamily("Porsche", "911", 2018, 4500, 10, 4, "YES", "YES", "YES", "YES"));
            foreach (var item in singleFamily)
            {
                Console.WriteLine(item.ToString());
            }
        }
        [TestMethod]
        public void MultiUnitsTest()
        {
            multiUnits.Add(new MultiUnit("Audi", "R8", 2022,"Ohio",10,9000));
            multiUnits.Add(new MultiUnit("Toyota", "Supra", 2017,"Albama New Towers",4,7000));
            multiUnits.Add(new MultiUnit("BMW", "Z4", 2021,"Los Santos",25, 6000));
            multiUnits.Add(new MultiUnit("Mercedes", "Benz-GT", 2022,"The Vice Brothers",7,9000));
            multiUnits.Add(new MultiUnit("Porsche", "911", 2018,"Green Wheels De Auto",20,4500));
            foreach(var item in multiUnits)
            {
                Console.WriteLine(item.ToString());
            }
        }
        [TestMethod]
        public void CombinedTest()
        {
            carOnRent.Add(new SingleFamily("Audi", "R8", 2022, 9000, 5, 2, "YES", "YES", "YES", "YES"));
            carOnRent.Add(new SingleFamily("Toyota", "Supra", 2017, 7000, 14, 2, "YES", "YES", "YES", "YES"));
            carOnRent.Add(new SingleFamily("BMW", "Z4", 2021, 6000, 12, 2, "YES", "YES", "YES", "YES"));
            carOnRent.Add(new SingleFamily("Mercedes", "Benz-GT", 2022, 9000, 13, 2, "YES", "YES", "YES", "YES"));
            carOnRent.Add(new SingleFamily("Porsche", "911", 2018, 4500, 10, 4, "YES", "YES", "YES", "YES"));

            carOnRent.Add(new MultiUnit("Audi", "R8", 2022, "Ohio", 10, 9000));
            carOnRent.Add(new MultiUnit("Toyota", "Supra", 2017, "Albama New Towers", 4, 7000));
            carOnRent.Add(new MultiUnit("BMW", "Z4", 2021, "Los Santos", 25, 6000));
            carOnRent.Add(new MultiUnit("Mercedes", "Benz-GT", 2022, "The Vice Brothers", 7, 9000));
            carOnRent.Add(new MultiUnit("Porsche", "911", 2018, "Green Wheels De Auto", 20, 4500));
            foreach(var item in carOnRent)
            {
                Console.WriteLine("Addresses: " +
                    "\n\tName: "+item.Name +
                    "\n\tModel: "+item.Model);
                Console.WriteLine("Projected Rental Amount: "+item.ProjectedRentalAmt().ToString("C"));
            }
        }
    }
}
