namespace GestionContactos
{
    public partial class Namnam : Form
    {
        public Namnam()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Advertencia");
                return;
            }

            string contacto = $"{txtNombre.Text} - {txtTelefono.Text} - {txtCorreo.Text}";
            lstContactos.Items.Add(contacto);
            MessageBox.Show("Contacto agregado correctamente.", "Éxito");
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstContactos.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un contacto para eliminar.", "Advertencia");
                return;
            }

            lstContactos.Items.RemoveAt(lstContactos.SelectedIndex);
            MessageBox.Show("Contacto eliminado.", "Éxito");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtNombre.Focus();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicación de Gestión de Contactos\nDesarrollado en C# con WinForms", "Acerca de");
        }

        private void lstContactos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Advertencia");
                return;
            }

            string contacto = $"{txtNombre.Text} - {txtTelefono.Text} - {txtCorreo.Text}";
            lstContactos.Items.Add(contacto);
            MessageBox.Show("Contacto agregado correctamente.", "Éxito");
            LimpiarCampos();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (lstContactos.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un contacto para eliminar.", "Advertencia");
                return;
            }

            lstContactos.Items.RemoveAt(lstContactos.SelectedIndex);
            MessageBox.Show("Contacto eliminado.", "Éxito");
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirYAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acerdaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicación de Gestión de Contactos\nDesarrollado en C# con WinForms", "Acerca de");
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


