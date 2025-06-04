using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialogo = new FolderBrowserDialog();
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                string[] archivos = Directory.GetFiles(dialogo.SelectedPath, "*.jpg");

                flowLayoutPanel1.Controls.Clear(); 

                foreach (string archivo in archivos)
                {
                    PictureBox miniatura = new PictureBox();
                    miniatura.Image = new Bitmap(archivo);
                    miniatura.Width = 100;
                    miniatura.Height = 100;
                    miniatura.SizeMode = PictureBoxSizeMode.Zoom;
                    miniatura.Margin = new Padding(10);
                    miniatura.Cursor = Cursors.Hand;
                    miniatura.Click += (s, ev) =>
                    {
                        ViewerForm visor = new ViewerForm(archivo);
                        visor.ShowDialog();
                    };

                    flowLayoutPanel1.Controls.Add(miniatura);
                }
            }
        }
    }
}
