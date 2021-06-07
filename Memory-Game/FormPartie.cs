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
        PictureBox premierChoix;
        Random aleatoire = new Random();
        Timer tour = new Timer();
        int tempsTour = 90;
        Timer timer = new Timer {Interval = 1000};

        public formPartie()
        {
            InitializeComponent();
        }

        private PictureBox[] imagesPictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }

        private static IEnumerable<Image> imagesCartes
        {
            get
            {
                return new Image[]
                {
                    Properties.Resources.image1,
                    Properties.Resources.image2,
                    Properties.Resources.image3,
                    Properties.Resources.image4,
                    Properties.Resources.image5,
                    Properties.Resources.image6,
                    Properties.Resources.image7,
                    Properties.Resources.image8
                };
            }
        }

        private void demarrerTempsJeu()
        {
            timer.Start();
            timer.Tick += delegate
            {
                tempsTour--;
                if (tempsTour < 0)
                {
                    timer.Stop();
                    MessageBox.Show("temps écoulé !");
                    initialiserImages();
                }

                var secondesTemps = TimeSpan.FromSeconds(tempsTour);
                labelTemps.Text = "00: " + tempsTour.ToString();
            };
        }

      
        private void initialiserImages()
        {
            foreach (var image in imagesPictureBoxes)
            {
                image.Tag = null;
                image.Visible = true;
            }

            cacherImages();
            melangerAleatoireImages();
            tempsTour = 90;
            timer.Start();
        }

        private void cacherImages()
        {
            foreach (var image in imagesPictureBoxes)
            {
                image.Image = Properties.Resources.random;
            }
        }

        private PictureBox reserverPictureBox()
        {
            int i;
            do
            {
                i = aleatoire.Next(0, imagesPictureBoxes.Count());
                
            }
            while (imagesPictureBoxes[i].Tag != null);
            return imagesPictureBoxes[i]; 
        }

        private void melangerAleatoireImages()
        {            foreach(var image in imagesCartes)
            {
                reserverPictureBox().Tag = image;
                reserverPictureBox().Tag = image;
            }
        }

        private void CLICKTIMER_TICK(object sender, EventArgs e)
        {
            cacherImages();
            autorisationJouer = true;
            tour.Stop();
        }

        private void selectionnerImage_Click(object sender, EventArgs e)
        {
            if (!autorisationJouer) 
                return;

            var image = (PictureBox)sender;
            
            if (premierChoix == null)
            {
                premierChoix = image;
                image.Image = (Image)image.Tag;
                return;
            }

            image.Image = (Image)image.Tag;
            



            if (image.Image == premierChoix.Image && image!=premierChoix)
            {
                image.Visible = premierChoix.Visible = false;
                premierChoix = image;
            }
            
             
            else 
            {
                autorisationJouer = false;
                tour.Start();
            }

            premierChoix = null;

            if(imagesPictureBoxes.Any(i=>i.Visible))
            {
                return;
            }

            DialogResult reponseRecommencer = MessageBox.Show("Voullez-vous recommencez?", "Partie terminée",MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                initialiserImages();
            }

            else
            {
                this.Close();
            }
        }

        private void buttonDemarrerPartie_Click(object sender, EventArgs e)
        {
            autorisationJouer = true;
            melangerAleatoireImages();
            cacherImages();
            demarrerTempsJeu();
            tour.Interval = 1000;
            tour.Tick += CLICKTIMER_TICK;
            buttonDemarrerPartie.Enabled = false;
        }
    }
}
