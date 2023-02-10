using System;

using Système_de_sécurité_bib;

namespace Système_de_sécurité
{
    class AlarmImp : MarshalByRefObject, AlarmInterface
    {
        public void lancerAlarm()
        {
            Console.WriteLine("Une alarme est lancée.");
            Console.WriteLine("**********************************************");
            //Console.Beep(1000, 600000); 10 min
            Console.Beep(1000, 300000); // 5 min
        }
    }
}
