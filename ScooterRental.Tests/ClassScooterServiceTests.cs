using FluentAssertions;

namespace ScooterRental.Tests
{
    [TestClass]
    public class ClassScooterServiceTests
    {
        private IScooterService _scooterService;
        private List<Scooter> _scooters;
        private const string _defaultScooterId = "1";

        [TestInitialize]
        public void Setup() 
        {
            _scooters = new List<Scooter>();
            _scooterService = new ScooterService(_scooters);
        }

        [TestMethod]
        public void AddScooter_Valid_Data_Provided_ScooterAdded() 
        {
            //Act
            _scooterService.AddScooter(_defaultScooterId, 0.1m);

            //Assert
            /*Assert.AreEqual(1, _scooters.Count);*/
            _scooters.Count.Should().Be(1);
        }

        [TestMethod]
        public void AddScooter_Invalid_Price_Provided_InvalidPriceException_Expected()
        {


            //Act
            Action action = () => _scooterService.AddScooter(_defaultScooterId, 0.0m);

            //Assert
            action.Should().Throw<InvalidPriceException>();

        }

        [TestMethod]
        public void AddScooter_Invalid_Id_Provided_InvalidIdException_Expected()
        {
            //Act
            Action action = () => _scooterService.AddScooter("", 0.1m);

            //Assert
            action.Should().Throw<InvalidIdException>();

        }

        [TestMethod]
        public void AddScooter_Add_Duplicate_Scooter_DuplicateScooterException_Expected()
        {
            //Arrange
            _scooters.Add(new Scooter(_defaultScooterId, 0.5m));

            //Act
            Action action = () => _scooterService.AddScooter(_defaultScooterId, 0.1m);

            //Assert
            action.Should().Throw<DuplicateScooterException>();

        }

        [TestMethod]
        public void RemoveScooter_Existing_ScooterId_Provided_Scooter_Removed()
        {
            //Arrange
            _scooters.Add(new Scooter(_defaultScooterId, 0.5m));

            //Act
            _scooterService.RemoveScooter(_defaultScooterId);

            //Assert
            _scooters.Count.Should().Be(0);

        }

        [TestMethod]
        public void RemoveScooter_NonExisting_ScooterId_Provided_ScooterNotFoundException_Expected()
        {
            //Act
            Action action = () =>_scooterService.RemoveScooter(_defaultScooterId);

            //Assert
            action.Should().Throw<ScooterNotFoundException>();
        }
    }
}
