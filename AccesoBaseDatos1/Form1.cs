using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AccesoBaseDatos1
{
    public partial class Form1 : Form
    {
        private string Servidor = "DESKTOP-THMI1RO";
        private string Basedatos = "ESCOLAR";
        private string UsuarioId = "sa";
        private string Password = "sa2024";

        private void EjecutaComando(string ConsultaSQL)
        {
            try
            {
                string strConn = $"Server={Servidor};" +
                    $"Database={Basedatos};" +
                    $"User Id={UsuarioId};" +
                    $"Password={Password}";

                if(chkSQLServer.Checked)
                {
                    SqlConnection conn = new SqlConnection(strConn);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = ConsultaSQL;
                    cmd.ExecuteNonQuery();
                }

                llenarGrid();

            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error en el sistema");
            }
        }
        private void llenarGrid()
        {
            try
            {
                string strConn = $"Server={Servidor};" +
                    $"Database={Basedatos};" +
                    $"User Id={UsuarioId};" +
                    $"Password={Password}";

                if (chkSQLServer.Checked)
                {
                    SqlConnection conn = new SqlConnection(strConn);
                    conn.Open();

                    string sqlQuery = "select * from Alumnos";
                    SqlDataAdapter adp = new SqlDataAdapter(sqlQuery, conn);

                    DataSet ds = new DataSet();
                    adp.Fill(ds, "Alumnos");
                    dgvAlumnos.DataSource = ds.Tables[0];
                }

                dgvAlumnos.Refresh();
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error en el sistema");
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearBD_Click(object sender, EventArgs e)
        {
            try
            {              
                string strConn = $"Server={Servidor};" +
                    $"Database=master;" +
                    $"User Id={UsuarioId};" +
                    $"Password={Password}";

                if (chkSQLServer.Checked)
                {
                    SqlConnection conn = new SqlConnection(strConn);
                    conn.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "Crear Base de datos";
                    cmd.ExecuteNonQuery();

                }


            }
            catch (SqlException  Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            catch (Exception Ex )
            {
                MessageBox.Show("Error en el sistema");
            }
        }

        private void btnCreaTabla_Click(object sender, EventArgs e)
        {
            EjecutaComando("CREATE TABLE " +
                    "Alumnos (NoControl varchar(10), nombre varchar(50), carrera varchar(50)");
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtNoControl.Text) &&
                    !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                    !string.IsNullOrWhiteSpace(txtCarrera.Text)) 
                {
                    string strConn = $"Server={Servidor};" +
                                     $"Database={Basedatos};" +
                                     $"User Id={UsuarioId};" +
                                     $"Password={Password}";

                    if (chkSQLServer.Checked)
                    {
                        using (SqlConnection conn = new SqlConnection(strConn))
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandText = "INSERT INTO Alumnos (NoControl, nombre, carrera) " + "VALUES (@NoControl, @Nombre, @Carrera)";

                            cmd.Parameters.AddWithValue("@NoControl", txtNoControl.Text);
                            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                            cmd.Parameters.AddWithValue("@Carrera", txtCarrera.Text);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    llenarGrid();
                    MessageBox.Show("Se inserto Alumno!!");
                }
                else
                {
                    MessageBox.Show("Todos los campos son obligatorios grr");
                }
            }
            catch (SqlException Ex)
            {
                MessageBox.Show("Error SQL: " + Ex.Message);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error en el sistema: " + Ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkSQLServer.Checked = true;
            llenarGrid();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void btnCrearBD_Click_1(object sender, EventArgs e)
        {
            btnCrearBD_Click(sender, e);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string strConn = $"Server={Servidor};" +
                    $"Database={Basedatos};" +
                    $"User Id={UsuarioId};" +
                    $"Password={Password}";

                if (chkSQLServer.Checked)
                {
                    SqlConnection conn = new SqlConnection(strConn);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "Poner Alumnos y nombres = '" + txtNombre.Text +
                        "', carrera = '" + txtCarrera.Text +
                        " WHERE NoControl = '" + txtNoControl.Text + "'";
                    cmd.ExecuteNonQuery();
                }

                llenarGrid();
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error en el sistema!!");
            }
        }

        private void btnCreaTabla_Click_1(object sender, EventArgs e)
        {
             try
    {
        string strConn = $"Server={Servidor};" +
                         $"Database={Basedatos};" +
                         $"User Id={UsuarioId};" +
                         $"Password={Password}";

        if (chkSQLServer.Checked)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "CREATE TABLE Alumnos (" +
                              "NoControl VARCHAR(10) PRIMARY KEY, " +
                              "nombre VARCHAR(50), " +
                              "carrera VARCHAR(50) )";
            cmd.ExecuteNonQuery();
        }

        MessageBox.Show("Tabla 'Alumnos' creada correctamente!!!");
    }
    catch (SqlException Ex)
    {
        MessageBox.Show("Error SQL: " + Ex.Message);
    }
    catch (Exception Ex)
    {
        MessageBox.Show("Error en el sistema: " + Ex.Message);
    }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNoControl.Text.Trim().Length > 0)
                {
                    string strConn = $"Server={Servidor};" +
                                     $"Database={Basedatos};" +
                                     $"User Id={UsuarioId};" +
                                     $"Password={Password}";

                    if (chkSQLServer.Checked)
                    {
                        SqlConnection conn = new SqlConnection(strConn);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "DELETE FROM Alumnos WHERE NoControl = @NoControl";

                        cmd.Parameters.AddWithValue("@NoControl", txtNoControl.Text);
                        cmd.ExecuteNonQuery();
                    }

                    llenarGrid();
                    MessageBox.Show("Alumno eliminado correctamente woo!!");
                }
                else
                {
                    MessageBox.Show("Ingrese el NoControl del alumno a eliminar!");
                }
            }
            catch (SqlException Ex)
            {
                MessageBox.Show("Error SQL: " + Ex.Message);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error en el sistema: " + Ex.Message);
            }
        }

        private void txtCarrera_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtNoControl.Text)) 
                {
                    string strConn = $"Server={Servidor};" +
                                     $"Database={Basedatos};" +
                                     $"User Id={UsuarioId};" +
                                     $"Password={Password}";

                    if (chkSQLServer.Checked)
                    {
                        using (SqlConnection conn = new SqlConnection(strConn))
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandText = "SELECT nombre, carrera FROM Alumnos WHERE NoControl = @NoControl";

                            cmd.Parameters.AddWithValue("@NoControl", txtNoControl.Text);

                            SqlDataReader reader = cmd.ExecuteReader();

                            if (reader.Read()) // Si encontró un resultado
                            {
                                txtNombre.Text = reader["nombre"].ToString();
                                txtCarrera.Text = reader["carrera"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No se encontró un alumno con ese formato gwaaaaa!");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un numero de control!!!");
                }
            }
            catch (SqlException Ex)
            {
                MessageBox.Show("Error SQL: " + Ex.Message);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error en el sistema: " + Ex.Message);
            }
        }
    }
}
