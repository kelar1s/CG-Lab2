using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenTK;
using OpenTK.Graphics.OpenGL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2TomogramVisualizer
{
    public partial class Form1 : Form
    {
        private Bin binReader = new Bin();
        private View view = new View();
        private bool loaded = false;
        private int currentLayer = 0;
        private int frameCount;
        private DateTime nextFPSUpdate;
        private bool needReload = false;

        int mode = 0;

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Application.Idle += ApplicationIdle;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                string path = opf.FileName;
                binReader.ReadBIN(path);
                view.SetupView(glControl1.Width, glControl1.Height);
                loaded = true;
                glControl1.Invalidate();
                trackBar1.Maximum = Bin.Y - 1;
            }
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (loaded)
            {
                switch (mode)
                {
                    case 1:
                        view.DrawQuads(currentLayer);
                        glControl1.SwapBuffers();
                        break;

                    case 0:
                        if (needReload)
                        {
                            view.GenerateTextureImage(currentLayer);
                            view.Load2DTexture();
                            needReload = false;
                        }
                        view.DrawTexture();
                        glControl1.SwapBuffers();
                        break;
                }

            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            currentLayer = trackBar1.Value;
            needReload = true;
        }

        private void ApplicationIdle(object sender, EventArgs e)
        {
            while (glControl1.IsIdle)
            {
                DisplayFPS();
                glControl1.Invalidate();
            }
        }

        private void DisplayFPS()
        {
            if (DateTime.Now >= nextFPSUpdate)
            {
                this.Text = String.Format("CT Visualizer (fps = {0})", frameCount);
                nextFPSUpdate = DateTime.Now.AddSeconds(1);
                frameCount = 0;
            }
            frameCount++;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mode = comboBox1.SelectedIndex;
        }

        private void MinimumTrackBar2_Scroll(object sender, EventArgs e)
        {
            needReload = true;
            view.Min = MinimumTrackBar2.Value;
            MaximumTrackBar3.Maximum = 255 - MinimumTrackBar2.Value;
            MaximumTrackBar3Label2.Text = MaximumTrackBar3.Value.ToString();
            MinimumTrackBar2Label.Text = MinimumTrackBar2.Value.ToString();
        }

        private void MaximumTrackBar3_Scroll(object sender, EventArgs e)
        {
            needReload = true;
            view.WidthA = MaximumTrackBar3.Value;
            MaximumTrackBar3Label2.Text = MaximumTrackBar3.Value.ToString();
        }
    }
}
