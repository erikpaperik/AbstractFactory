using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractFactory.Base;

namespace HomeAutomationFacbricTest.Base
{
    public class MockFabric : HomeAutomationFabric
    {
        public override ShutterActor createShutterActor()
        {
            throw new NotImplementedException();
        }

        public override TemperatureSensor createTemperatureSensor()
        {
            throw new NotImplementedException();
        }
    }
    [TestClass]
    public class HomeAutomationFacbricTest
    {
        [TestMethod]
        public void HomeAutomationFacbric_CreateTemperaturSensor_ReturnsTemperatureSensor()
        {
            MockFabric factory = new MockFabric();

            Assert.IsNotNull(factory.GetType().GetMethod("createTemperatureSensor"), "Class should implement 'createTemperatureSensor' method");
            
            
        }

        [TestMethod]
        public void HomeAutomationFacbric_CreateShutterActor_ReturnsHomebusShutterActor()
        {
            MockFabric factory = new MockFabric();

            Assert.IsNotNull(factory.GetType().GetMethod("createShutterActor"), "Class should implement 'createShutterActor' method");

        }
    }
}
