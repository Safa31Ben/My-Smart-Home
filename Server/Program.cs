using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannel ch = new TcpChannel(8090);
            ChannelServices.RegisterChannel(ch);

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Server.ServerImp), "Server",
                                                            WellKnownObjectMode.SingleCall);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Server.ServerImp), "Envoi Notification",
                                                            WellKnownObjectMode.SingleCall);

            Console.WriteLine("Le * serveur * est en cours d'exécution.");
            Console.WriteLine("**********************************************");
            Console.Read();
        }
    }
}
