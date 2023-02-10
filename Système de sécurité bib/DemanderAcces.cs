using System;

using Smart_Home_bib;

namespace Système_de_sécurité_bib
{
    public interface DemanderAcces
    {
        Compte DemanderAcces(string username, String motDePass);
    }
}
