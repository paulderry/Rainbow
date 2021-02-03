using System;
using System.Collections.Generic;

namespace Rainbow
{
    public class AbstractSpectrum
    {
        private SpectralData _spectral_data;
        private EnergyType _spectrum_type;
        private SignalType _signal_type;

        public SignalType SpectrumSignal => _signal_type;
        public EnergyType SpectrumEnergy => _spectrum_type;
        
        
    }
}