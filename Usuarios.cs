using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Caja_UNAPEC
{
    public partial class Usuarios : UserControl
    {
        SqlConnection Con = null;

        public Usuarios()
        {
            InitializeComponent();
        }

        public void InicializarUsuarios(string Conn)
        {
            Con = new SqlConnection(Conn);

            cbxUSUCriterio.SelectedIndex = 0;

            LimpiarCampos();
            HabilitarBotones("A");

            ESTSelectAll();
        }

        private void ESTSelectAll()
        {
            try
            {
                Con.Open();

                string select = "SELECT Identificador_Usuario AS Indentificador, Nombre_Usuario AS Nombre, Accesibilidad_Usuario AS Accesibilidad, Estado_Usuario As Estado FROM Usuarios";
                select += " WHERE " + Criterio() + " LIKE '%" + txtUSUDato.Text + "%'";
                select += " ORDER BY " + Criterio();
                SqlDataAdapter DA = new SqlDataAdapter(select, Con);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dtgUsuarios.DataSource = DT;

                dtgUsuarios.Refresh();
                dtgUsuarios.PerformLayout();

                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al recoger la información de la base de datos \n" + Ex.Message);
            }
        }

        private void BtnUSUGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtUSUNombre.Text;
            string identificador = txtUSUIdentificador.Text;
            string claveR = ObtenerClave();
            string claveE = GetSha1Hash(claveR); 
            string accesibilidad = cbxUSUAccesibilidad.Text;
            string estado = ObtenerEstado();

            try
            {
                Con.Open();

                string Insert = "INSERT INTO Usuarios (Nombre_Usuario, Identificador_Usuario, Clave_Usuario, Accesibilidad_Usuario, Estado_Usuario) VALUES ('";
                Insert += nombre + "' , '" + identificador + "' , '" + claveE + "' , '" + accesibilidad +  "' , '" + estado + "')";
                SqlCommand Query = new SqlCommand(Insert, Con);
                Query.ExecuteNonQuery();

                Con.Close();

                btnUSUGuardar.Enabled = false;

                MessageBox.Show("Usuario registrado.");
                MessageBox.Show("Sea generado la clave para este usuario. \n Haga clik en 'Limpiar' para finalizar.'");

                ESTSelectAll();

                txtUSUClave.Text = claveR;
            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al guardar la información de la base de datos.\n" + Ex.Message);
            }
        }

        private void BtnUSUModificar_Click(object sender, EventArgs e)
        {
            string id = txtUSUID.Text;
            string nombre = txtUSUNombre.Text;
            string identificador = txtUSUIdentificador.Text;
            string accesibilidad = cbxUSUAccesibilidad.Text;
            string estado = ObtenerEstado();

            try
            {
                Con.Open();

                string Update = "UPDATE Usuarios SET Nombre_Usuario = '" + nombre + "', Identificador_Usuario = '" + identificador + "', Accesibilidad_Usuario = '" + accesibilidad + "', Estado_Usuario = '" + estado + "' FROM Usuarios WHERE ID_Usuario = " + id + ";";

                SqlCommand Query = new SqlCommand(Update, Con);
                Query.ExecuteNonQuery();

                Con.Close();

                MessageBox.Show("Datos Modificados.");

                LimpiarCampos();
                ESTSelectAll();
            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al actualizar la información de la base de datos.\n" + Ex.Message);
            }
        }

        private void BtnUSUEliminar_Click(object sender, EventArgs e)
        {
            string usuario = txtUSUID.Text;

            try
            {
                Con.Open();

                string delete = "DELETE FROM Usuario WHERE ID_Usuario = '" + usuario + "'";
                SqlCommand Query = new SqlCommand(delete, Con);
                Query.ExecuteNonQuery();

                Con.Close();

                MessageBox.Show("Empleado Eliminado.");

                ESTSelectAll();

                LimpiarCampos();
                HabilitarBotones("A");
            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al eliminar la información de la base de datos.\n" + Ex.Message);
            }
        }

        private void BtnUSULimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnUSUBuscar_Click(object sender, EventArgs e)
        {
            ESTSelectAll();
        }

        private void LimpiarCampos()
        {
            txtUSUID.Clear();
            txtUSUNombre.Clear();
            txtUSUIdentificador.Clear();
            cbxUSUAccesibilidad.SelectedIndex = -1;
            rbUSUActivo.Checked = true;
            txtUSUClave.Clear();

            HabilitarBotones("A");
        }

        private void HabilitarBotones(string C)
        {
            if (C == "A")
            {
                btnUSUGuardar.Enabled = true;
                btnUSUModificar.Enabled = false;
                btnUSUEliminar.Enabled = false;
                btnUSURestablecer.Enabled = false;
            }
            else if (C == "M")
            {
                btnUSUGuardar.Enabled = false;
                btnUSUModificar.Enabled = true;
                btnUSUEliminar.Enabled = true;
                btnUSURestablecer.Enabled = true;
            }
        }

        private string Criterio()
        {
            if (cbxUSUCriterio.Text == "Nombre")
            {
                return "Nombre_Usuario";
            }

            else if (cbxUSUCriterio.Text == "Identificador")
            {
                return "Identificador_Usuario";
            }
            else if (cbxUSUCriterio.Text == "Accesibilidad")
            {
                return "Accesibilidad_Usuario";
            }
            else if (cbxUSUCriterio.Text == "Estado")
            {
                return "Estado_Usuario";
            }
            else return null;
        }

        private string ObtenerEstado()
        {
            if (rbUSUActivo.Checked == true) { rbUSUInactivo.Checked = false; return "Activo"; }
            else if (rbUSUInactivo.Checked == true) { rbUSUActivo.Checked = false; return "Inactivo"; }
            else return "Activo";
        }

        private static Random Generar = new Random();
        public string ObtenerClave()
        {
            string numero = null;

            const string chars = "0123456789";
            numero = new string(Enumerable.Repeat(chars, 7).Select(s => s[Generar.Next(s.Length)]).ToArray());
           
            return numero;
        }

        internal static string GetSha1Hash(string text)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;

            using (var sha1 = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = Encoding.UTF8.GetBytes(text);

                byte[] hash = sha1.ComputeHash(textData);

                return BitConverter.ToString(hash).Replace("-", string.Empty);
            }
        }

        private void DtgUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Row = dtgUsuarios.CurrentRow;

            try
            {
                Con.Open();
                string select = "SELECT ID_Usuario FROM Usuarios WHERE Identificador_Usuario = '" + Row.Cells[0].Value.ToString() + "'";
                SqlDataAdapter DA = new SqlDataAdapter(select, Con);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                string id = DT.Rows[0][0].ToString();

                Con.Close();
                txtUSUID.Text = id;
            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al obtener el ID del servicio.\n" + Ex.Message);
            }

            txtUSUIdentificador.Text = Row.Cells[0].Value.ToString();
            txtUSUNombre.Text = Row.Cells[1].Value.ToString();
            cbxUSUAccesibilidad.Text = Row.Cells[2].Value.ToString();

            if (Row.Cells[3].Value.ToString() == "Activo"){
                rbUSUActivo.Checked = true;
                rbUSUInactivo.Checked = false;

            } else if (Row.Cells[3].Value.ToString() == "Inactivo")
            {
                rbUSUActivo.Checked = false;
                rbUSUInactivo.Checked = true;
            }

            HabilitarBotones("M");
        }

        private void BtnUSURestablecer_Click(object sender, EventArgs e)
        {
            string id = txtUSUID.Text;
            string claveR = ObtenerClave();
            string claveE = GetSha1Hash(claveR);

            try
            {
                Con.Open();
                string UpdatePass = "UPDATE Usuarios SET Clave_Usuario = '" + claveE + "' WHERE ID_Usuario = " + id + ";";

                SqlCommand Query = new SqlCommand(UpdatePass, Con);
                Query.ExecuteNonQuery();

                Con.Close();

                MessageBox.Show("Clave modificada \n Haga clik en 'Limpiar' para continuar.");

                txtUSUClave.Text = claveR;
                ESTSelectAll();
            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al actualizar la información de la base de datos.\n" + Ex.Message);
            }
        }
    }
}
