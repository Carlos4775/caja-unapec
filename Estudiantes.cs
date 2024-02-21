using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Caja_UNAPEC
{
    public partial class Estudiantes : UserControl
    {
        SqlConnection Con = null;
        DataTable DT = null;

        public Estudiantes()
        {
            InitializeComponent();
        }

        public void InicializarEstudiante(string Conn)
        {
            Con = new SqlConnection(Conn);

            cbxETDCriterio.SelectedIndex = 0;

            HabilitarBotones("A");

            LimpiarCampos();
            ObtenerCarreras();
            ESTSelectAll();
        }

        private void BtnETDBuscar_Click(object sender, EventArgs e)
        {
            ESTSelectAll();
        }

        private void BtnETDGuardar_Click(object sender, EventArgs e)
        {
            string matricula = txtETDMatricula.Text;
            string nombre = txtETDNombre.Text;
            string apellido = txtETDApellido.Text;
            string cedula = txtETDCedula.Text;
            string carrera = ObtenerCarrera();
            string estado = ObtenerEstado();

            if (ValidarCedula(cedula) == false)
            {
                MessageBox.Show("La cédula no es valida");
                return;
            }

            try
            {
                Con.Open();

                string Insert = "INSERT INTO Estudiante (Matricula_Estudiante, Nombre_Estudiante, Apellido_Estudiante, Cedula_Estudiante, Codigo_Carrera, Estado_Estudiante) VALUES ('";
                Insert += matricula + "' , '" + nombre + "' , '" + apellido + "' , '" + cedula + "' , '" + carrera + "' , '" + estado + "')";
                SqlCommand Query = new SqlCommand(Insert, Con);
                Query.ExecuteNonQuery();

                Con.Close();

                MessageBox.Show("Estudiante registrado.");

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

        private void ESTSelectAll()
        {
            try
            {
                Con.Open();

                string select = "SELECT Matricula_Estudiante AS Matrícula, Nombre_Estudiante AS Nombre, Apellido_Estudiante AS Apellido, Cedula_Estudiante AS Cédula, Codigo_Carrera As Código, Estado_Estudiante AS Estado, Balance_Estudiante AS Balance FROM Estudiante";
                select += " WHERE " + Criterio() + " LIKE '%" + txtETDDato.Text + "%'";
                select += " ORDER BY " + Criterio();
                SqlDataAdapter DA = new SqlDataAdapter(select, Con);
                DT = new DataTable();
                DA.Fill(DT);
                dtgEstudiantes.DataSource = DT;

                dtgEstudiantes.Refresh();

                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al recoger la información de la base de datos.\n" + Ex.Message);
            }
        }

        private string Criterio()
        {
            if (cbxETDCriterio.Text == "Matrícula")
            {
                return "Matricula_Estudiante";
            }
            else if (cbxETDCriterio.Text == "Nombre")
            {
                return "Nombre_Estudiante";
            }
            else if (cbxETDCriterio.Text == "Apellido")
            {
                return "Apellido_Estudiante";
            }
            else if (cbxETDCriterio.Text == "Cédula")
            {
                return "Cedula_Estudiante";
            }
            else if (cbxETDCriterio.Text == "Carrera")
            {
                return "Codigo_Carrera";
            }
            else if (cbxETDCriterio.Text == "Estado")
            {
                return "Estado_Estudiante";
            }
            else return "null";
        }

        private string ObtenerEstado()
        {
            if (rbETDActivo.Checked == true) { rbETDInactivo.Checked = false; return "Activo"; }
            else if (rbETDInactivo.Checked == true) { rbETDActivo.Checked = false; return "Inactivo"; }
            else return "Activo";
        }

        private string ObtenerCarrera()
        {
            try
            {
                Con.Open();
                string Select = "SELECT Codigo_Carrera FROM Carrera WHERE Nombre_Carrera = '" + cbxETDCarrera.Text + "'";
                SqlDataAdapter DA = new SqlDataAdapter(Select, Con);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                string carrera = DT.Rows[0][0].ToString();
                
                Con.Close();
                return carrera;
            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al obtener el código de la carrera.\n" + Ex.Message);
                return null;
            }
        }

        private void ObtenerCarreras()
        {
            cbxETDCarrera.Items.Clear();

            try
            {
                Con.Open();
                string select = "SELECT Nombre_Carrera AS Carrera FROM Carrera";
                SqlDataAdapter DA = new SqlDataAdapter(select, Con);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                foreach (DataRow DR in DT.Rows)
                {
                    cbxETDCarrera.Items.Add(DR["Carrera"].ToString()); ;
                }

                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al recoger las carreras.\n" + Ex.Message);
            }
        }

        private void BtnETDLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void HabilitarBotones(string C)
        {
            if (C == "A")
            {
                btnETDGuardar.Enabled = true;
                btnETDModificar.Enabled = false;
                btnETDEliminar.Enabled = false;
                txtETDMatricula.ReadOnly = false;
            } 
            else if (C == "M")
            {
                btnETDGuardar.Enabled = false;
                btnETDModificar.Enabled = true;
                btnETDEliminar.Enabled = true;
                txtETDMatricula.ReadOnly = true;
            }
        }

        private void LimpiarCampos()
        {
            txtETDMatricula.Clear();
            txtETDNombre.Clear();
            txtETDApellido.Clear();
            txtETDCedula.Clear();
            rbETDActivo.Checked = true;
            cbxETDCarrera.SelectedIndex = -1;
            rbETDActivo.Checked = false;
            rbETDInactivo.Checked = false;

            HabilitarBotones("A");
        }

        private void DtgEstudiantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Row = dtgEstudiantes.CurrentRow;
            txtETDMatricula.Text = Row.Cells[0].Value.ToString();
            txtETDNombre.Text = Row.Cells[1].Value.ToString();
            txtETDApellido.Text = Row.Cells[2].Value.ToString();
            txtETDCedula.Text = Row.Cells[3].Value.ToString();
            txtETDBalance.Text = Row.Cells[6].Value.ToString();

            try
            {
                Con.Open();
                string select = "SELECT Nombre_Carrera FROM Carrera WHERE Codigo_Carrera = '" + Row.Cells[4].Value.ToString() + "'";
                SqlDataAdapter DA = new SqlDataAdapter(select, Con);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                string carrera = DT.Rows[0][0].ToString();

                Con.Close();
                cbxETDCarrera.Text = carrera;
            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al obtener el nombre de la carrera.\n" + Ex.Message);
            }

            if (Row.Cells[5].Value.ToString() == "Activo") { rbETDActivo.Checked = true; rbETDInactivo.Checked = false; }
            else if (Row.Cells[5].Value.ToString() == "Inactivo") { rbETDActivo.Checked = false; rbETDInactivo.Checked = true; }

            HabilitarBotones("M");
        }

        private void BtnETDModificar_Click(object sender, EventArgs e)
        {
            string matricula = txtETDMatricula.Text;
            string nombre = txtETDNombre.Text;
            string apellido = txtETDApellido.Text;
            string cedula = txtETDCedula.Text;
            string carrera = ObtenerCarrera();
            string estado = ObtenerEstado();

            if (ValidarCedula(cedula) == false)
            {
                MessageBox.Show("La cédula no es valida");
                return;
            }

            try
            {
                Con.Open();

                string Update = "UPDATE Estudiante SET Nombre_Estudiante = '" + nombre + "', Apellido_Estudiante = '" + apellido + "', Cedula_Estudiante = '" + cedula + "', Codigo_Carrera = '" + carrera + "', Estado_Estudiante = '" + estado + "' FROM Estudiante WHERE Matricula_Estudiante = '" + matricula + "'";

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

        private void BtnETDEliminar_Click(object sender, EventArgs e)
        {
            string matricula = txtETDMatricula.Text;

            try
            {
                Con.Open();

                string Delete = "DELETE FROM Estudiante WHERE Matricula_Estudiante = '" + matricula + "'";
                SqlCommand Query = new SqlCommand(Delete, Con);
                Query.ExecuteNonQuery();

                Con.Close();

                MessageBox.Show("Estudiante Eliminado.");

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

        public static bool ValidarCedula(string pCedula)
        {
            int vnTotal = 0;
            string vcCedula = pCedula.Replace("-", "");
            int pLongCed = vcCedula.Trim().Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (pLongCed < 11 || pLongCed > 11)
                return false;

            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = int.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += int.Parse(vCalculo.ToString().Substring(0, 1)) + int.Parse(vCalculo.ToString().Substring(1, 1));
            }

            if (vnTotal % 10 == 0)
                return true;
            else
                return false;
        }

        private void ExportaExcel(DataGridView DGT, string nombre)
        {
            try
            {
                StreamWriter SW = new StreamWriter(nombre, false, System.Text.Encoding.GetEncoding(1252));

                SW.WriteLine("sep=,");

                string header = "";

                foreach (DataGridViewColumn col in DGT.Columns)
                {
                    header += col.Name + ",";
                }
                header = header.Remove(header.Length - 1);
                
                SW.WriteLine(header);

                foreach (DataRow DR in DT.Rows)
                {
                    string linea = "";
                    foreach (DataColumn DC in DT.Columns)
                    {
                        linea += DR[DC].ToString() + ",";
                    }
                    SW.WriteLine(linea);
                }

                SW.Close();
                MessageBox.Show("Archivo exportado correctamente.");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al exportar el archivo.\n" + Ex.Message);
            }   
        }

        private void BtnETDExportar_Click(object sender, EventArgs e)
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
                FileName = "Estudiantes"
            };

            if (ExportarEn.ShowDialog() == DialogResult.OK)
            {
                string archivo = ExportarEn.FileName;
                ExportaExcel(dtgEstudiantes, archivo);
            }
        }
    }
}
