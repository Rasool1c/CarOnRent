using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOnRent
{
    internal class SingleFamily:Car
    {
        decimal RentAmount { get; set; }
        decimal Mileage { get; set; }
        int NumberOfSeats { get; set; }
        string Bluetooth { get; set; }
        string WIFI { get; set; }
        string AC { get; set; }
        string AvailabilityOfMaintainance { get; set; }
        public SingleFamily(string carName, string carModel, int carPurchaseYear, decimal rentAmount, decimal mileage,
            int numberOfSeats, string bluetooth,string wIFI, string aC, string availabilityOfMaintainance) : base(carName, carModel, carPurchaseYear)
        {
            RentAmount = rentAmount;
            Mileage = mileage;
            NumberOfSeats = numberOfSeats;
            Bluetooth = bluetooth;
            WIFI= wIFI;
            AC = aC;
            AvailabilityOfMaintainance = availabilityOfMaintainance;
        }
        public override decimal ProjectedRentalAmt()
        {
            return RentAmount * 12M;
        }
        public override string ToString()
        {
            return "Car Features: " +
                "\n\tCar Name: " + Name +
                "\n\tModel Name: " + Model +
                "\n\tPurchase Year: " + PurchaseYear +
                "\n\tRentAmount: " + RentAmount.ToString("c") +
                "\n\tMileage: " + Mileage + "/KMPL"+
                "\n\tNumberOfSeats: " + NumberOfSeats +
                "\n\tBluetooth: " + Bluetooth +
                "\n\tWIFI: " + WIFI+
                "\n\tAC: " + AC +
                "\n\tAvailabilityOfMaintainance: " + AvailabilityOfMaintainance +
                "\n\tProjected Rental Amount: " + ProjectedRentalAmt().ToString("C");
        }
    }
}
