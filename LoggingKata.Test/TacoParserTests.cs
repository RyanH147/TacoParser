using System;
using Xunit;


namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var taco = new TacoParser();

            //Act
            var actual = taco.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("34.720804, -85.280165, Taco Bell La Fayett...", -85.280165)]
        [InlineData("34.113051, -84.56005, Taco Bell Woodstoc...", -84.56005)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var parser = new TacoParser();

            //Act
            var actual = parser.Parse(line);

            //Assert           
            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("34.720804, -85.280165, Taco Bell La Fayett...", 34.720804)]
        [InlineData("34.113051, -84.56005, Taco Bell Woodstoc...", 34.113051)]
        public void ShouldParseLatitude(string line, double expected)
        {
            //Arrange
            var parser = new TacoParser();

            //Act
            var actual = parser.Parse(line);

            //assert
            Assert.Equal(expected, actual.Location.Latitude);
        }
    }
}
