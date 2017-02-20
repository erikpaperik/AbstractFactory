using System;
using AbstractFactory.Base;

namespace AbstractFactory.Implementations.Probus
{
    public class ProbusTemperaturSensor : TemperatureSensor
    {
        public override float getTemperature()
        {
            float temperature = 21;
            base.setCurrentTemperature(temperature);
            return temperature;
        }
    }
}