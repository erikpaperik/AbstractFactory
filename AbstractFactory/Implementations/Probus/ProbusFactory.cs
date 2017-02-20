using System;
using AbstractFactory.Base;

namespace AbstractFactory.Implementations.Probus
{
    public class ProbusFactory : HomeAutomationFabric
    {
        public override TemperatureSensor createTemperatureSensor()
        {
            return new ProbusTemperaturSensor();
        }

        public override ShutterActor createShutterActor()
        {
            return new ProbusShutterActor();
        }
    }
}
