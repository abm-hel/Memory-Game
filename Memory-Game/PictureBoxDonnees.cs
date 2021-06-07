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
    public class PictureBoxDonnees
    {
        string Nom;
        Image Image;

        public string nom
        {
            get { return Nom; }
            set { Nom = value; }
        }

        public Image image
        {
            get { return Image; }
            set { Image = value; }
        }
    }
}
