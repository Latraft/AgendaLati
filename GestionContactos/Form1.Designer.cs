namespace GestionContactos
{
    partial class Namnam
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitulo = new Label();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            lstContactos = new ListBox();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirYAyudaToolStripMenuItem = new ToolStripMenuItem();
            acerdaDeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AccessibleName = "";
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(138, 58);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(120, 15);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Gestión de Contactos";
            labelTitulo.Click += label1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(158, 105);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(292, 105);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 2;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(417, 105);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(100, 23);
            txtCorreo.TabIndex = 3;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(158, 181);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agragar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(158, 210);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(119, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Borrar contacto";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(239, 181);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // lstContactos
            // 
            lstContactos.FormattingEnabled = true;
            lstContactos.ItemHeight = 15;
            lstContactos.Location = new Point(458, 181);
            lstContactos.Name = "lstContactos";
            lstContactos.Size = new Size(178, 64);
            lstContactos.TabIndex = 7;
            lstContactos.SelectedIndexChanged += lstContactos_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirYAyudaToolStripMenuItem, acerdaDeToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            archivoToolStripMenuItem.Click += archivoToolStripMenuItem_Click;
            // 
            // salirYAyudaToolStripMenuItem
            // 
            salirYAyudaToolStripMenuItem.Name = "salirYAyudaToolStripMenuItem";
            salirYAyudaToolStripMenuItem.Size = new Size(180, 22);
            salirYAyudaToolStripMenuItem.Text = "Salir y Ayuda";
            salirYAyudaToolStripMenuItem.Click += salirYAyudaToolStripMenuItem_Click;
            // 
            // acerdaDeToolStripMenuItem
            // 
            acerdaDeToolStripMenuItem.Name = "acerdaDeToolStripMenuItem";
            acerdaDeToolStripMenuItem.Size = new Size(180, 22);
            acerdaDeToolStripMenuItem.Text = "Acerda de";
            acerdaDeToolStripMenuItem.Click += acerdaDeToolStripMenuItem_Click;
            // 
            // Namnam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstContactos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(labelTitulo);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Namnam";
            Text = "Reset";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private ListBox lstContactos;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirYAyudaToolStripMenuItem;
        private ToolStripMenuItem acerdaDeToolStripMenuItem;
    }
}
