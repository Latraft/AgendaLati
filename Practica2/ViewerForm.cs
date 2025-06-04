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
    public partial class ViewerForm : Form
    {
        public ViewerForm(string rutaImagen)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(rutaImagen);
            this.Text = Path.GetFileName(rutaImagen);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
