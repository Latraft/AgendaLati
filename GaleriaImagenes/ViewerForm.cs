using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaleriaImagenes
{
    public partial class ViewerForm : Form
    {
        public ViewerForm(string rutaImagen)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(rutaImagen);
            this.Text = Path.GetFileName(rutaImagen);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            // Aquí va el código que quieras ejecutar al hacer clic en la imagen
        }
    }
}






