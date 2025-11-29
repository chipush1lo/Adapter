using System;

namespace AdapterLibrary
{
    public class WatchAdapter : IDigitalTime
    {
        private readonly AnalogWatch _analogWatch;

        public WatchAdapter(AnalogWatch analogWatch)
        {
            this._analogWatch = analogWatch;
        }

        public string GetTime()
        {
            double hAngle = _analogWatch.HourHandAngle % 360;
            double mAngle = _analogWatch.MinuteHandAngle % 360;

            int hours = (int)(hAngle / 30);
            if (hours == 0) hours = 12; 

            int minutes = (int)(mAngle / 6);

            return $"{hours:D2}:{minutes:D2}";
        }
    }
}