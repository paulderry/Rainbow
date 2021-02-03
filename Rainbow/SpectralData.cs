using System;
using System.Collections.Generic;
using System.Linq;

namespace Rainbow
{
    public class SpectralData
    {
        private List<SpectralMeasurement> _spectrum;
        private double _interval;

        public SpectralData(List<Double> xaxis, List<Double> yaxis)
        {
            _spectrum = CreateSpectrumList(xaxis, yaxis);
            _interval = CalculateMeasurementInterval(_spectrum);
        }
        /// <summary>
        /// This method creates a list of SpectralMeasurements from two lists representing the signal and the energy
        /// If the lists are not of equal length, an exception is thrown. There is nothing we can do from there.
        /// </summary>
        /// <param name="xaxis"></param>
        /// <param name="yaxis"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private List<SpectralMeasurement> CreateSpectrumList(List<Double> xaxis, List<Double> yaxis)
        {
            List<SpectralMeasurement> lsm = new List<SpectralMeasurement>();
            
            if (xaxis.Count != yaxis.Count)
                throw new Exception("Coordinate lists are not the same length.");
            xaxis.Zip(yaxis, ((energy, signal) => lsm.Append(new SpectralMeasurement(energy, signal))));
            return lsm;
        }

        /// <summary>
        /// This method calculates the interval between two measurements.
        /// The interval is important to know since the midpoint between them is used to calculate the rounding.
        /// </summary>
        /// <param name="spectrum">Internal SpectralMeasurement list</param>
        /// <returns>The average interval between each element in the list.</returns>
        private double CalculateMeasurementInterval(List<SpectralMeasurement> spectrum)
        {
            double interval_sum = 0;
            
            for (int x = 0; x < spectrum.Count - 1; x++)
            {
                var apos = spectrum[x];
                var apoeng = apos.Energy;
                
                var bpos = spectrum[x + 1];
                var bpoeng = bpos.Energy;
                
                var interval = bpoeng - apoeng;
                interval_sum += interval;
            }
            return interval_sum / spectrum.Count;
        }

        public double GetSignalAt(double energy)
        {
            
        }
        
    }
}