using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp.Service;

namespace WindowsFormsApp.Tests
{
    [TestClass]
    public class TemperatureConverterTests
    {
        private TemperatureConverter _converter;

        [TestInitialize]
        public void Setup()
        {
            _converter = new TemperatureConverter();
        }

        [TestMethod]
        public void CelsiusToFahrenheit_ValidInput_ReturnsCorrectResult()
        {
            // Arrange
            double celsius = 0;
            double expected = 32;

            // Act
            double result = _converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FahrenheitToCelsius_ValidInput_ReturnsCorrectResult()
        {
            // Arrange
            double fahrenheit = 32;
            double expected = 0;

            // Act
            double result = _converter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CelsiusToKelvin_ValidInput_ReturnsCorrectResult()
        {
            // Arrange
            double celsius = 0;
            double expected = 273.15;

            // Act
            double result = _converter.CelsiusToKelvin(celsius);

            // Assert
            Assert.AreEqual(expected, result, 0.01); // Tolerância para ponto flutuante
        }

        [TestMethod]
        public void KelvinToCelsius_ValidInput_ReturnsCorrectResult()
        {
            // Arrange
            double kelvin = 273.15;
            double expected = 0;

            // Act
            double result = _converter.KelvinToCelsius(kelvin);

            // Assert
            Assert.AreEqual(expected, result, 0.01);
        }

        [TestMethod]
        public void FahrenheitToKelvin_ValidInput_ReturnsCorrectResult()
        {
            // Arrange
            double fahrenheit = 32;
            double expected = 273.15;

            // Act
            double result = _converter.FahrenheitToKelvin(fahrenheit);

            // Assert
            Assert.AreEqual(expected, result, 0.01);
        }

        [TestMethod]
        public void KelvinToFahrenheit_ValidInput_ReturnsCorrectResult()
        {
            // Arrange
            double kelvin = 273.15;
            double expected = 32;

            // Act
            double result = _converter.KelvinToFahrenheit(kelvin);

            // Assert
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}