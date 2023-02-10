using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Système_de_sécurité
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannel ch = new TcpChannel(8088);
            ChannelServices.RegisterChannel(ch);

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(DemanderAccesImp), "Demander acces",
                                                            WellKnownObjectMode.SingleCall);

           /* RemotingConfiguration.RegisterWellKnownServiceType(typeof(CameraImp), "Camera",
                                                            WellKnownObjectMode.SingleCall);*/

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(AlarmImp), "Alarm",
                                                            WellKnownObjectMode.SingleCall);
            
            Console.WriteLine("Le serveur * Système de sécurité * est en cours d'exécution.");
            Console.WriteLine("**********************************************");
            Console.Read();
        }
    }
}
