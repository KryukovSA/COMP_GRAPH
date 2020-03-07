using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Bitmap image;
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files|*.png;*.jpg;*.bmp|All files(*.*)|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }

        }

        private void инверсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filtres filtres = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filtres);
            //InvertFilter filter = new InvertFilter();
            //Bitmap resultImage = filter.processImage(image);
            //pictureBox1.Image = resultImage;
            //pictureBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filtres)e.Argument).processImage(image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true)
                image = newImage;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(!e.Cancelled)
            {
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;
        }

        private void размытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filtres filtres = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filtres);
        }

        private void гауссаФильтрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filtres filtres = new GaussianFilter();
            backgroundWorker1.RunWorkerAsync(filtres);
        }

        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filtres filtres = new GrayScaleFiltres();
            backgroundWorker1.RunWorkerAsync(filtres);
        }

        private void сепияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filtres filtres = new SepiyaFiltres();
            backgroundWorker1.RunWorkerAsync(filtres);
        }

        private void увеличениеЯркостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filtres filtres = new brightPlus();
            backgroundWorker1.RunWorkerAsync(filtres);

        }
        private void резкостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filtres filtres = new Rezkost_();
            backgroundWorker1.RunWorkerAsync(filtres);
        }







      

      

        //private void поХToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    char regim = 'X';//выбор режима
        //    Filtres filtres = new Sobel_filtres(regim);
        //    backgroundWorker1.RunWorkerAsync(filtres);
        //}

        //private void поYToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    char regim = 'Y';//выбор режима
        //    Filtres filtres = new Sobel_filtres(regim);
        //    backgroundWorker1.RunWorkerAsync(filtres);
        //}

        private void тиснениеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Filtres filtres = new Tisnenie();
            backgroundWorker1.RunWorkerAsync(filtres);
        }

        private void поворотToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Filtres filter = new Turn();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void волны1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filtres filter = new Wave1();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void волныцToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filtres filter = new Wave2();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void идеальныйОтражательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filtres filter = new Ideal_Otrashatel();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void поXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char regim = 'X';//выбор режима
            Filtres filtres = new Sobel_filtres(regim);
            backgroundWorker1.RunWorkerAsync(filtres);
        }

        private void поYToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            char regim = 'Y';//выбор режима
            Filtres filtres = new Sobel_filtres(regim);
            backgroundWorker1.RunWorkerAsync(filtres);
        }

        private void медианныйФильтрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filtres filter = new MediannFiltres();
            backgroundWorker1.RunWorkerAsync(filter);
        }
    }
}
