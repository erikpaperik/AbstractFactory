using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractFactory.Implementations.Homebus;

namespace AbstractFactoryTest.Implementations
{
    [TestClass]
    public class HomebusFactoryTest
    {
        [TestMethod]
        public void HomebusFactory_CreateTemperaturSensor_ReturnsHomebusTemperatureSensor()
        {
            HomebusFactory factory = new HomebusFactory();

            Assert.IsTrue(factory.createTemperatureSensor().GetType() == typeof(HomebusTemperaturSensor), "Returns wrong type");
        }

        [TestMethod]
        public void HomebusFactory_CreateShutterActor_ReturnsHomebusShutterActor()
        {
            HomebusFactory factory = new HomebusFactory();

            Assert.IsTrue(factory.createShutterActor().GetType() == typeof(HomebusShutterActor), "Returns wrong type");
        }
    }
}
