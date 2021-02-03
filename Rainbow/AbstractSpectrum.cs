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

        public AbstractSpectrum(List<Double> energy, List<Double> signal, EnergyType etype, SignalType sigtype)
        {
            _spectral_data = new SpectralData(energy, signal);
            _spectrum_type = etype;
            _signal_type = sigtype;
        }

        public double GetSignalAt(double energy)
        {
            return _spectral_data.GetSignalAt(energy);
        }
    }
}