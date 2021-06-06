using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Game
{
    public partial class formPartie : Form
    {
        bool autorisationJouer = false;
        PictureBox premierInvite;
        Random aleatoire = new Random();
        Timer chrono = new Timer();
        int tempsTour = 60;
        Timer tempsIntervalle = new Timer {Interval = 1000};

        public formPartie()
        {
            InitializeComponent();
        }
    }
}
