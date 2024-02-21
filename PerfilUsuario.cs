using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Caja_UNAPEC
{
    public partial class PerfilUsuario : UserControl
    {
        SqlConnection Con = null;

        public PerfilUsuario()
        {
            InitializeComponent();
        }

        public void InicializarPerfilUsuario(string Conn)
        {
            Con = new SqlConnection(Conn);
        }

        public void DatosUsuario(string nombre, string identificador, string acceso, string estado)
        {
            lblPUNombre.Text = nombre;
            lblPUIdentificador.Text = identificador;
            lblPUAccesibilidad.Text = acceso;
            lblPUEstado.Text = estado;
        }

        private void BtnPUCambiarClave_Click(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void BtnPUCancelar_Click(object sender, EventArgs e)
        {
            Desabilitar();
        }

        private void BtnPUConfirmar_Click(object sender, EventArgs e)
        {
            string anterior = txtPUCAnterior.Text;
            string nueva = txtPUCNueva.Text;
            string confirmar = txtPUCConfirmar.Text;

            try
            {
                Con.Open();

                SqlCommand VerificarUsuario = new SqlCommand("SELECT COUNT(*) FROM Usuarios WHERE Identificador_Usuario= @Usuario AND Clave_Usuario = @Hash", Con);
                VerificarUsuario.Parameters.AddWithValue("@Usuario", lblPUIdentificador.Text);
                VerificarUsuario.Parameters.AddWithValue("@Hash", GetSha1Hash(anterior));

                int UsuarioEncontrado = (int)VerificarUsuario.ExecuteScalar();

                if (UsuarioEncontrado == 1 & nueva == confirmar)
                {
                    SqlCommand TomarUsuario = new SqlCommand("UPDATE Usuarios SET Clave_Usuario = @Clave WHERE Identificador_Usuario = @Identificador;", Con);
                    TomarUsuario.Parameters.AddWithValue("@Clave", GetSha1Hash(nueva));
                    TomarUsuario.Parameters.AddWithValue("@Identificador", lblPUIdentificador.Text);

                    TomarUsuario.ExecuteNonQuery();

                    Desabilitar();

                    MessageBox.Show("Su contraseña fue modificada.");
                }
                else
                {
                    txtPUCAnterior.Clear();
                    txtPUCNueva.Clear();
                    txtPUCConfirmar.Clear();
                    MessageBox.Show("Datos incorrectos.");
                }
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void Habilitar()
        {
            txtPUCAnterior.Clear();
            txtPUCNueva.Clear();
            txtPUCConfirmar.Clear();

            lbltituloCambioClave.Enabled = true;
            pnlPUCambioClave.Enabled = true;
        }

        private void Desabilitar()
        {
            txtPUCAnterior.Clear();
            txtPUCNueva.Clear();
            txtPUCConfirmar.Clear();

            lbltituloCambioClave.Enabled = false;
            pnlPUCambioClave.Enabled = false;
        }
    }
}
