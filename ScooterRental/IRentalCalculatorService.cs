using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental
{
    public interface IRentalCalculatorService
    {
        decimal CalculateRent(RentedScooter rentalRecord);
        decimal CalculateIncome(int? year, bool includeNotCompletedRentals);
    }
}
