using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Memory_Game
{
    public partial class formPartie : Form
    {
        bool autorisationJouer = false;
        PictureBox premierChoix;
        string trouve1,trouve2;
        Random aleatoire = new Random();
        Timer tour = new Timer();
        int tempsTour = 10;
    
        Timer timer = new Timer {Interval = 1000};
        int scoreJoueur1, scoreJoueur2 = 0;
        bool identificationJoueur = false;
        string nomFichierSauvegarde = "fSauvegarde";
        PictureBox picTriche;
        int indexTriche;
        int triche = 0;


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
                    Properties.Resources.image8,
                    Properties.Resources.image9,
                    Properties.Resources.image10

                };
            }
        }

        public formPartie()
        {
            InitializeComponent();
            
        }

        private void formPartie_Load(object sender, EventArgs e)
        {
            
            labelScoreJoueur1.Visible = false;
            labelScoreJoueur2.Visible = false;
            labelTour.Visible = false;
            labelTemps.Visible = false;
            buttonSauvegarderPartie.Visible = false;
            buttonAnnuler.Visible = false;
            buttonDemarrerPartie.Visible = false;
            buttonSauvegarderPartie.Visible = false;
            buttonTriche.Visible = false;

            labelJoueur1.Visible = false;
            labelJoueur2.Visible = false;
            textBoxJoueur1.Visible = false;
            textBoxJoueur2.Visible = false;

            



            foreach (var picturebox in imagesPictureBoxes)
            {
                picturebox.Visible = false;
            }
            var secondesTemps = TimeSpan.FromSeconds(tempsTour);
            labelTemps.Text=secondesTemps.ToString();
        }



        private void demarrerTempsJeu()
        {
            timer.Start();
            timer.Tick += delegate
            {
                tempsTour--;
                if (tempsTour < 0)
                {
                    buttonTriche.Enabled = true;
                    foreach (PictureBox pic in imagesPictureBoxes)
                    {
                        pic.Enabled = true;
                    }

                    timer.Stop();
                    //initialiserImages();
                    identificationJoueur = !identificationJoueur;

                    if (identificationJoueur == false)
                        labelTour.Text = "Tour : " + textBoxJoueur1.Text;

                    else
                        labelTour.Text = "Tour : " + textBoxJoueur2.Text;


                    tempsTour = 10;
                    cacherImages();
                    timer.Start();
                }

                var secondesTemps = TimeSpan.FromSeconds(tempsTour);
                labelTemps.Text = secondesTemps.ToString();
                
            };
            
        }

      
        private void initialiserImages()
        {
            foreach (var image in imagesPictureBoxes)
            {
                image.Tag = null;
                image.Visible = true;
                MessageBox.Show(image.Name);
            }
            tempsTour = 10;
            
            cacherImages();
            melangerAleatoireImages();
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
        {            
            foreach(var image in imagesCartes)
            {
                reserverPictureBox().Tag = image;
                reserverPictureBox().Tag = image;
            }
        }

        private void CLICKTIMER_TICK(object sender, EventArgs e)
        {
            foreach(PictureBox img in imagesPictureBoxes)
            {
                if (img.Name == trouve1 || img.Name == trouve2)
                {
                    img.Visible = false;
                }
            }
            buttonTriche.Enabled = true;
            trouve1 = trouve2 = "";
            cacherImages();
            autorisationJouer = true;
            tour.Stop();
        }

        private void buttonTriche_Click(object sender, EventArgs e)
        {
            do
            {
                indexTriche = aleatoire.Next(0, imagesPictureBoxes.Count());
                picTriche = imagesPictureBoxes[indexTriche];

                foreach (PictureBox item in imagesPictureBoxes)
                {
                    if (picTriche == item)
                    {
                        item.Image = (Image)item.Tag;
                    }
                }
                triche = 0;
                timerTriche.Start();
                buttonTriche.Enabled = false;
            }
            while (imagesPictureBoxes[indexTriche].Visible == false);
           
        }

        private void timerTriche_Tick(object sender, EventArgs e)
        {
            if(triche==0)
            {
                cacherImages();
                triche++;
            }
        }

        private void selectionnerImage_Click(object sender, EventArgs e)
        {
            

            if (!autorisationJouer) 
                return;
            
            PictureBox image = (PictureBox)sender;
            image.Enabled = false;
            

           if (premierChoix == null)
            {
                premierChoix = image;
                buttonTriche.Enabled = false;
                image.Image = (Image)image.Tag;
                return;
            }
            






            image.Image = (Image)image.Tag;
            
            
            
            
            
            if (image.Image == premierChoix.Image && image!=premierChoix)
            {
                
                //cacherImages();
                trouve1 = premierChoix.Name;
                trouve2 = image.Name;

                if (identificationJoueur == false)
                {
                    scoreJoueur1++;
                }

                else
                {
                    scoreJoueur2++;
                }

                labelScoreJoueur1.Text = textBoxJoueur1.Text + " : " + scoreJoueur1.ToString();
                labelScoreJoueur2.Text = textBoxJoueur2.Text +" : " + scoreJoueur2.ToString();
                tour.Start();
                //buttonTriche.Enabled = true;
                timerTriche.Stop();


                image.Visible = premierChoix.Visible = false;
                premierChoix = image;


            }

            else 
            {
                autorisationJouer = false;
                tour.Start();
                //buttonTriche.Enabled = true;
                timerTriche.Stop();
                premierChoix.Enabled = true;
                tempsTour = 0;
                
            }


            premierChoix = null;

            if (imagesPictureBoxes.Any(i=>i.Visible))
            {
                //buttonTriche.Enabled = true;
                timerTriche.Stop();
                tour.Start();
                return;

            }

            finPartie(); 
           
        }

       

        void finPartie()
        {
            if (File.Exists(nomFichierSauvegarde))
            File.Delete(nomFichierSauvegarde);

                if (scoreJoueur1 > scoreJoueur2)
            {
                MessageBox.Show("Bravo " + textBoxJoueur1.Text + "\ntu as gagné la partie, voici les scores: \n\n" + textBoxJoueur1.Text + " : " + scoreJoueur1 + "\n" + textBoxJoueur2.Text + " : " + scoreJoueur2);
            }
            else if (scoreJoueur1 < scoreJoueur2)
            {
                MessageBox.Show("Bravo " + textBoxJoueur2.Text + "\ntu as gagné la partie, voici les scores: \n\n" + textBoxJoueur1.Text + " : " + scoreJoueur1 + "\n" + textBoxJoueur2.Text + " : " + scoreJoueur2);
            }
            else
            {
                MessageBox.Show("Egalité, voici les scores: \n\n" + textBoxJoueur1.Text + " : " + scoreJoueur1 + "\n" + textBoxJoueur1.Text + " : " + scoreJoueur2);
            }


            DialogResult reponseRecommencer = MessageBox.Show("Voullez-vous recommencez ?", "Partie terminée", MessageBoxButtons.YesNo);
            if (reponseRecommencer == DialogResult.Yes)
            {
                initialiserImages();
                identificationJoueur = false;
                scoreJoueur1 = 0;
                scoreJoueur2 = 0;
                labelScoreJoueur1.Text = textBoxJoueur1.Text + " : " + scoreJoueur1.ToString();
                labelScoreJoueur2.Text = textBoxJoueur2.Text + " : " + scoreJoueur2.ToString();
            }

            else
            {
                this.Close();
            }
        }

        private void buttonDemarrerPartie_Click(object sender, EventArgs e)
        {
            if(textBoxJoueur1.Text == "" || textBoxJoueur2.Text =="")
                MessageBox.Show("Veuillez encoder les deux pseudos");

            else
            {
                foreach (var picturebox in imagesPictureBoxes)
                {
                    picturebox.Visible = true;
                }

                labelScoreJoueur1.Visible = true;
                labelScoreJoueur2.Visible = true;
                labelTour.Visible = true;
                labelTemps.Visible = true;

                labelTour.Text = "Tour : " + textBoxJoueur1.Text;
                labelScoreJoueur1.Text = textBoxJoueur1.Text + " : " + scoreJoueur1.ToString();
                labelScoreJoueur2.Text = textBoxJoueur2.Text + " : " + scoreJoueur2.ToString();

                autorisationJouer = true;

                melangerAleatoireImages();
                cacherImages();
                
                demarrerTempsJeu();
               

                tour.Interval = 1000;
                tour.Tick += CLICKTIMER_TICK;
                buttonDemarrerPartie.Visible = false;
                buttonReprendrePartie.Visible = false;
                buttonSauvegarderPartie.Visible = true;
                buttonTriche.Visible = true;
                buttonCommencerPartie.Visible = false;
                buttonAnnuler.Visible = false;

                labelJoueur1.Visible = false;
                labelJoueur2.Visible = false;
                textBoxJoueur1.Visible = false;
                textBoxJoueur2.Visible = false;

                accueil1.Visible = false;
                accueil2.Visible = false;
                labelAccueil.Visible = false;
                labelCreateur.Visible = false;
            }
         
        }

        private void buttonCommencerPartie_Click(object sender, EventArgs e)
        {
            labelJoueur1.Visible = false;
            labelJoueur2.Visible = false;
            textBoxJoueur1.Visible = false;
            textBoxJoueur2.Visible = false;
            

            buttonDemarrerPartie.Visible = true;
            buttonAnnuler.Visible = true;

            buttonCommencerPartie.Visible = false;
            buttonReprendrePartie.Visible = false;

            labelJoueur1.Visible = true;
            labelJoueur2.Visible = true;
            textBoxJoueur1.Visible = true;
            textBoxJoueur2.Visible = true;
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            buttonCommencerPartie.Visible = true;
            buttonReprendrePartie.Visible = true;

            buttonDemarrerPartie.Visible = false;
            buttonAnnuler.Visible = false;

            labelJoueur1.Visible = false;
            labelJoueur2.Visible = false;
            textBoxJoueur1.Visible = false;
            textBoxJoueur2.Visible = false;

            textBoxJoueur1.Text = "Joueur1";
            textBoxJoueur2.Text = "Joueur2";

        }

      

        private void buttonReprendrePartie_Click(object sender, EventArgs e)
        {

            if (File.Exists(nomFichierSauvegarde))
            {
                Object ss = Sauvegarde.Recup(nomFichierSauvegarde);
                DonneesSauvegarde recupPartie = (DonneesSauvegarde)ss;


                foreach (PictureBox pic in imagesPictureBoxes)
                {
                    foreach (PictureBoxDonnees p in recupPartie.pictureBoxesDonnees)
                        if (pic.Name == p.nom)
                        {
                            pic.Tag = p.image;
                            pic.Visible = true;
                        }
                }

                labelScoreJoueur1.Visible = true;
                labelScoreJoueur2.Visible = true;
                labelTour.Visible = true;
                labelTemps.Visible = true;

                labelJoueur1.Visible = false;
                labelJoueur2.Visible = false;
                textBoxJoueur1.Visible = false;
                textBoxJoueur2.Visible = false;

                buttonDemarrerPartie.Visible = false;
                buttonReprendrePartie.Visible = false;
                buttonSauvegarderPartie.Visible = true;
                buttonTriche.Visible = true;

                textBoxJoueur1.Text = recupPartie.nomJoueur1.ToString();
                textBoxJoueur2.Text = recupPartie.nomJoueur2.ToString();

                accueil1.Visible = false;
                accueil2.Visible = false;
                labelAccueil.Visible = false;
                labelCreateur.Visible = false;

                labelScoreJoueur1.Text = textBoxJoueur1.Text + " : " + recupPartie.scoreJoueur1.ToString();
                labelScoreJoueur2.Text = textBoxJoueur2.Text + " : " + recupPartie.scoreJoueur2.ToString();


                var secondesTemps = TimeSpan.FromSeconds(recupPartie.tempsTour);
                labelTemps.Text = secondesTemps.ToString();

                if (recupPartie.identification == false)
                {
                    labelTour.Text = textBoxJoueur1.Text;
                }
                else
                {
                    labelTour.Text = textBoxJoueur2.Text;
                }


                tempsTour = recupPartie.tempsTour;
                identificationJoueur = recupPartie.identification;
                scoreJoueur1 = recupPartie.scoreJoueur1;
                scoreJoueur2 = recupPartie.scoreJoueur2;
                trouve1 = recupPartie.trouve1;
                trouve2 = recupPartie.trouve2;

                autorisationJouer = true;

                cacherImages();
                demarrerTempsJeu();

                tour.Interval = 1000;
                tour.Tick += CLICKTIMER_TICK;

                buttonDemarrerPartie.Visible = false;
                buttonReprendrePartie.Visible = false;
                buttonSauvegarderPartie.Visible = true;
                buttonCommencerPartie.Visible = false;
            }

            else
                MessageBox.Show("Aucune partie sauvegardée ! \nVeuillez commencer une nouvelle partie ");

           
        }


        private void buttonSauvegarderPartie_Click(object sender, EventArgs e)
        {
            DonneesSauvegarde sauvegarde = new DonneesSauvegarde();
            List<PictureBoxDonnees> imagesSauvegarder = new List<PictureBoxDonnees>();
            

            foreach (PictureBox picB in imagesPictureBoxes)
            {
                if(picB.Visible == true)
                {
                    PictureBoxDonnees sauv = new PictureBoxDonnees();
                    sauv.nom = picB.Name;
                    sauv.image = (Image)picB.Tag;
                    imagesSauvegarder.Add(sauv);
                }
            }

            sauvegarde.nomJoueur1 = textBoxJoueur1.Text;
            sauvegarde.nomJoueur2 = textBoxJoueur2.Text;
            sauvegarde.scoreJoueur1 = scoreJoueur1;
            sauvegarde.scoreJoueur2 = scoreJoueur2;
            sauvegarde.identification = identificationJoueur;
            sauvegarde.tempsTour = tempsTour;
            sauvegarde.pictureBoxesDonnees = imagesSauvegarder;
            sauvegarde.trouve1 = trouve1;
            sauvegarde.trouve2 = trouve2;


          
            Sauvegarde.Sauve(nomFichierSauvegarde, sauvegarde);
            MessageBox.Show("Partie sauvegardée");
            

        }
    }
}
