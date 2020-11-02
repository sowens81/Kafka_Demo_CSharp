using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Models;

namespace App.UnitTests.Models
{
    [TestClass]
    public class Car_UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var car = new Car()
            {
                Color = "Blue",
                EngineSize = 2.0,
                Make = "Ford",
                Model = "Focus",
                Year = 2018
            };

            Assert.AreEqual("Blue", car.Color);
            Assert.AreEqual(2.0, car.EngineSize);
            Assert.AreEqual("Ford", car.Make);
            Assert.AreEqual("Focus", car.Model);
            Assert.AreEqual(2018, car.Year);

        }

    }
}
