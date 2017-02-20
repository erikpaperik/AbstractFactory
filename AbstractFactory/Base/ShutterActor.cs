using System;

namespace AbstractFactory.Base
{
    public abstract class ShutterActor
    {
        private float currentPosition;

        public float getCurrentPosition()
        {
            return this.currentPosition;
        }

        public virtual void up(float value)
        {
            float targetValue = this.currentPosition - value;
            this.currentPosition = targetValue < 100 ? 0 : targetValue;
        }

        public virtual void down(float value)
        {
            float targetValue = this.currentPosition + value;
            this.currentPosition = targetValue > 100 ? 100 : targetValue;
        }
    }
}
