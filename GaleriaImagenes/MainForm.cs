using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GaleriaImagenes
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true;
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialogo = new FolderBrowserDialog();
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                string[] archivos = Directory.GetFiles(dialogo.SelectedPath, "*.jpg");

                flowLayoutPanel1.Controls.Clear(); // Limpiar anteriores

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
        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {
            // No hacer nada, es solo para evitar el error
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Código al cargar el formulario
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // Código al hacer clic en btnCarg
        }
    }
}

