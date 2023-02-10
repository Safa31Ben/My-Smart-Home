using System;

using Système_de_surveillance_bib;

namespace Systeme_de_surveillance
{
    class SystemeDeSurveillanceImp : MarshalByRefObject, ConsulterHumidite, ConsulterTempérature
    {

        public double getTemperature()
        {
            return Systeme_de_surveillance.Program.temp;
        }

        public double getHumidite()
        {
            return Systeme_de_surveillance.Program.humid;
        }
    }
}
