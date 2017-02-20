using System;
using AbstractFactory.Base;

namespace AbstractFactory.Implementations.Homebus
{
    public class HomebusTemperaturSensor : TemperatureSensor
    {
        public override float getTemperature()
        {
            float temperature = 42;
            base.setCurrentTemperature(temperature);
            return temperature;
        }
    }
}