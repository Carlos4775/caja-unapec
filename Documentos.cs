using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Caja_UNAPEC
{
    public partial class Documentos : UserControl
    {
        SqlConnection Con = null;
        public Documentos()
        {
            InitializeComponent();
        }

        public void InicializarDocumentos(string Conn)
        {
            Con = new SqlConnection(Conn);

            cbxDCCriterio.SelectedIndex = 0;

            LimpiarCampos();
            HabilitarBotones("A");

            ESTSelectAll();
        }

        private void ESTSelectAll()
        {
            try
            {
                Con.Open();

                string select = "SELECT Nombre_TipoDoc AS Nombre, Descripcion_TipoDoc AS Descripcion FROM Tipo_Documento";
                select += " WHERE " + Criterio() + " LIKE '%" + txtDCDato.Text + "%'";
                select += " ORDER BY " + Criterio();
                SqlDataAdapter DA = new SqlDataAdapter(select, Con);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dtgDocumentos.DataSource = DT;

                dtgDocumentos.Refresh();
                dtgDocumentos.PerformLayout();

                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al recoger la información de la base de datos \n" + Ex.Message);
            }
        }

        private void BtnDCGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtDCNombre.Text;
            string descripcion = txtDCDescripcion.Text;

            try
            {
                Con.Open();

                string Insert = "INSERT INTO Tipo_Documento (Nombre_TipoDoc, Descripcion_TipoDoc) VALUES ('";
                Insert += nombre + "' , '" + descripcion + "')";
                SqlCommand Query = new SqlCommand(Insert, Con);
                Query.ExecuteNonQuery();

                Con.Close();

                MessageBox.Show("Documento registrado.");

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

        private void BtnDCModificar_Click(object sender, EventArgs e)
        {
            string id = txtDCID.Text;
            string nombre = txtDCNombre.Text;
            string descripcion = txtDCDescripcion.Text;

            try
            {
                Con.Open();

                string Update = "UPDATE Tipo_Documento SET Nombre_TipoDoc = '" + nombre + "', Descripcion_TipoDoc = '" + descripcion + "' FROM Tipo_Documento WHERE ID_TipoDoc = '" + id + "'";

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

        private void BtnDCEliminar_Click(object sender, EventArgs e)
        {
            string id = txtDCID.Text;

            try
            {
                Con.Open();

                string Delete = "DELETE FROM Tipo_Documento WHERE ID_TipoDoc = '" + id + "'";
                SqlCommand Query = new SqlCommand(Delete, Con);
                Query.ExecuteNonQuery();

                Con.Close();

                MessageBox.Show("Documento Eliminado.");

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

        private void BtnDCLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnDCBuscar_Click(object sender, EventArgs e)
        {
            ESTSelectAll();
        }

        private void DtgDocumentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Row = dtgDocumentos.CurrentRow;

            try
            {
                Con.Open();
                string select = "SELECT ID_TipoDoc FROM Tipo_Documento WHERE Nombre_TipoDoc = '" + Row.Cells[0].Value.ToString() + "'";
                SqlDataAdapter DA = new SqlDataAdapter(select, Con);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                string id = DT.Rows[0][0].ToString();

                Con.Close();
                txtDCID.Text = id;
            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al obtener el ID del documento.\n" + Ex.Message);
            }

            txtDCNombre.Text = Row.Cells[0].Value.ToString();
            txtDCDescripcion.Text = Row.Cells[1].Value.ToString();

            HabilitarBotones("M");
        }

        private void LimpiarCampos()
        {
            txtDCID.Clear();
            txtDCNombre.Clear();
            txtDCDescripcion.Clear();

            HabilitarBotones("A");
        }

        private void HabilitarBotones(string C)
        {
            if (C == "A")
            {
                btnDCGuardar.Enabled = true;
                btnDCModificar.Enabled = false;
                btnDCEliminar.Enabled = false;
            }
            else if (C == "M")
            {
                btnDCGuardar.Enabled = false;
                btnDCModificar.Enabled = true;
                btnDCEliminar.Enabled = true;
            }
        }

        private string Criterio()
        {
            if (cbxDCCriterio.Text == "Nombre")
            {
                return "Nombre_TipoDoc";
            }

            else if (cbxDCCriterio.Text == "Descripción")
            {
                return "Descripcion_TipoDoc";
            }

            else return null;
        }
    }
}
