using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool needReload = false;
        bool loaded = false;
        Bin bin;
        int minimum, WIDTH; //для трек бара
        int FrameCount;
        DateTime NextFPSUpdate;

        Viev viev;
        int currentLayer;//
        // tomogr =  new Bin();

        public Form1()
        {
            InitializeComponent();
        }


        private void glControl1_Load(object sender, System.EventArgs e)
        {

        }
        //сам.работа
        private void trackBar2_Scroll(object sender, EventArgs e)  // значение минимума
        {
            
            minimum = trackBar2.Value;
        }

        private void trackBar3_Scroll(object sender, EventArgs e) //ширина
        {
           
            WIDTH = trackBar3.Value;
        }




          ///////////////////////////////
        void displayFPS()
        {
            if(DateTime.Now >= NextFPSUpdate)
            {
                this.Text = String.Format("CT Vizualizer (fps = {0})", FrameCount);
                NextFPSUpdate = DateTime.Now.AddSeconds(1);
                FrameCount = 0;
            }
            FrameCount++;
        }




        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                bin = new Bin();
                viev = new Viev();

                string str = dialog.FileName;
                bin.readBIN(str);
                viev.SetupViev(glControl1.Width, glControl1.Height);
                loaded = true;
                glControl1.Invalidate();


            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Maximum = minimum + WIDTH;
            currentLayer = trackBar1.Value;
            needReload = true;//
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
          
        }



        private void glControl1_Paint(object sender, PaintEventArgs e) //сначала дергаем трак бар 2 и 3 , только потом первый
        {
            if (loaded)
            {

                if (radioButton2.Checked)
                {
                    if (needReload)
                    {

                        viev.generateTextureImage(currentLayer);

                        viev.Load2DTexture();//
                        needReload = false;//
                                      
                    }


                    viev.drawTexture();///
                    glControl1.SwapBuffers();// и это в условии
                }
                else if (radioButton1.Checked)
                {
                 
                    viev.DrawQuards(currentLayer);
                    glControl1.SwapBuffers();
                }
                else
                {
                    viev.QuardStrip(currentLayer);
                    glControl1.SwapBuffers();
                }




            }
        }




        void Applicaton_Idle(object sender, EventArgs e)
        {
            while(glControl1.IsIdle)
            {
                displayFPS();
                glControl1.Invalidate();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            Application.Idle += Applicaton_Idle; 


        }
       

    }

    


}