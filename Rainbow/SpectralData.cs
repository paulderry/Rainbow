using System;
using System.Collections.Generic;

namespace Rainbow
{
    public class SpectralData : List<SpectralMeasurement>
    {
        private List<SpectralMeasurement> _spectrum;

        public SpectralData(List<Double> xaxis, List<Double> yaxis)
        {
            abscissa = xaxis;
            domain = yaxis;
        }
        
        
    }
}