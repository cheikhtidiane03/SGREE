using SGREE.Models;

namespace EXAMEN_SGREE
{
    public static class SessionUtilisateur
    {
        public static Utilisateur UtilisateurConnecte { get; private set; }

        public static bool EstConnecte => UtilisateurConnecte != null;

        public static bool EstAdmin =>
            EstConnecte && UtilisateurConnecte.Role == "Admin";

        public static void Ouvrir(Utilisateur u)
        {
            UtilisateurConnecte = u;
        }

        public static void Fermer()
        {
            UtilisateurConnecte = null;
        }
    }
}