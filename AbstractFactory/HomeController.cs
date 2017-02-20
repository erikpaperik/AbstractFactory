using System;
using AbstractFactory.Base;

namespace AbstractFactory
{
    public class HomeController
    {
        HomeAutomationFabric fabric;

        TemperatureSensor temperatureSensor;
        ShutterActor shutterActor;

        public HomeController(HomeAutomationFabric fabric)
        {
            this.fabric = fabric;
            createProducts();
        }

        public TemperatureSensor getTemperatureSensor()
        {
            return this.temperatureSensor;
        }

        public ShutterActor getShutterActor()
        {
            return this.shutterActor;
        }

        private void createProducts()
        {
            this.temperatureSensor = this.fabric.createTemperatureSensor();
            this.shutterActor = this.fabric.createShutterActor();
        }
    }
}
