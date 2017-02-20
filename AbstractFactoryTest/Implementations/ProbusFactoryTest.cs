using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractFactory.Implementations.Probus;

namespace AbstractFactoryTest.Implementations
{
    [TestClass]
    public class ProbusFactoryTest
    {
        [TestMethod]
        public void ProbusFactory_CreateTemperaturSensor_ReturnsProbusTemperatureSensor()
        {
            ProbusFactory factory = new ProbusFactory();

            Assert.IsTrue(factory.createTemperatureSensor().GetType() == typeof(ProbusTemperaturSensor), "Returns wrong type");
        }

        [TestMethod]
        public void ProbusFactory_CreateShutterActor_ReturnsProbusShutterActor()
        {
            ProbusFactory factory = new ProbusFactory();

            Assert.IsTrue(factory.createShutterActor().GetType() == typeof(ProbusShutterActor), "Returns wrong type");
        }
    }
}
