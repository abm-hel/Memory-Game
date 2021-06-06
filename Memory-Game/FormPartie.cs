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

        private static IEnumerable<Image> imagesCartes
        {
            get
            {
                return new Image[]
                {
                    Properties.Resources._1,
                    Properties.Resources._2,
                    Properties.Resources._3,
                    Properties.Resources._4,
                    Properties.Resources._5,
                    Properties.Resources._6,
                    Properties.Resources._7,
                    Properties.Resources._8
                };
            }
        }

        private void demarrerTempsJeu()
        {
            tempsIntervalle.Start();
            tempsIntervalle.Tick += delegate
            {
                tempsTour--;
                if (tempsTour < 0)
                {
                    tempsIntervalle.Stop();
                    MessageBox.Show("temps écoulé !");
                    initialiserImages();
                }

                var secondesTemps = TimeSpan.FromSeconds(tempsTour);
                labelTemps.Text = "00: " + tempsTour.ToString();
            };
        }
        
        private void initialiserImages()
        {
            foreach (var image in images)
            {
                image.Tag = null;
                image.tag.Visible = true;
            }

            cacherImages();
            melangerAleatoireImages();
            tempsTour = 60;
            tempsIntervalle.Start();
        }

    }
}
