using System;
using AbstractFactory.Base;

namespace AbstractFactory.Implementations.Homebus
{
    public class HomebusShutterActor : ShutterActor
    {
        public override void up(float value)
        {
            float convertedValue = ToHomebusValue(value);
            base.up(convertedValue);
        }

        public override void down(float value)
        {
            float convertedValue = ToHomebusValue(value);
            base.down(value);
        }

        Func<float, float> ToHomebusValue = (float value) => value * 1.05f;
        
    }
}