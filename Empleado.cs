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
    public partial class Empleado : UserControl
    {
        SqlConnection Con = null;
        DataTable DT = null;
        public Empleado()
        {
            InitializeComponent();
        }

        public void InicializarEmpleado(string Conn)
        {
            Con = new SqlConnection(Conn);

            cbxEMPCriterio.SelectedIndex = 0;

            LimpiarCampos();
            HabilitarBotones("A");

            ESTSelectAll();
        }


        private void ESTSelectAll()
        {
            try
            {

                Con.Open();

                string Select = "SELECT Cedula_Empleado AS Cédula, Nombre_Empleado AS Nombre, Apellido_Empleado AS Apellido, Tanda_Empleado AS Tanda, Comision_Empleado As Comisión, Estado_Empleado AS Estado, FechaIngreso_Empleado AS 'Fecha de Ingreso' FROM Empleado";
                Select += " WHERE " + Criterio() + " LIKE '%" + txtEMPDato.Text + "%'";
                Select += " ORDER BY " + Criterio();
                SqlDataAdapter DA = new SqlDataAdapter(Select, Con);
                DT = new DataTable();
                DA.Fill(DT);
                dtgEmpleados.DataSource = DT;

                dtgEmpleados.Refresh();
                dtgEmpleados.PerformLayout();


                Con.Close();

            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al recoger la información de la base de datos \n" + Ex.Message);
            }


        }


        private void dtgEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Row = dtgEmpleados.CurrentRow;
            txtEMPCedula.Text = Row.Cells[0].Value.ToString();
            txtEMPNombre.Text = Row.Cells[1].Value.ToString();
            txtEMPApellido.Text = Row.Cells[2].Value.ToString();

            if (Row.Cells[3].Value.ToString() == "Diurna") { rbEMPDiurna.Checked = true; rbEMPNocturna.Checked = false; }
            else if (Row.Cells[3].Value.ToString() == "Nocturna") { rbEMPDiurna.Checked = false; rbEMPNocturna.Checked = true; }

            txtEMPComision.Text = Row.Cells[4].Value.ToString();

            if (Row.Cells[5].Value.ToString() == "Activo") { rbEMPActivo.Checked = true; rbEMPInactivo.Checked = false; }
            else if (Row.Cells[5].Value.ToString() == "Inactivo") { rbEMPActivo.Checked = false; rbEMPInactivo.Checked = true; }

            dtpEMPFechaIngreso.Value = DateTime.Parse(Row.Cells[6].Value.ToString());

            HabilitarBotones("M");
        }

        private void btnEMPGuardar_Click(object sender, EventArgs e)
        {
            string Cedula = txtEMPCedula.Text;
            string Nombre = txtEMPNombre.Text;
            string Apellido = txtEMPApellido.Text;
            string Tanda = ObtenerTanda();
            string Estado = ObtenerEstado();
            DateTime Fecha = dtpEMPFechaIngreso.Value;
            
            if (ObtenerComision() < 0) { MessageBox.Show("El valor de la comisión es invalido."); return; }
            if (ValidarCedula(Cedula) == false)
            {
                MessageBox.Show("La cédula no es valida");
                return;
            }
            double Comision = ObtenerComision();


            try
            {
                Con.Open();

                string Insert = "INSERT INTO Empleado (Cedula_Empleado, Nombre_Empleado, Apellido_Empleado, Tanda_Empleado, Comision_Empleado, Estado_Empleado, FechaIngreso_Empleado) VALUES ('";
                Insert += Cedula + "' , '" + Nombre + "' , '" + Apellido  + "' , '" + Tanda + "' , '" + Comision + "' , '" + Estado + "' , '" + Fecha + "')";
                SqlCommand Query = new SqlCommand(Insert, Con);
                Query.ExecuteNonQuery();

                Con.Close();

                MessageBox.Show("Empleado registrado.");

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

        private void btnEMPModificar_Click(object sender, EventArgs e)
        {
            string Cedula = txtEMPCedula.Text;
            string Nombre = txtEMPNombre.Text;
            string Apellido = txtEMPApellido.Text;
            string Tanda = ObtenerTanda();
            string Estado = ObtenerEstado();
            DateTime Fecha = dtpEMPFechaIngreso.Value;

            if (ObtenerComision() < 0) { MessageBox.Show("El valor de la comisión es invalido."); return; }
            if (ValidarCedula(Cedula) == false)
            {
                MessageBox.Show("La cédula no es valida");
                return;
            }



            double Comision = ObtenerComision();

            try
            {

                Con.Open();

                string Update = "UPDATE Empleado SET Nombre_Empleado = '" + Nombre + "', Apellido_Empleado = '" + Apellido + "', Tanda_Empleado = '" + Tanda + "', Comision_Empleado = '" + Comision + "', Estado_Empleado = '" + Estado + "', FechaIngreso_Empleado = '" + Fecha + "' FROM Empleado WHERE Cedula_Empleado = '" + Cedula + "'";

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

        private void btnEMPEliminar_Click(object sender, EventArgs e)
        {
            string Cedula = txtEMPCedula.Text;

            try
            {
                Con.Open();

                string Delete = "DELETE FROM Empleado WHERE Cedula_Empleado = '" + Cedula + "'";
                SqlCommand Query = new SqlCommand(Delete, Con);
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

        private void btnEMPLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEMPBuscar_Click(object sender, EventArgs e)
        {
            ESTSelectAll();
        }


        private void LimpiarCampos()
        {
            txtEMPCedula.Clear();
            txtEMPNombre.Clear();
            txtEMPApellido.Clear();
            rbEMPDiurna.Checked = true;
            txtEMPComision.Clear();
            rbEMPActivo.Checked = true;
            dtpEMPFechaIngreso.Value = DateTime.Now;
            rbEMPActivo.Checked = false;
            rbEMPInactivo.Checked = false;
            rbEMPDiurna.Checked = false;
            rbEMPInactivo.Checked = false;

            HabilitarBotones("A");
        }
        private void HabilitarBotones(string C)
        {
            if (C == "A")
            {
                btnEMPGuardar.Enabled = true;
                btnEMPModificar.Enabled = false;
                btnEMPEliminar.Enabled = false;
                txtEMPCedula.ReadOnly = false;
            }
            else if (C == "M")
            {
                btnEMPGuardar.Enabled = false;
                btnEMPModificar.Enabled = true;
                btnEMPEliminar.Enabled = true;
                txtEMPCedula.ReadOnly = true;
            }
        }

        private string Criterio()
        {
            if (cbxEMPCriterio.Text == "Cédula")
            {
                return "Cedula_Empleado";
            }

            else if (cbxEMPCriterio.Text == "Nombre")
            {
                return "Nombre_Empleado";
            }
            else if (cbxEMPCriterio.Text == "Apellido")
            {
                return "Apellido_Empleado";
            }
            else if (cbxEMPCriterio.Text == "Tanda")
            {
                return "Tanda_Empleado";
            }
            else if (cbxEMPCriterio.Text == "Comisión")
            {
                return "Comision_Empleado";
            }
            else if (cbxEMPCriterio.Text == "Estado")
            {
                return "Estado_Empleado";
            }
            else if (cbxEMPCriterio.Text == "Fecha de ingreso")
            {
                return "FechaIngreso_Empleado";
            }
            else return null;
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
                int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
            }

            if (vnTotal % 10 == 0)
                return true;
            else
                return false;
        }
        private string ObtenerTanda()
        {
            if (rbEMPDiurna.Checked == true) { rbEMPNocturna.Checked = false; return "Diurna"; }
            else if (rbEMPNocturna.Checked == true) { rbEMPDiurna.Checked = false; return "Nocturna"; }
            else return "Activo";
        }
        private string ObtenerEstado()
        {
            if (rbEMPActivo.Checked == true) { rbEMPInactivo.Checked = false; return "Activo"; }
            else if (rbEMPInactivo.Checked == true) { rbEMPActivo.Checked = false; return "Inactivo"; }
            else return "Activo";
        }

        private double ObtenerComision()
        {
            double Comision;
            if (!double.TryParse(txtEMPComision.Text, out Comision)) {  return - 1; }
            else { double.TryParse(txtEMPComision.Text, out Comision); }

            return Comision;
        }


        private void ExportaExcel(DataGridView DGT, string Nombre)
        {
            try
            {

                StreamWriter SW = new StreamWriter(Nombre, false, System.Text.Encoding.GetEncoding(1252));

                SW.WriteLine("sep=,");

                string Header = "";

                foreach (DataGridViewColumn col in DGT.Columns)
                {
                    Header += col.Name + ",";
                }
                Header = Header.Remove(Header.Length - 1);

                SW.WriteLine(Header);

                foreach (DataRow DR in DT.Rows)
                {
                    string Linea = "";
                    foreach (DataColumn DC in DT.Columns)
                    {
                        Linea += DR[DC].ToString() + ",";
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

        private void btnEMPExportar_Click(object sender, EventArgs e)
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
            ExportarEn.FileName = "Empleados";
            if (ExportarEn.ShowDialog() == DialogResult.OK)
            {
                Archivo = ExportarEn.FileName;
                ExportaExcel(dtgEmpleados, Archivo);
            }

        }

    }
}
