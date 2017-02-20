using System;
using AbstractFactory.Base;

namespace AbstractFactory.Implementations.Homebus
{
    public class HomebusFactory : HomeAutomationFabric
    {
        public override TemperatureSensor createTemperatureSensor()
        {
            return new HomebusTemperaturSensor();
        }

        public override ShutterActor createShutterActor()
        {
            return new HomebusShutterActor();
        }
    }
}
