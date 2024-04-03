namespace ScooterRental
{
    public class ScooterNotFoundException : Exception
    {
        public ScooterNotFoundException() : base("Scooter not found")
        {
            
        }
    }
}
