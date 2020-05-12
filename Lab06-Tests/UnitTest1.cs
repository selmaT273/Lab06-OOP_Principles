using System;
using Lab06_OOP_Principles;
using Xunit;

namespace Lab06_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void PoodleColorReturnsBlackTest()
        {
            // Act
            Poodle poodle = new Poodle();

            // Assert
            Assert.Equal("black", poodle.Color);

        }

        [Fact]
        public void PoodleSpeakReturnsBarkTest()
        {
            //Act
            Poodle poodle = new Poodle();

            // Assert
            Assert.Equal("bark", poodle.Speak());
        }

        [Fact]
        public void LabFurReturnsShortHairTest()
        {
            // Act
            Lab lab = new Lab();

            // Assert
            Assert.Equal("short hair", lab.FurType);
        }

        [Fact]
        public void LabTemperamentReturnsEnergeticTest()
        {
            // Act
            Lab lab = new Lab();

            // Assert
            Assert.Equal("energetic", lab.Temperament);
        }

        [Fact]
        public void OrioleColorReturnsOrangeTest()
        {
            // Act
            Oriole oriole = new Oriole();

            // Assert
            Assert.Equal("orange", oriole.Color);
        }

        [Fact]
        public void OrioleFeatherReturnsLightTest()
        {
            // Act
            Oriole oriole = new Oriole();

            // Assert
            Assert.Equal("light", oriole.FeatherType);
        }

        [Fact]
        public void CardinalColorReturnsRedTest()
        {
            // Act
            Cardinal cardinal = new Cardinal();

            // Assert
            Assert.Equal("red", cardinal.Color);
        }

        [Fact]
        public void CardinalMigrateReturnsTrueTest()
        {
            // Act
            Cardinal cardinal = new Cardinal();

            // Assert
            Assert.True(cardinal.Migrate());
        }
    }
}
