using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOnRent
{
    internal class MultiUnit:Car, IUnits
    {
        string ComplexName { get; set; }
        int NumberOfUnits { get; set; }
        decimal RentAmountPerUnit { get; set; }
        public MultiUnit(string carName, string carModel, int carPurchaseYear, string complexName, int numberOfUnits,
            decimal rentAmountPerUnit) : base(carName, carModel, carPurchaseYear)
        {
            ComplexName = complexName;
            NumberOfUnits = numberOfUnits;
            RentAmountPerUnit = rentAmountPerUnit;
        }
        public override decimal ProjectedRentalAmt()
        {
            return RentAmountPerUnit * NumberOfUnits * 12M;
        }
        int IUnits.NumberOfUnits()
        {
            return NumberOfUnits;
        }
        public override string ToString()
        {
            return "Units Information: " +
                "\n\tCar Name: " + Name +
                "\n\tModel Name: " + Model +
                "\n\tPurchase Year: " + PurchaseYear +
                "\n\tComplex Name: " + ComplexName +
                "\n\tNumber Of Units: " + NumberOfUnits +
                "\n\tRent Amount Per Unit: " + RentAmountPerUnit.ToString("C") +
                "\n\tProjected Rental Amount: " + ProjectedRentalAmt().ToString("C");
        }
    }
}
