using System;

using Système_de_sécurité_bib;

namespace Système_de_sécurité
{
    class CameraImp : MarshalByRefObject, CameraInterface
    {
        public string getLive()
        {
            Console.WriteLine("La camera est consultée.");
            Console.WriteLine("**********************************************");
            return "Live";
        }
    }

}
