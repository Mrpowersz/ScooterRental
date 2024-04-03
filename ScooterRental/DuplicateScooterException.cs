namespace ScooterRental
{
    public class DuplicateScooterException : Exception
    {
        public DuplicateScooterException() : base("Scooter with provided id exists.")
        {

        }
    }
}
