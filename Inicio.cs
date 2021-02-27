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
using System.Security.Cryptography;

namespace Caja_UNAPEC
{
    public partial class Inicio : UserControl
    {
        SqlConnection Con = null;
        public Inicio()
        {
            InitializeComponent();
        }

        public void InicializarLoging(string Conn)
        {
            Con = new SqlConnection(Conn);
            txtINCUsuario.Clear();
            txtINCClave.Clear();

        }

        Usuario DTUsuario = null;

        private void VerificarUsuario()
        {
            try
            {


                Con.Open();

                string Usuario = txtINCUsuario.Text;
                string Clave = txtINCClave.Text;
                string Hash = GetSha1Hash(Clave);


                SqlCommand VerificarUsuario = new SqlCommand("SELECT COUNT(*) FROM Usuarios WHERE Identificador_Usuario=@Usuario AND Clave_Usuario=@Hash", Con);
                VerificarUsuario.Parameters.AddWithValue("@Usuario", Usuario);
                VerificarUsuario.Parameters.AddWithValue("@Hash", Hash);

                int UsuarioEncontrado = (int)VerificarUsuario.ExecuteScalar();

                if (UsuarioEncontrado == 1)
                {
                    DTUsuario = new Usuario();

                    SqlCommand TomarUsuario = new SqlCommand("SELECT Identificador_Usuario AS Indentificador, Nombre_Usuario AS Nombre, Accesibilidad_Usuario AS Accesibilidad, Estado_Usuario AS Estado FROM Usuarios WHERE Identificador_Usuario =@Usuario AND Clave_Usuario=@Hash", Con);
                    TomarUsuario.Parameters.AddWithValue("@Usuario", Usuario);
                    TomarUsuario.Parameters.AddWithValue("@Hash", Hash);

                    SqlDataReader DR = TomarUsuario.ExecuteReader();
                    Hash = "";


                    if (DR.HasRows)
                    {
                        while (DR.Read())
                        {

                            DTUsuario.Identificador_O = DR[0].ToString();
                            DTUsuario.Nombre_O = DR[1].ToString();
                            DTUsuario.Acceso_O = DR[2].ToString();
                            DTUsuario.Estado_O = DR[3].ToString();

                           
                        }
                    } else { DTUsuario = null; }

                    if (DTUsuario.Estado_O == "Inactivo" )
                    {
                        txtINCUsuario.Clear();
                        txtINCClave.Clear();
                        MessageBox.Show("Su cuenta '" + DTUsuario.Nombre_O + "' se encuentra inactiva. \n Contacte a un administrador.");
                        DTUsuario = null;
                    } else {

                        txtINCUsuario.Clear();
                        txtINCClave.Clear();

                        MessageBox.Show("Bienvenido " + DTUsuario.Nombre_O);  
                    }

                    Con.Close();

                }
                else
                {
                    txtINCClave.Clear();


                    Con.Close();

                    Hash = "";

                    MessageBox.Show("Datos incorrectos");
                }
                
            }
            catch (Exception ex)
            {
                txtINCUsuario.Clear();

                MessageBox.Show(ex.Message);
            }
        }


        internal static string GetSha1Hash(string text)
        {
            if (String.IsNullOrEmpty(text))
                return String.Empty;

            using (var sha1 = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = Encoding.UTF8.GetBytes(text);

                byte[] hash = sha1.ComputeHash(textData);

                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }

        public Usuario UsuarioActual()
        {
            return DTUsuario;
        }

        public void LimpiarCredenciales()
        {

            DTUsuario = null;
        }

        public event EventHandler Ingresar;
        private void btnINCIngresar_Click(object sender, EventArgs e)
        {

            VerificarUsuario();

            

            if (this.Ingresar != null)
            {
                Ingresar(this, e);
            }
        }

        private void btnINCSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
