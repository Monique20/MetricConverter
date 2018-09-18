using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetricConverterKata;
using NUnit.Framework;

namespace MetricConverterKataTests
{
    [TestFixture]
    public class MetricConverterTests
    {
        [Test]
        public void ConvertToMiles_GivenKilometers_ShouldConvertToMiles()
        {
            //Arrange
            var km = 1;
            var sut = new MetricConverter();

            //Act
            var actual = sut.ConvertToMiles(km);

            //Assert
            var expected = 0.621371;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConvertToFahrenheit_GivenCelsius_ShouldConvertToFahrenheit()
        {
            //Arrange
            var celsius = 30;
            var sut = new MetricConverter();

            //Act
            var actual = sut.ConvertToFahrenheit(celsius);

            //Assert
            var expected = 86;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConvertToPounds_GivenKilograms_ShouldConvertToPounds()
        {
            //Arrange
            var kg = 5;
            var sut = new MetricConverter();

            //Act
            var actual = sut.ConvertToPounds(kg);

            //Assert
            var expected = 11.023113109243878;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConvertToGallons_GivenLiters_ShouldConvertToUSGallons()
        {
            //Arrange
            var liters = 1;
            var targetUnit = "US";
            var sut = new MetricConverter();

            //Act
            var actual = sut.ConvertToGallons(liters, targetUnit);

            //Assert
            var expected = 3.785411784;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConvertToGallons_GivenLiters_ShouldConvertToUKGallons()
        {
            //Arrange
            var liters = 1;
            var targetUnit = "UK";
            var sut = new MetricConverter();

            //Act
            var actual = sut.ConvertToGallons(liters, targetUnit);

            //Assert
            var expected = 4.54609;
            Assert.AreEqual(expected, actual);
        }
    }
}
