using System;

namespace AdapterLibrary
{
    
    public class AnalogWatch
    {
        public double HourHandAngle { get; set; }  
        public double MinuteHandAngle { get; set; } 

        public AnalogWatch(double hourAngle, double minuteAngle)
        {
            HourHandAngle = hourAngle;
            MinuteHandAngle = minuteAngle;
        }

        public void ShowAnalogData()
        {
            Console.WriteLine($"[Analog Watch] Hour Hand: {HourHandAngle}°, Minute Hand: {MinuteHandAngle}°");
        }
    }
}