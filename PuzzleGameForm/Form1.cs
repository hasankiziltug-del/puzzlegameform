using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PuzzleGameForm
{
    public partial class frmPuzzle : Form
    {
        public frmPuzzle()
        {
            InitializeComponent();
        }

        int step, sec;
        string zaman;
        string[] konum = { "000000", "240000", "000240", "240240" };
        string[] resimler = { "b1.png", "b2.png", "b3.png", "b4.png", "basit.png" };
        Random rnd = new Random();
        int[] dizi;
        int[] yedek;
        PictureBox[] img;
        Image imgYedek;
        int i;
        int[][] yollar = new int[4][];
        bool dragging;
        private void rdbEasy_CheckedChanged(object sender, EventArgs e)
        {
            sec = 1;
        }

        private void rdbMiddle_CheckedChanged(object sender, EventArgs e)
        {
            sec = 2;
        }

        private void rdbHard_CheckedChanged(object sender, EventArgs e)
        {
            sec = 3;
        }

        private void frmPuzzle_Load(object sender, EventArgs e)
        {
            ayarlar();
        }
        private void ayarlar()
        {
            img = new PictureBox[] { img1, img2, img3, img4, imgOriginal };
            yollar[0] = new int[] { 1, 2 };
            yollar[1] = new int[] { 0, 3 };
            yollar[2] = new int[] { 0, 3 };
            yollar[3] = new int[] { 1, 2 };
            dragging = false;

            dizi = new int[] { 4, 4, 4, 4, 4 };
            yedek = new int[] { 0, 1, 2, 3, 4 };
            foreach (var item in img)
            {
                item.Image = null;
            }
            step = 0;
            lblStep.Text = "Adım : " + step;
            zaman = "00:00";
            lblTime.Text = zaman;
            rdbEasy.Enabled = true;
            rdbMiddle.Enabled = true;
            rdbHard.Enabled = true;
            rdbEasy.Checked = true;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Oyuna Başla")
            {
                rdbEasy.Enabled = false;
                rdbMiddle.Enabled = false;
                rdbHard.Enabled = false;
                btnStart.Text = "Oyunu Bitir";
                switch (sec)
                {
                    case 1:
                        dagitKolay();
                        break;
                    case 2:
                        MessageBox.Show(sec.ToString());
                        break;
                    case 3:
                        MessageBox.Show(sec.ToString());
                        break;
                    default:
                        MessageBox.Show("Oyunun Seviyesini Belirleyiniz.");
                        break;
                }
            }
            else
            {
                btnStart.Text = "Oyuna Başla";
                ayarlar();
            }

        }


        private void dagitKolay()
        {
            int secilen;
            int i = 0;

            do
            {
                secilen = rnd.Next(0, 4);
                if (Array.IndexOf(dizi, secilen) == -1)
                {
                    dizi[i] = secilen;
                    i++;
                };
                if (dizi.SequenceEqual(yedek))
                {
                    dizi = new int[] { 4, 4, 4, 4, 4 };
                    i = 0;
                }
            } while (i < 4);

            for (i = 0; i < img.Length; i++)
            {
                img[i].Image = Image.FromFile("Image/" + resimler[dizi[i]]);
            }


            //PictureBox isim=new PictureBox();
            //isim.Name= "img" + 10;
            //isim.Size = new Size(240, 240);
            //isim.Image=Image.FromFile("Image/" + resimler[dizi[0]]);
            //isim.Location = new Point(0, 0);
            //pnlGameArea.Controls.Add(isim);

        }

        private void img_MouseDown(object sender, MouseEventArgs e)
        {
            i = Array.FindIndex(img, val => val.Equals(((PictureBox)sender)));
            img[yollar[i][0]].AllowDrop = true;
            img[yollar[i][1]].AllowDrop = true;
            img[yollar[i][0]].BorderStyle = BorderStyle.FixedSingle;
            img[yollar[i][1]].BorderStyle = BorderStyle.FixedSingle;
        }

        private void img_MouseUp(object sender, MouseEventArgs e)
        {
            if (i > -1)
            {
                dragging = false;
                img[yollar[i][0]].AllowDrop = false;
                img[yollar[i][1]].AllowDrop = false;
                img[yollar[i][0]].BorderStyle = BorderStyle.None;
                img[yollar[i][1]].BorderStyle = BorderStyle.None;
                i = -1;
                yedek = null;
            }
        }

        private void img_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && i > -1)
            {
                ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);
            }
        }

        private void img_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && i > -1)
            {
                e.Effect = DragDropEffects.Copy;
                dragging = true;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                dragging = false;
            }
        }

        private void img_DragDrop(object sender, DragEventArgs e)
        {
            if (i > -1 && dragging == true)
            {
                imgYedek = ((PictureBox)sender).Image;
                Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
                ((PictureBox)sender).Image = getPicture;
                img[i].Image = imgYedek;

                img[yollar[i][0]].AllowDrop = false;
                img[yollar[i][1]].AllowDrop = false;
                img[yollar[i][0]].BorderStyle = BorderStyle.None;
                img[yollar[i][1]].BorderStyle = BorderStyle.None;
                i = -1;
                imgYedek = null;
                dragging = false;
            }
        }
    }
}









