using System;

namespace AbstractFactory.Base
{
    public abstract class HomeAutomationFabric
    {
        public abstract TemperatureSensor createTemperatureSensor();
        public abstract ShutterActor createShutterActor();
    }
}
