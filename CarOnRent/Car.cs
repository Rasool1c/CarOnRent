using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOnRent
{
    public class Car
    {
        public Car(string carName, string carModel, int carPurchaseYear)
        {
            Name = carName;
            Model = carModel;
            PurchaseYear = carPurchaseYear;
        }
        public string Name { get; set; }
        public string Model { get; set; }
        public int PurchaseYear { get; set; }
        public virtual decimal ProjectedRentalAmt()
        {
            return 0M;
        }
        public override string ToString()
        {
            return "Car Details: \n\tName: " + Name +
                "\n\tModel Name: " + Model +
                "\n\tPurchased year: " + PurchaseYear +
                "\n\tProjected Rental AMount: " + ProjectedRentalAmt().ToString("C");
        }

    }
}
