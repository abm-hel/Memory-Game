using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Game
{

    [SerializableAttribute]
    public class DonneesSauvegarde
    {
        string Trouve1, Trouve2, NomJoueur1, NomJoueur2;
        int ScoreJoueur1, ScoreJoueur2, TempsTour;
        bool Identification;
        List<PictureBoxDonnees> PicsBoxesDonnees;



        public string trouve1
        {
            get { return Trouve1; }
            set { Trouve1 = value; }
        }

        public string trouve2
        {
            get { return Trouve2; }
            set { Trouve2 = value; }
        }



        public int scoreJoueur1
        {
            get { return ScoreJoueur1; }
            set { ScoreJoueur1 = value; }
        }

        public int scoreJoueur2
        {
            get { return ScoreJoueur2; }
            set { ScoreJoueur2 = value; }
        }

        public string nomJoueur1
        {
            get { return NomJoueur1; }
            set { NomJoueur1 = value; }
        }

        public string nomJoueur2
        {
            get { return NomJoueur2; }
            set { NomJoueur2 = value; }
        }


        public int tempsTour
        {
            get { return TempsTour; }
            set { TempsTour = value; }
        }

        public bool identification
        {
            get { return Identification; }
            set { Identification = value; }
        }

       public List<PictureBoxDonnees> pictureBoxesDonnees
        {
            get { return PicsBoxesDonnees; }
            set { PicsBoxesDonnees = value; }
        }




    }
}
