using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

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

                string Select = "SELECT Codigo_Carrera AS Carrera, Nombre_Carrera AS Nombre, Descripcion_Carrera AS Descripcion FROM Carrera";
                Select += " WHERE " + Criterio() + " LIKE '%" + txtCARDato.Text + "%'";
                Select += " ORDER BY " + Criterio();
                SqlDataAdapter DA = new SqlDataAdapter(Select, Con);
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

        private void btnCARGuardar_Click(object sender, EventArgs e)
        {
            string Codigo = txtCARCodigo.Text;
            string Nombre = txtCARNombre.Text;
            string Descripcion = txtCARDescripcion.Text;

            try
            {
                Con.Open();

                string Insert = "INSERT INTO Carrera (Codigo_Carrera, Nombre_Carrera, Descripcion_Carrera) VALUES ('";
                Insert += Codigo + "' , '" + Nombre + "' , '" + Descripcion + "')";
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

        private void btnCARModificar_Click(object sender, EventArgs e)
        {
            string Codigo = txtCARCodigo.Text;
            string Nombre = txtCARNombre.Text;
            string Descripcion = txtCARDescripcion.Text;

            try
            {

                Con.Open();

                string Update = "UPDATE Carrera SET Nombre_Carrera = '" + Nombre + "', Descripcion_Carrera = '" + Descripcion + "' FROM Carrera WHERE Codigo_Carrera = '" + Codigo + "'";

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

        private void btnCAREliminar_Click(object sender, EventArgs e)
        {
            string Codigo = txtCARCodigo.Text;

            try
            {
                Con.Open();

                string Delete = "DELETE FROM Carrera WHERE Codigo_Carrera = '" + Codigo + "'";
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

        private void btnCARLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCARBuscar_Click(object sender, EventArgs e)
        {
            ESTSelectAll();
        }
        private void dtgCarreras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnCARExportar_Click(object sender, EventArgs e)
        {
            string Archivo = "";

            SaveFileDialog ExportarEn = new SaveFileDialog();
            ExportarEn.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ExportarEn.Title = "Guardar en";
            ExportarEn.CheckFileExists = false;
            ExportarEn.CheckPathExists = true;
            ExportarEn.Filter = "Archivo de Exel (*.csv)|*.csv|Todos los arvhivos (*.*)|*.*";
            ExportarEn.DefaultExt = ".csv";
            ExportarEn.FilterIndex = 1;
            ExportarEn.RestoreDirectory = true;
            ExportarEn.FileName = "Carreras";
            if (ExportarEn.ShowDialog() == DialogResult.OK)
            {
                Archivo = ExportarEn.FileName;
                ExportaExcel(dtgCarreras, Archivo);
            }

        }
    }
}
