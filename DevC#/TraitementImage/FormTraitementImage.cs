using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace traitementImage2
{
    public partial class FormTraitementImage : Form
    {
        Bitmap p, p2;
        string path;


        public FormTraitementImage()
        {
            InitializeComponent();
        }


        private void buttonOpenFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();//instancie objet
            dialog.CheckPathExists = true;
            dialog.CheckFileExists = true;
            // si l'utilisateur a bien sélectionner un fichier
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path = dialog.FileName;

                // on va charger le fichier ‘path’ dans un bitmap
                p = new Bitmap(path); // crée le bitmap avec le fichier ‘path’
                p2 = new Bitmap(path);

                textFilePath.Text = path;

                imageOrigine.Image = p;
                imageOrigine.SizeMode = PictureBoxSizeMode.StretchImage;





            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            int x, y;
            x = p.Size.Width;
            y = p.Size.Height;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Color c = p.GetPixel(i, j);
                    p2.SetPixel(i, j, c);
                }
            }

            //p2.Save(path);

            imageRetouche.Image = p2;
            imageRetouche.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void noir_Click(object sender, EventArgs e)
        {
            int x, y;
            x = p2.Size.Width;
            y = p2.Size.Height;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    p2.SetPixel(i, j, Color.Black);
                }
            }

            imageRetouche.Image = p2;
            imageRetouche.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void noRed_Click(object sender, EventArgs e)
        {
            int x, y;
            x = p2.Size.Width;
            y = p2.Size.Height;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Color c = p.GetPixel(i, j); //recupere le pixel de couleur

                    int r = c.R;            //recupere la valeur de la composante rouge
                    int v = c.G;
                    int b = c.B;

                    Color adapt = Color.FromArgb(0, v, b);

                    p2.SetPixel(i, j, adapt);

                }
            }

            imageRetouche.Image = p2;
            imageRetouche.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void noBlue_Click(object sender, EventArgs e)
        {
            int x, y;
            x = p2.Size.Width;
            y = p2.Size.Height;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Color c = p.GetPixel(i, j); //recupere le pixel de couleur

                    int r = c.R;            //recupere la valeur de la composante rouge
                    int v = c.G;
                    int b = c.B;

                    Color adapt = Color.FromArgb(r, v, 0);

                    p2.SetPixel(i, j, adapt);

                }
            }

            imageRetouche.Image = p2;
            imageRetouche.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void noGreen_Click(object sender, EventArgs e)
        {
            int x, y;
            x = p2.Size.Width;
            y = p2.Size.Height;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Color c = p.GetPixel(i, j); //recupere le pixel de couleur

                    int r = c.R;            //recupere la valeur de la composante rouge
                    int v = c.G;
                    int b = c.B;

                    Color adapt = Color.FromArgb(r, 0, b);

                    p2.SetPixel(i, j, adapt);

                }
            }

            imageRetouche.Image = p2;
            imageRetouche.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void grey_Click(object sender, EventArgs e)
        {
            int x, y;
            x = p2.Size.Width;
            y = p2.Size.Height;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Color c = p.GetPixel(i, j); //recupere le pixel de couleur

                    int r = c.R;            //recupere la valeur de la composante rouge
                    int v = c.G;
                    int b = c.B;

                    int gris = (r + v + b) / 3;

                    Color adapt = Color.FromArgb(gris, gris, gris);

                    p2.SetPixel(i, j, adapt);

                }
            }

            imageRetouche.Image = p2;
            imageRetouche.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label3.Text = hScrollBar1.Value.ToString();
        }

        

        private void negative_Click(object sender, EventArgs e)
        {
            int x, y;
            x = p2.Size.Width;
            y = p2.Size.Height;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Color c = p.GetPixel(i, j); //recupere le pixel de couleur

                    int r = c.R;            //recupere la valeur de la composante rouge
                    int v = c.G;
                    int b = c.B;



                    Color adapt = Color.FromArgb(255 - r, 255 - v, 255 - b);

                    p2.SetPixel(i, j, adapt);

                }
            }

            imageRetouche.Image = p2;
            imageRetouche.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void flou_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < p.Width - 1; i++)
            {
                for (int j = 1; j < p.Height - 1; j++)
                {
                    Color c1 = p.GetPixel(i - 1, j - 1);
                    Color c2 = p.GetPixel(i - 1, j);
                    Color c3 = p.GetPixel(i - 1, j + 1);
                    Color c4 = p.GetPixel(i, j - 1);
                    Color c5 = p.GetPixel(i, j);
                    Color c6 = p.GetPixel(i, j + 1);
                    Color c7 = p.GetPixel(i + 1, j - 1);
                    Color c8 = p.GetPixel(i + 1, j);
                    Color c9 = p.GetPixel(i + 1, j + 1);
                    int rouge = (c1.R + c2.R + c3.R + c4.R + c5.R + c6.R + c7.R + c8.R + c9.R);
                    int vert = (c1.G + c2.G + c3.G + c4.G + c5.G + c6.G + c7.G + c8.G + c9.G);
                    int bleu = (c1.B + c2.B + c3.B + c4.B + c5.B + c6.B + c7.B + c8.B + c9.B); 
                    p2.SetPixel(i, j, Color.FromArgb(rouge / 9, vert / 9, bleu / 9));
                }
            }

            imageRetouche.Image = p2;
            imageRetouche.SizeMode = PictureBoxSizeMode.StretchImage;
                  



        }


        private void LumUp_Click_1(object sender, EventArgs e)
        {
            int seuil = hScrollBarLum.Value;
            
            for (int i = 0; i < p.Width - 1; i++)
            {
                for (int j = 0; j < p.Height - 1; j++)
                {
                    Color c = p.GetPixel(i, j);

                    int r = c.R;            //recupere la valeur de la composante rouge
                    int v = c.G;
                    int b = c.B;

                    /*if (r < 229 && v < 229 && b < 229)
                        p2.SetPixel(i, j, Color.FromArgb(r + 25, v + 25, b + 25));
                    else if (r > 229 && v < 229 && b < 229)
                        p2.SetPixel(i, j, Color.FromArgb(255, v + 25, b + 25));
                    else if (v > 229 && r < 229 && b < 229)
                        p2.SetPixel(i, j, Color.FromArgb(r + 25, 255, b + 25));
                    else if (r < 229 && v < 229 && b > 229)
                        p2.SetPixel(i, j, Color.FromArgb(r + 25, v + 25, 255));*/

                    if (r + seuil  > 255)
                        r = 255;
                    else
                        r += seuil;

                    if (b + seuil > 255)
                        b = 255;
                    else
                        b += seuil;

                    if (v + seuil > 255)
                        v = 255;
                    else
                        v += seuil;


                    p2.SetPixel(i, j, Color.FromArgb(r, v, b));



                }
            }

            imageRetouche.Image = p2;
            imageRetouche.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void contrasteUp_Click(object sender, EventArgs e)
        {
            int seuil = hScrollBarContraste.Value;

            int x, y;
            x = p2.Size.Width;
            y = p2.Size.Height;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Color c = p.GetPixel(i, j); //recupere le pixel de couleur

                    int r = c.R;            //recupere la valeur de la composante rouge
                    int v = c.G;
                    int b = c.B;



                    if (r < 128 && (r - seuil > 0))
                        r -= seuil;
                    else if (r - seuil < 0)
                        r = 0;

                    if (v < 128 && (v - seuil > 0))
                        v -= seuil;
                    else if(v - seuil < 0)
                        v = 0;

                    if (b < 128 && (b - seuil > 0))
                        b -= seuil;
                    else if(b-seuil < 0)
                        b = 0;



                    if (r > 128 && (r + seuil < 255))
                        r += seuil;
                    else if (r + seuil > 255)
                        r = 255;
                    

                    if (v > 128 && (v + seuil < 255))
                        v += seuil;
                    else if (v + seuil > 255)
                        v = 255;


                    if (b > 128 && (b + seuil < 255))
                        b += seuil;
                    else if (b + seuil > 255)
                        b = 255;
                    



                    p2.SetPixel(i, j, Color.FromArgb(r, v, b));



                }
            }

            imageRetouche.Image = p2;
            imageRetouche.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void hScrollBarContraste_Scroll(object sender, ScrollEventArgs e)
        {
            label4.Text = hScrollBarContraste.Value.ToString();
        }

        private void hScrollBarLum_Scroll(object sender, ScrollEventArgs e)
        {
            label5.Text = hScrollBarLum.Value.ToString();
        }

        private void binarisation_Click(object sender, EventArgs e)
        {
            int seuil = hScrollBar1.Value;

            int x, y;
            x = p2.Size.Width;
            y = p2.Size.Height;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Color c = p.GetPixel(i, j); //recupere le pixel de couleur

                    int r = c.R;            //recupere la valeur de la composante rouge
                    int v = c.G;
                    int b = c.B;

                    int gris = (r + v + b) / 3;

                    if (gris < seuil)
                    {
                        p2.SetPixel(i, j, Color.Black);
                    }
                    else
                    {
                        p2.SetPixel(i, j, Color.White);
                    }



                }
            }

            imageRetouche.Image = p2;
            imageRetouche.SizeMode = PictureBoxSizeMode.StretchImage;

        }



    }
}        



