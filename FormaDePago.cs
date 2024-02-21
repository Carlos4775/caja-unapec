using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Caja_UNAPEC
{
    public partial class FormaDePago : UserControl 
    {
        SqlConnection Con = null;
        public FormaDePago()
        {
            InitializeComponent();
        }

        public void InicializarFormaDePago(string Conn)
        {
            Con = new SqlConnection(Conn);

            cbxFPCriterio.SelectedIndex = 0;

            LimpiarCampos();
            HabilitarBotones("A");

            ESTSelectAll();
        }

        private void ESTSelectAll()
        {
            try
            {
                Con.Open();

                string Select = "SELECT Nombre_FormaDePago AS Nombre, Descripcion_FormaDePago AS Descripcion FROM FormaDePago";
                Select += " WHERE " + Criterio() + " LIKE '%" + txtFPDato.Text + "%'";
                Select += " ORDER BY " + Criterio();
                SqlDataAdapter DA = new SqlDataAdapter(Select, Con);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                dtgFormaPago.DataSource = DT;

                dtgFormaPago.Refresh();
                dtgFormaPago.PerformLayout();

                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al recoger la información de la base de datos \n" + Ex.Message);
            }
        }

        private void BtnFPGuardar_Click(object sender, EventArgs e)
        {
            string Nombre = txtFPNombre.Text;
            string Descripcion = txtFPDescripcion.Text;

            try
            {
                Con.Open();

                string Insert = "INSERT INTO FormaDePago (Nombre_FormaDePago, Descripcion_FormaDePago) VALUES ('";
                Insert += Nombre + "' , '" + Descripcion + "')";
                SqlCommand Query = new SqlCommand(Insert, Con);
                Query.ExecuteNonQuery();

                Con.Close();

                MessageBox.Show("Forma de pago registrada.");

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

        private void BtnFPModificar_Click(object sender, EventArgs e)
        {
            string ID = txtFPID.Text;
            string Nombre = txtFPNombre.Text;
            string Descripcion = txtFPDescripcion.Text;

            try
            {
                Con.Open();

                string Update = "UPDATE FormaDePago SET Nombre_FormaDePago = '" + Nombre + "', Descripcion_FormaDePago = '" + Descripcion + "' FROM FormaDePago WHERE ID_FormaDePago = '" + ID + "'";

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

        private void BtnFPEliminar_Click(object sender, EventArgs e)
        {
            string ID = txtFPID.Text;

            try
            {
                Con.Open();

                string Delete = "DELETE FROM FormaDePago WHERE ID_FormaDePago = '" + ID + "'";
                SqlCommand Query = new SqlCommand(Delete, Con);
                Query.ExecuteNonQuery();

                Con.Close();

                MessageBox.Show("Forma de pago eliminada.");

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

        private void BtnFPLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnFPBuscar_Click(object sender, EventArgs e)
        {
            ESTSelectAll();
        }

        private void DtgFormaPago_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Row = dtgFormaPago.CurrentRow;

            try
            {
                Con.Open();
                string Select = "SELECT ID_FormaDePago FROM FormaDePago WHERE Nombre_FormaDePago = '" + Row.Cells[0].Value.ToString() + "'";
                SqlDataAdapter DA = new SqlDataAdapter(Select, Con);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                string ID = DT.Rows[0][0].ToString();

                Con.Close();
                txtFPID.Text = ID;
            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al obtener el ID del documento.\n" + Ex.Message);
            }

            txtFPNombre.Text = Row.Cells[0].Value.ToString();
            txtFPDescripcion.Text = Row.Cells[1].Value.ToString();

            HabilitarBotones("M");
        }

        private void LimpiarCampos()
        {
            txtFPID.Clear();
            txtFPNombre.Clear();
            txtFPDescripcion.Clear();

            HabilitarBotones("A");
        }

        private void HabilitarBotones(string C)
        {
            if (C == "A")
            {
                btnFPGuardar.Enabled = true;
                btnFPModificar.Enabled = false;
                btnFPEliminar.Enabled = false;
            }
            else if (C == "M")
            {
                btnFPGuardar.Enabled = false;
                btnFPModificar.Enabled = true;
                btnFPEliminar.Enabled = true;
            }
        }

        private string Criterio()
        {
            if (cbxFPCriterio.Text == "Nombre")
            {
                return "Nombre_FormaDePago";
            }

            else if (cbxFPCriterio.Text == "Descripción")
            {
                return "Descripcion_FormaDePago";
            }

            else return null;
        }
    }
}
