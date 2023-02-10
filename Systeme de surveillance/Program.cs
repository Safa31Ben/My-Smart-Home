using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Threading.Tasks;

using Système_de_sécurité_bib;

namespace Systeme_de_surveillance
{
    public class Program
    {
        public static double temp;
        public static double humid;

        static void Main(string[] args)
        {
            TcpChannel ch = new TcpChannel(8085);
            ChannelServices.RegisterChannel(ch);

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Systeme_de_surveillance.SystemeDeSurveillanceImp), 
                "température et humidité", WellKnownObjectMode.SingleCall);

            Console.WriteLine("Le serveur * Système de surveillance * est en cours d'exécution.");
            Console.WriteLine("**********************************************");

            consulterTemp();
            Console.Read();
        }
       static async void consulterTemp () {
           AlarmInterface o = (AlarmInterface)Activator.GetObject(typeof(AlarmInterface),
                        "tcp://localhost:8088/Alarm");
             while (true)
            {
                temp = new Random().Next(1, 60);
                humid = new Random().Next(1, 40);
                if (temp > 50)
                    o.lancerAlarm();
                await Task.Delay(500);
            }
        }
    }
}
