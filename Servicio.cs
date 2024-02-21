using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Caja_UNAPEC
{
    public partial class Servicio : UserControl
    {
        SqlConnection Con = null;

        public Servicio()
        {
            InitializeComponent();
        }

        public void InicializarServicios(string Conn)
        {
            Con = new SqlConnection(Conn);

            cbxSVCriterio.SelectedIndex = 0;

            LimpiarCampos();
            HabilitarBotones("A");

            ESTSelectAll();
        }

        private void ESTSelectAll()
        {
            try
            {
                Con.Open();

                string select = "SELECT Nombre_Servicio AS Nombre, Descripcion_Servicio AS Descripcion, Monto_Servicio AS Monto FROM Servicios";
                select += " WHERE " + Criterio() + " LIKE '%" + txtSVDato.Text + "%'";
                select += " ORDER BY " + Criterio();
                SqlDataAdapter DA = new SqlDataAdapter(select, Con);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dtgServicios.DataSource = DT;

                dtgServicios.Refresh();
                dtgServicios.PerformLayout();

                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al recoger la información de la base de datos \n" + Ex.Message);
            }
        }

        private void BtnSVGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtSVNombre.Text;
            string descripcion = txtSVDescripcion.Text;
            string monto = txtSVMonto.Text;

            try
            {
                Con.Open();

                string Insert = "INSERT INTO Servicios (Nombre_Servicio, Descripcion_Servicio, , Monto_Servicio) VALUES ('";
                Insert +=  nombre + "' , '" + descripcion + "' , '" + monto + "')";
                SqlCommand Query = new SqlCommand(Insert, Con);
                Query.ExecuteNonQuery();

                Con.Close();

                MessageBox.Show("Servicio registrado.");

                ESTSelectAll();

                LimpiarCampos();
                HabilitarBotones("A");
            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al guardar la información de la base de datos.\n" + Ex.Message);
            }
        }

        private void BtnSVModificar_Click(object sender, EventArgs e)
        {
            string id = txtSVID.Text;
            string nombre = txtSVNombre.Text;
            string descripcion = txtSVDescripcion.Text;
            string monto = txtSVMonto.Text;

            try
            {
                Con.Open();

                string Update = "UPDATE Servicios SET Nombre_Servicio = '" + nombre + "', Descripcion_Servicio = '" + descripcion + "', Monto_Servicio = '" + monto + "' FROM Servicios WHERE ID_Servicio = '" + id + "'";

                SqlCommand Query = new SqlCommand(Update, Con);
                Query.ExecuteNonQuery();

                Con.Close();

                MessageBox.Show("Datos Modificados.");

                ESTSelectAll();

                LimpiarCampos();
                HabilitarBotones("A");
            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al actualizar la información de la base de datos.\n" + Ex.Message);
            }
        }

        private void BtnSVEliminar_Click(object sender, EventArgs e)
        {
            string id = txtSVID.Text;

            try
            {
                Con.Open();

                string Delete = "DELETE FROM Servicios WHERE ID_Servicio = '" + id + "'";
                SqlCommand Query = new SqlCommand(Delete, Con);
                Query.ExecuteNonQuery();

                Con.Close();

                MessageBox.Show("Servicio Eliminado.");

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

        private void BtnSVLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnSVBuscar_Click(object sender, EventArgs e)
        {
            ESTSelectAll();
        }

        private void DtgServicios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Row = dtgServicios.CurrentRow;

            try
            {
                Con.Open();
                string select = "SELECT ID_Servicio FROM Servicios WHERE Nombre_Servicio = '" + Row.Cells[0].Value.ToString() + "'";
                SqlDataAdapter DA = new SqlDataAdapter(select, Con);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                string id = DT.Rows[0][0].ToString();

                Con.Close();
                txtSVID.Text = id;
            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al obtener el ID del servicio.\n" + Ex.Message);
            }

            txtSVNombre.Text = Row.Cells[0].Value.ToString();
            txtSVDescripcion.Text = Row.Cells[1].Value.ToString();
            txtSVMonto.Text = Row.Cells[2].Value.ToString();

            HabilitarBotones("M");
        }

        private void LimpiarCampos()
        {
            txtSVID.Clear();
            txtSVNombre.Clear();
            txtSVDescripcion.Clear();
            txtSVMonto.Clear();

            HabilitarBotones("A");
        }

        private void HabilitarBotones(string C)
        {
            if (C == "A")
            {
                btnSVGuardar.Enabled = true;
                btnSVModificar.Enabled = false;
                btnSVEliminar.Enabled = false;
            }
            else if (C == "M")
            {
                btnSVGuardar.Enabled = false;
                btnSVModificar.Enabled = true;
                btnSVEliminar.Enabled = true;
            }
        }

        private string Criterio()
        {
            if (cbxSVCriterio.Text == "Nombre")
            {
                return "Nombre_Servicio";
            }

            else if (cbxSVCriterio.Text == "Descripción")
            {
                return "Descripcion_Servicio";
            }

            else return null;
        }
    }
}
