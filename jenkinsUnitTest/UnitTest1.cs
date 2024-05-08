using jenkinsTest;
using jenkinsTest.Controllers;
using Microsoft.Extensions.Logging;
using Moq;

namespace jenkinsUnitTest
{
    [TestFixture]
    public class Tests
    {
        private WeatherForecastController _weatherForecastController;
        private Mock<ILogger<WeatherForecastController>> _logger;
        private const string Expected = "Hello World! from Thetips4you";

        public void Setup()
        {
            _logger = new Mock<ILogger<WeatherForecastController>>();
            _weatherForecastController = new WeatherForecastController(_logger.Object);
        }

        [Test]
        public void TestMethod1()
        {
            Setup();
            var response = _weatherForecastController.Get();

            Assert.IsInstanceOf(typeof(WeatherForecast[]), response);

        }
    }
}