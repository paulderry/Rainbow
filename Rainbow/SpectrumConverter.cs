using System;

namespace Rainbow
{
    public static class SpectrumConverter
    {

        public static AbstractSpectrum ToAbsorbance(AbstractSpectrum a)
        {
            if (a.SpectrumSignal == SignalType.Transmission)
            {
                //TODO: Convert absorbance to transmission mode.
            }

            return a;
        }

        public static AbstractSpectrum ToTransmission(AbstractSpectrum a)
        {
            if (a.SpectrumSignal == SignalType.Absorbance)
            {
                //TODO: Convert transmission to absorbance.
            }

            return a;
        }

        public static AbstractSpectrum ToNanometers(AbstractSpectrum a)
        {
            throw new NotImplementedException();
        }

        public static AbstractSpectrum ToInverseCentimeters(AbstractSpectrum a)
        {
            throw new NotImplementedException();
        }

        public static AbstractSpectrum ToElectronVolts(AbstractSpectrum a)
        {
            throw new NotImplementedException();
        }
    }
}