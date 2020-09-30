using System;
using Xunit;


namespace ConsoleAppOOPShow.Tests
{
    public class CarTests
    {
        [Fact]
        public void SmallCunstructor()
        {
            //Arrange
            int year = 2020;
            string brand = "TestBrand";
            string modelName = "Buster";

            //Act
            Car result = new Car(year, brand, modelName);

            //Assert
            Assert.NotNull(result);
            Assert.Contains(year.ToString(), result.CarInfomation());
            Assert.Contains(brand, result.CarInfomation());
            Assert.Contains(modelName, result.CarInfomation());
        }

        [Fact]
        public void BigCunstructor()
        {
            //Arrange
            int year = 2020;
            string brand = "TestBrand";
            string modelName = "Buster";
            string color = "Blue";
            string regPlate = "ABC123";

            //Act
            Car result = new Car(year, brand, modelName, color, regPlate);

            //Assert
            Assert.NotNull(result);
            Assert.Contains(year.ToString(), result.CarInfomation());
            Assert.Contains(brand, result.CarInfomation());
            Assert.Contains(modelName, result.CarInfomation());
            Assert.Contains(color, result.CarInfomation());
            Assert.Contains(regPlate, result.CarInfomation());
        }

        [Fact]
        public void RegPlateUpperLetters()
        {
            //Arrange
            int year = 2020;
            string brand = "TestBrand";
            string modelName = "Buster";
            string regPlate = "ujf852";
            string regPlateExpected = "UJF852";
            Car car = new Car(year, brand, modelName);

            //Act
            car.RegPlate = regPlate;//string result = car.RegPlate = regPlate;

            //Assert
            Assert.Equal(regPlateExpected, car.RegPlate);
        }

        [Fact]
        public void GoodColorCar()
        {
            //Arrange
            int year = 2020;
            string brand = "TestBrand";
            string modelName = "Buster";
            string color = "Green";
            Car car = new Car(year, brand, modelName);

            //Act
            car.Color = color;

            //Assert
            Assert.Equal(color, car.Color);
        }

        [Fact]
        public void BadEmptyColorCar()
        {
            //Arrange
            int year = 2020;
            string brand = "TestBrand";
            string modelName = "Buster";
            string color = "";
            Car car = new Car(year, brand, modelName);

            //Act & Assert
            Assert.Throws<ArgumentException>( () => car.Color = color);
        }

        [Fact]
        public void BadEmptyColorConstructorCar()
        {
            //Arrange
            int year = 2020;
            string brand = "TestBrand";
            string modelName = "Buster";
            string color = "";
            string regPlate = "asd456";

            //Act & Assert
            Assert.Throws<ArgumentException>(() => new Car(year, brand, modelName,color,regPlate));

        }
    }
}
