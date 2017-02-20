using System;

namespace AbstractFactory.Base
{
    public abstract class TemperatureSensor
    {
        private float currentTemperature;

        public float getCurrentTemperature()
        {
            return this.currentTemperature;
        }

        protected void setCurrentTemperature(float value)
        {
            this.currentTemperature = value;
        }

        public abstract float getTemperature();

    }
}
