using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Memory_Game
{
    
    public class Sauvegarde
    {
        public static void Sauve(string fichier, Object objet)
        {
            if (File.Exists(fichier))
            {
                File.Delete(fichier);
            }
            FileStream flux = new FileStream(fichier, FileMode.Create); 
            BinaryFormatter fbinaire = new BinaryFormatter(); 
            fbinaire.Serialize(flux, objet);
            flux.Close();
        }

        public static Object Recup(string fichier)
        {
            
            if (File.Exists(fichier))
            {
                FileStream flux = new FileStream(fichier, FileMode.Open);
                BinaryFormatter fbinaire = new BinaryFormatter();
                try
                {
                    Object objet = fbinaire.Deserialize(flux);
                    flux.Close();
                    return objet;
                }
                catch
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
