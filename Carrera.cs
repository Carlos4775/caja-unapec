using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Caja_UNAPEC
{
    public partial class Carrera : UserControl
    {
        SqlConnection Con = null;
        DataTable DT = null;
        public Carrera()
        {
            InitializeComponent();
        }

        public void InicializarCarreras(string Conn)
        {
            Con = new SqlConnection(Conn);

            cbxCARCriterio.SelectedIndex = 0;

            LimpiarCampos();
            HabilitarBotones("A");

            ESTSelectAll();
        }

        private void ESTSelectAll()
        {
            try
            {
                Con.Open();

                string select = "SELECT Codigo_Carrera AS Carrera, Nombre_Carrera AS Nombre, Descripcion_Carrera AS Descripcion FROM Carrera";
                select += " WHERE " + Criterio() + " LIKE '%" + txtCARDato.Text + "%'";
                select += " ORDER BY " + Criterio();
                SqlDataAdapter DA = new SqlDataAdapter(select, Con);
                DT = new DataTable();
                DA.Fill(DT);
                dtgCarreras.DataSource = DT;

                dtgCarreras.Refresh();
                dtgCarreras.PerformLayout();

                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al recoger la información de la base de datos \n" + Ex.Message);
            }
        }

        private void BtnCARGuardar_Click(object sender, EventArgs e)
        {
            string codigo = txtCARCodigo.Text;
            string nombre = txtCARNombre.Text;
            string descripcion = txtCARDescripcion.Text;

            try
            {
                Con.Open();

                string Insert = "INSERT INTO Carrera (Codigo_Carrera, Nombre_Carrera, Descripcion_Carrera) VALUES ('";
                Insert += codigo + "' , '" + nombre + "' , '" + descripcion + "')";
                SqlCommand Query = new SqlCommand(Insert, Con);
                Query.ExecuteNonQuery();

                Con.Close();

                MessageBox.Show("Carrera registrada.");

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

        private void BtnCARModificar_Click(object sender, EventArgs e)
        {
            string codigo = txtCARCodigo.Text;
            string nombre = txtCARNombre.Text;
            string descripcion = txtCARDescripcion.Text;

            try
            {
                Con.Open();

                string Update = "UPDATE Carrera SET Nombre_Carrera = '" + nombre + "', Descripcion_Carrera = '" + descripcion + "' FROM Carrera WHERE Codigo_Carrera = '" + codigo + "'";

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

        private void BtnCAREliminar_Click(object sender, EventArgs e)
        {
            string codigo = txtCARCodigo.Text;

            try
            {
                Con.Open();

                string Delete = "DELETE FROM Carrera WHERE Codigo_Carrera = '" + codigo + "'";
                SqlCommand Query = new SqlCommand(Delete, Con);
                Query.ExecuteNonQuery();

                Con.Close();

                MessageBox.Show("Carrera Eliminada.");

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

        private void BtnCARLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnCARBuscar_Click(object sender, EventArgs e)
        {
            ESTSelectAll();
        }

        private void DtgCarreras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Row = dtgCarreras.CurrentRow;
            txtCARCodigo.Text = Row.Cells[0].Value.ToString();
            txtCARNombre.Text = Row.Cells[1].Value.ToString();
            txtCARDescripcion.Text = Row.Cells[2].Value.ToString();

            HabilitarBotones("M");
        }

        private void LimpiarCampos()
        {
            txtCARCodigo.Clear();
            txtCARNombre.Clear();
            txtCARDescripcion.Clear();

            HabilitarBotones("A");
        }

        private void HabilitarBotones(string C)
        {
            if (C == "A")
            {
                btnCARGuardar.Enabled = true;
                btnCARModificar.Enabled = false;
                btnCAREliminar.Enabled = false;
                txtCARCodigo.ReadOnly = false;
            }
            else if (C == "M")
            {
                btnCARGuardar.Enabled = false;
                btnCARModificar.Enabled = true;
                btnCAREliminar.Enabled = true;
                txtCARCodigo.ReadOnly = true;
            }
        }

        private string Criterio()
        {
            if (cbxCARCriterio.Text == "Codigo")
            {
                return "Codigo_Carrera";
            }

            if (cbxCARCriterio.Text == "Nombre")
            {
                return "Nombre_Carrera";
            }

            else if (cbxCARCriterio.Text == "Descripción")
            {
                return "Descripcion_Carrera";
            }
            
            else return null;
        }

        private void ExportaExcel(DataGridView DGT, string Nombre)
        {
            try
            {
                StreamWriter SW = new StreamWriter(Nombre, false, System.Text.Encoding.GetEncoding(1252));

                SW.WriteLine("sep=|");

                string Header = "";

                foreach (DataGridViewColumn col in DGT.Columns)
                {
                    Header += col.Name + "|";
                }

                Header = Header.Remove(Header.Length - 1);

                SW.WriteLine(Header);

                foreach (DataRow DR in DT.Rows)
                {
                    string Linea = "";

                    foreach (DataColumn DC in DT.Columns)
                    {
                        Linea += DR[DC].ToString() + "|";
                    }
                    SW.WriteLine(Linea);
                }

                SW.Close();
                MessageBox.Show("Archivo exportado correctamente.");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al exportar el archivo.\n" + Ex.Message);
            }
        }

        private void BtnCARExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog ExportarEn = new SaveFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Title = "Guardar en",
                CheckFileExists = false,
                CheckPathExists = true,
                Filter = "Archivo de Exel (*.csv)|*.csv|Todos los arvhivos (*.*)|*.*",
                DefaultExt = ".csv",
                FilterIndex = 1,
                RestoreDirectory = true,
                FileName = "Carreras"
            };

            if (ExportarEn.ShowDialog() == DialogResult.OK)
            {
                string Archivo = ExportarEn.FileName;
                ExportaExcel(dtgCarreras, Archivo);
            }
        }
    }
}
