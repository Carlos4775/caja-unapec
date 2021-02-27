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
    public partial class Movimientos : UserControl
    {
        SqlConnection Con = null;
        DataTable DT = null;
        public Movimientos()
        {
            InitializeComponent();
        }

        public void InicializarMovimientos(string Conn)
        {
            Con = new SqlConnection(Conn);

            ObtenerServicios();
            ObtenerDocumentos();
            ObtenerEstudiantes();
            ObtenerEmpleados();
            ObtenerFormasDePago();

            cbxMCCriterio.SelectedIndex = 0;
            cbxMCEstado.SelectedIndex = 0;


            LimpiarCampos();
            HabilitarBotones("A");
            
            ESTSelectAll();
        }

        private void ESTSelectAll()
        {
            try
            {

                Con.Open();

                string Select = "SELECT NO_MovimientoCaja AS '# Movimiento', Nombre_Servicio AS Servicio, Nombre_TipoDoc AS Documento, Matricula_Estudiante AS Estudiante, Nombre_Empleado As Empleado, Nombre_FormaDePAgo AS 'Forma de pago', Monto_MovimientoCaja AS Monto, Fecha_MovimientoCaja AS Fecha, Estado_MovimientoCaja AS Estado FROM MovimientoDeCaja, Servicios, Empleado, Tipo_Documento, FormaDePAgo WHERE Empleado.Cedula_Empleado = MovimientoDeCaja.Cedula_Empleado AND Tipo_Documento.ID_TipoDoc= MovimientoDeCaja.ID_TipoDoc AND Servicios.ID_Servicio = MovimientoDeCaja.ID_Servicio AND FormaDePAgo.ID_FormaDePAgo = MovimientoDeCaja.ID_FormaDePAgo ";
                Select += " AND " + Criterio() + " LIKE '%" + txtMCDato.Text + "%'";
                Select += " ORDER BY " + Criterio();
                SqlDataAdapter DA = new SqlDataAdapter(Select, Con);
                DT = new DataTable();
                DA.Fill(DT);

                dtgMovimientos.DataSource = DT;
                dtgMovimientos.Refresh();

                Con.Close();

            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al recoger la información de la base de datos.\n" + Ex.Message);
            }


        }

        private void btnMCGuardar_Click(object sender, EventArgs e)
        {
            string Numero = ObtenerNumero();
            string Servicio = ObtenerServicio();
            string Documento = ObtenerDocumento();
            string Matricula = cbxMCSolicitante.Text;
            string Empleado = ObtenerEmpleado();
            string FormaPago = ObtenerFormaDePago();
            string Estado = cbxMCEstado.Text;
            DateTime Fecha = dtpMCFechaPago.Value;
            
            string Monto;
            
            if (Estado == "Solicitado")
            {
                Monto = txtMCMonto.Text;
            } else
            {
                Monto = "0";
            }

                

            try
            {
                Con.Open();

                string Insert = "INSERT INTO MovimientoDeCaja (NO_MovimientoCaja, ID_Servicio, ID_TipoDoc, Matricula_Estudiante, Cedula_Empleado, ID_FormaDePago, Monto_MovimientoCaja, Estado_MovimientoCaja, Fecha_MovimientoCaja) VALUES ('";
                Insert +=  Numero + "' , '" + Servicio + "' , '" + Documento + "' , '" + Matricula + "' , '" + Empleado + "' , '" + FormaPago + "' , '" + Monto + "' , '" + Estado + "' , '" + Fecha + "')";
                SqlCommand Query = new SqlCommand(Insert, Con);
                Query.ExecuteNonQuery();

                Con.Close();

                MessageBox.Show("Movimiento registrado.");

                ActualizarBalance(Matricula);
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

        private void btnMCModificar_Click(object sender, EventArgs e)
        {
            string Numero = txtMCNumero.Text;
            string Servicio = ObtenerServicio();
            string Documento = ObtenerDocumento();
            string Matricula = cbxMCSolicitante.Text;
            string Empleado = ObtenerEmpleado();
            string FormaPago = ObtenerFormaDePago();
            string Estado = cbxMCEstado.Text;
            DateTime Fecha = dtpMCFechaPago.Value;

            string Monto;

            if (Estado == "Solicitado")
            {
                Monto = txtMCMonto.Text;
            }
            else
            {
                Monto = "0";
            }

            try
            {

                Con.Open();

                string Update = "UPDATE MovimientoDeCaja SET ID_Servicio = '" + Servicio + "', ID_TipoDoc = '" + Documento + "', Matricula_Estudiante = '" + Matricula + "', Cedula_Empleado = '" + Empleado + "', ID_FormaDePago = '" + FormaPago + "', Monto_MovimientoCaja = '" + Monto + "', Estado_MovimientoCaja = '" + Estado + "', Fecha_MovimientoCaja = '" + Fecha + "' WHERE NO_MovimientoCaja = '" + Numero + "'";

                SqlCommand Query = new SqlCommand(Update, Con);
                Query.ExecuteNonQuery();

                Con.Close();

                MessageBox.Show("Datos Modificados.");

                ActualizarBalance(Matricula);

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

        private void btnMCEliminar_Click(object sender, EventArgs e)
        {
            string Numero = txtMCNumero.Text;

            try
            {
                Con.Open();

                string Delete = "DELETE FROM MovimientoDeCaja WHERE NO_MovimientoCaja = '" + Numero + "'";
                SqlCommand Query = new SqlCommand(Delete, Con);
                Query.ExecuteNonQuery();

                Con.Close();

                MessageBox.Show("Movimiento Eliminado.");

                ActualizarBalance(cbxMCSolicitante.Text);
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

        private void btnMCLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnMCBuscar_Click(object sender, EventArgs e)
        {
            ESTSelectAll();
        }

        private void dtgMovimientos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Row = dtgMovimientos.CurrentRow;
            txtMCNumero.Text = Row.Cells[0].Value.ToString();
            cbxMCServicio.Text = Row.Cells[1].Value.ToString();
            cbxMCDocumento.Text = Row.Cells[2].Value.ToString();
            cbxMCSolicitante.Text = Row.Cells[3].Value.ToString();
            cbxMCEncargado.Text = Row.Cells[4].Value.ToString();
            cbxMCFormaPago.Text = Row.Cells[5].Value.ToString();
            txtMCMonto.Text = Row.Cells[6].Value.ToString();
            dtpMCFechaPago.Value = DateTime.Parse(Row.Cells[7].Value.ToString());

            HabilitarBotones("M");
        }

        private void LimpiarCampos()
        {
            txtMCNumero.Text = "Autogenerado";
            cbxMCServicio.SelectedIndex = -1;
            cbxMCDocumento.SelectedIndex = -1;
            cbxMCSolicitante.SelectedIndex = -1;
            cbxMCEncargado.SelectedIndex = -1;
            cbxMCFormaPago.SelectedIndex = -1;
            txtMCMonto.Clear();
            cbxMCEstado.SelectedIndex = 0;
            dtpMCFechaPago.Value = DateTime.Now;


            HabilitarBotones("A");
        }
        private void HabilitarBotones(string C)
        {
            if (C == "A")
            {
                btnMCGuardar.Enabled = true;
                btnMCModificar.Enabled = false;
                btnMCEliminar.Enabled = false;
            }
            else if (C == "M")
            {
                btnMCGuardar.Enabled = false;
                btnMCModificar.Enabled = true;
                btnMCEliminar.Enabled = true;
            }
        }

        private string Criterio()
        {
            if (cbxMCCriterio.Text == "# Movimiento")
            {
                return "NO_MovimientoCaja";
            }

            else if (cbxMCCriterio.Text == "Servicio")
            {
                return "Nombre_Servicio";
            }
            else if (cbxMCCriterio.Text == "Documento")
            {
                return "Nombre_TipoDoc";
            }
            else if (cbxMCCriterio.Text == "Estudiante")
            {
                return "Matricula_Estudiante";
            }
            else if (cbxMCCriterio.Text == "Empleado")
            {
                return "Nombre_Empleado";
            }
            else if (cbxMCCriterio.Text == "Forma de pago")
            {
                return "Nombre_FormaDePAgo";
            }
            else if (cbxMCCriterio.Text == "Monto")
            {
                return "Monto_MovimientoCaja";
            }
            else if (cbxMCCriterio.Text == "Fecha")
            {
                return "Fecha_MovimientoCaja";
            }
            else if (cbxMCCriterio.Text == "Estado")
            {
                return "Estado_MovimientoCaja";
            }

            else return "null";
        }

        private static Random Generar = new Random();
        public string ObtenerNumero()
        {
            bool Existe = true;
            string Numero = null;

            Con.Open();

            while (Existe == true){

                const string chars = "0123456789";
                Numero = DateTime.Now.ToString("yy") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("dd") + "-";
                Numero += new string(Enumerable.Repeat(chars, 10).Select(s => s[Generar.Next(s.Length)]).ToArray());

                string NumeroDB = "SELECT NO_MovimientoCaja AS Movimiento FROM MovimientoDeCaja WHERE NO_MovimientoCaja = '" + Numero + "'";

                SqlDataAdapter DA = new SqlDataAdapter(NumeroDB, Con);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                dtgMovimientos.DataSource = DT;

                DataRow[] Rows = DT.Select("Movimiento='" + Numero + "'");
                if (Rows.Length > 0)
                {
                    Existe = true;
                }
                else
                {
                    Existe = false;
                }

            }
            Con.Close();
            return Numero;
        }


        private string ObtenerServicio()
        {

            try
            {
                Con.Open();
                string Select = "SELECT ID_Servicio, Monto_Servicio FROM Servicios WHERE Nombre_Servicio = '" + cbxMCServicio.Text + "'";
                SqlDataAdapter DA = new SqlDataAdapter(Select, Con);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                string Servicio = DT.Rows[0][0].ToString();

                Con.Close();
                return Servicio;

            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al obtener el código de del servicio.\n" + Ex.Message);
                return null;
            }


        }
        string[,] Servicios = null;
        private void ObtenerServicios()
        {

            cbxMCServicio.Items.Clear();

            try
            {
                Con.Open();
                string Select = "SELECT Nombre_Servicio AS Servicio, Monto_Servicio AS Monto  FROM Servicios ORDER BY Nombre_Servicio";
                SqlDataAdapter DA = new SqlDataAdapter(Select, Con);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                foreach (DataRow DR in DT.Rows)
                {
                    cbxMCServicio.Items.Add(DR["Servicio"].ToString()); ;
                }

                int length = DT.Rows.Count + 1;

                Servicios = new string[length, 2];

                for (int i = 0; i <= DT.Rows.Count - 1; i++)
                {

                    DataRow DR = DT.Rows[i];

                    Servicios[i,0] = DR["Servicio"].ToString();
                    Servicios[i,1] = DR["Monto"].ToString();

                }

                

                Con.Close();

                
            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al recoger los servicios.\n" + Ex.Message);
            }
        }

        private string ObtenerDocumento()
        {

            try
            {
                Con.Open();
                string Select = "SELECT ID_TipoDoc FROM Tipo_Documento WHERE Nombre_TipoDoc = '" + cbxMCDocumento.Text + "'";
                SqlDataAdapter DA = new SqlDataAdapter(Select, Con);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                string Documento = DT.Rows[0][0].ToString();

                Con.Close();
                return Documento;

            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al obtener el código del documento.\n" + Ex.Message);
                return null;
            }


        }

        private void ObtenerDocumentos()
        {

            cbxMCDocumento.Items.Clear();

            try
            {
                Con.Open();
                string Select = "SELECT Nombre_TipoDoc AS Documento FROM Tipo_Documento ORDER BY Nombre_TipoDoc";
                SqlDataAdapter DA = new SqlDataAdapter(Select, Con);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                foreach (DataRow DR in DT.Rows)
                {
                    cbxMCDocumento.Items.Add(DR["Documento"].ToString()); ;
                }


                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al recoger los documentos.\n" + Ex.Message);
            }
        }

        

        private void ObtenerEstudiantes()
        {

            cbxMCSolicitante.Items.Clear();

            try
            {
                Con.Open();
                string Select = "SELECT Matricula_Estudiante AS Estudiante FROM Estudiante ORDER BY Matricula_Estudiante";
                SqlDataAdapter DA = new SqlDataAdapter(Select, Con);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                foreach (DataRow DR in DT.Rows)
                {
                    cbxMCSolicitante.Items.Add(DR["Estudiante"].ToString()); ;
                }


                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al recoger las matrículas.\n" + Ex.Message);
            }
        }

        private string ObtenerEmpleado()
        {

            try
            {
                Con.Open();
                string Select = "SELECT Cedula_Empleado FROM Empleado WHERE Nombre_Empleado = '" + cbxMCEncargado.Text + "'";
                SqlDataAdapter DA = new SqlDataAdapter(Select, Con);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                string Empleado = DT.Rows[0][0].ToString();

                Con.Close();
                return Empleado;

            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al obtener el código del empleado.\n" + Ex.Message);
                return null;
            }


        }

        private void ObtenerEmpleados()
        {

            cbxMCEncargado.Items.Clear();

            try
            {
                Con.Open();
                string Select = "SELECT Nombre_Empleado AS Empleado FROM Empleado ORDER BY Nombre_Empleado";
                SqlDataAdapter DA = new SqlDataAdapter(Select, Con);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                foreach (DataRow DR in DT.Rows)
                {
                    cbxMCEncargado.Items.Add(DR["Empleado"].ToString()); ;
                }


                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al recoger los empleados.\n" + Ex.Message);
            }
        }

        private string ObtenerFormaDePago()
        {

            try
            {
                Con.Open();
                string Select = "SELECT ID_FormaDePago FROM FormaDePago WHERE Nombre_FormaDePago = '" + cbxMCFormaPago.Text + "'";
                SqlDataAdapter DA = new SqlDataAdapter(Select, Con);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                string FormaPago = DT.Rows[0][0].ToString();

                Con.Close();
                return FormaPago;

            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al obtener el código de la forma de pago.\n" + Ex.Message);
                return null;
            }


        }

        private void ObtenerFormasDePago()
        {

             cbxMCFormaPago.Items.Clear();

            try
            {
                Con.Open();
                string Select = "SELECT Nombre_FormaDePago AS FormaDePago FROM FormaDePago ORDER BY Nombre_FormaDePago";
                SqlDataAdapter DA = new SqlDataAdapter(Select, Con);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                foreach (DataRow DR in DT.Rows)
                {
                    cbxMCFormaPago.Items.Add(DR["FormaDePago"].ToString()); ;
                }


                Con.Close();
            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("Error al recoger las formas de pago.\n" + Ex.Message);
            }
        }

        private void cbxMCServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMCServicio.SelectedIndex > -1 && (cbxMCEstado.SelectedIndex == -1 || cbxMCEstado.Text == "Solicitado")) { 
                string[] Servicio = new string[Servicios.GetLength(0) - 1];

                for (int i = 0; i < Servicios.GetLength(0) - 1; i++)
                {
                    Servicio[i] = Servicios[i, 0];
                }

                int index = Array.IndexOf(Servicio, cbxMCServicio.Text);

                txtMCMonto.Text = Servicios[index, 1];
            } 
            else { txtMCMonto.Text = "0"; }
        }

        private void ActualizarBalance(string Matricula)
        {
            try
            {

                Con.Open();

                string Update = "UPDATE Estudiante SET Balance_Estudiante = Total";
                Update += " FROM(SELECT SUM(Monto_MovimientoCaja) AS Total, Estudiante.Matricula_Estudiante FROM MovimientoDeCaja, Estudiante WHERE MovimientoDeCaja.Matricula_Estudiante = Estudiante.Matricula_Estudiante GROUP BY Estudiante.Matricula_Estudiante) AS Total";
                Update += " WHERE Estudiante.Matricula_Estudiante = Total.Matricula_Estudiante AND Estudiante.Matricula_Estudiante = " + Matricula;

                SqlCommand Query = new SqlCommand(Update, Con);
                Query.ExecuteNonQuery();

                Con.Close();

                MessageBox.Show("Se ha actualizado el balance del solicitante.");
            }
            catch (Exception Ex)
            {
                Con.Close();
                MessageBox.Show("No se pudo actualizar el balance.\n" + Ex.Message);
            }
        }

        private void cbxMCEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMCServicio.SelectedIndex > -1 && (cbxMCEstado.SelectedIndex == -1 || cbxMCEstado.Text == "Solicitado"))
            {
                string[] Servicio = new string[Servicios.GetLength(0) - 1];

                for (int i = 0; i < Servicios.GetLength(0) - 1; i++)
                {
                    Servicio[i] = Servicios[i, 0];
                }

                int index = Array.IndexOf(Servicio, cbxMCServicio.Text);

                txtMCMonto.Text = Servicios[index, 1];
            }
            else { txtMCMonto.Text = "0"; }
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

        private void btnMCExportar_Click(object sender, EventArgs e)
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
            ExportarEn.FileName = "Movimientos";
            if (ExportarEn.ShowDialog() == DialogResult.OK)
            {
                Archivo = ExportarEn.FileName;
                ExportaExcel(dtgMovimientos, Archivo);
            }

        }
    }
}
