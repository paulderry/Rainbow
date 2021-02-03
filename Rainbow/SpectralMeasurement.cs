using System;

namespace Rainbow
{
    public struct SpectralMeasurement : IComparable
    {
        private double _energy;
        private double _signal;
        
        public int CompareTo(object? obj)
        {
            double delta = 0.10;
            SpectralMeasurement s = (SpectralMeasurement) obj;
            if (s._energy + (s._energy * delta) < this._energy)
            {
                return 1;
            } else if (s._energy + (s._energy * delta) > this._energy)
            {}
        }
    }
}