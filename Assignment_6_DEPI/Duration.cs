using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6_DEPI
{
    class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        // Constructors
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            Normalize();
        }

        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            totalSeconds %= 3600;
            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
        }

        private void Normalize()
        {
            if (Seconds >= 60)
            {
                Minutes += Seconds / 60;
                Seconds %= 60;
            }
            if (Minutes >= 60)
            {
                Hours += Minutes / 60;
                Minutes %= 60;
            }
        }

        public override string ToString()
        {
            if (Hours == 0 && Minutes > 0)
                return $"Minutes :{Minutes}, Seconds :{Seconds}";
            if (Hours == 0 && Minutes == 0)
                return $"Seconds :{Seconds}";

            return $"Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Duration d)
            {
                return Hours == d.Hours && Minutes == d.Minutes && Seconds == d.Seconds;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
    }
}