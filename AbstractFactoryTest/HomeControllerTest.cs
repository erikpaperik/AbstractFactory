using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractFactory;
using AbstractFactory.Implementations.Homebus;
using AbstractFactory.Implementations.Probus;

namespace AbstractFactoryTest
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void HomeController_InitializeWith_HomebusFactory_CreatesHomebusProducts()
        {
            HomebusFactory homebusFactor = new HomebusFactory();
            HomeController homeController = new HomeController(homebusFactor);


            Assert.IsNotNull(homeController.getTemperatureSensor(), "TemperatureSensor should not be null");
            Assert.IsTrue(homeController.getTemperatureSensor().GetType() == typeof(HomebusTemperaturSensor), "HomebusFactory doesn't create the right TemperatureSensor");
            Assert.IsNotNull(homeController.getShutterActor(), "ShutterActor should not be null");
            Assert.IsTrue(homeController.getShutterActor().GetType() == typeof(HomebusShutterActor), "HomebusFactory doesn't create the right ShutterActor");
        }

        [TestMethod]
        public void HomeController_InitializeWith_ProbusFactory_CreatesProbusProducts()
        {
            ProbusFactory homebusFactor = new ProbusFactory();
            HomeController homeController = new HomeController(homebusFactor);


            Assert.IsNotNull(homeController.getTemperatureSensor(), "TemperatureSensor should not be null");
            Assert.IsTrue(homeController.getTemperatureSensor().GetType() == typeof(ProbusTemperaturSensor), "HomebusFactory doesn't create the right TemperatureSensor");
            Assert.IsNotNull(homeController.getShutterActor(), "ShutterActor should not be null");
            Assert.IsTrue(homeController.getShutterActor().GetType() == typeof(ProbusShutterActor), "HomebusFactory doesn't create the right ShutterActor");
        }
    }
}
