using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental
{
    public interface IRentedScooterArchive
    {
        void AddRentedScooter(RentedScooter scooter);

        RentedScooter EndRental(string scooterId, DateTime rentEnd);
    }
}
