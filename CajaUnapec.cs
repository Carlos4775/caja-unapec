using System;
using System.Drawing;
using System.Windows.Forms;

namespace Caja_UNAPEC
{
    public partial class FrmCajaUnapec : Form
    {
        readonly string ConectionString = @"Data Source=DESKTOP-OBKLKFB\SQLEXPRESS;Initial Catalog=Caja_UNAPEC;Integrated Security=True";
        Usuario RGUsuario = null;

        public FrmCajaUnapec()
        {
            InitializeComponent();
        }

        private void CajaUnapec_Load(object sender, EventArgs e)
        {
            frmInicio.Ingresar += new EventHandler(TomarDatos);
            Visualizador();
            Acceso();
            frmInicio.InicializarLoging(ConectionString);
            frmInicio.Visible = true;
            pnlInicio.BackColor = Color.FromArgb(192, 0, 0);
        }

        protected void TomarDatos(object sender, EventArgs e)
        {
            if (frmInicio.UsuarioActual() != null)
            {
                RGUsuario = frmInicio.UsuarioActual();
                frmInicio.LimpiarCredenciales();

                lblUsuario.Text = RGUsuario.Nombre_O;
                lblIdentificador.Text = RGUsuario.Identificador_O;            

                Acceso();
            }
        }

        public void Visualizador()
        {
            frmInicio.Visible = false;
            frmEstudiantes.Visible = false;
            frmEmpleados.Visible = false;
            frmCarreras.Visible = false;
            frmServicios.Visible = false;
            frmMovimientos.Visible = false;
            frmUsuarios.Visible = false;
            frmDocumentos.Visible = false;
            frmFormaPago.Visible = false;
            frmperfilUsuario.Visible = false;

            pnlInicio.BackColor = Color.FromArgb(255, 255, 255);
            pnlEstudiantes.BackColor = Color.FromArgb(255, 255, 255);
            pnlEmpleados.BackColor = Color.FromArgb(255, 255, 255);
            pnlCarreras.BackColor = Color.FromArgb(255, 255, 255);
            pnlServicios.BackColor = Color.FromArgb(255, 255, 255);
            pnlMovimientos.BackColor = Color.FromArgb(255, 255, 255);
            pnlUsuarios.BackColor = Color.FromArgb(255, 255, 255);
            pnlDocumentos.BackColor = Color.FromArgb(255, 255, 255);
            pnlFormaPago.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void Acceso()
        {
            if(RGUsuario == null)
            {
                pnlUsuario.Visible = false;
                btnEstudiantes.Enabled = false;
                btnEmpleados.Enabled = false;
                btnCarreras.Enabled = false;
                btnServicios.Enabled = false;
                btnMovimientos.Enabled = false;
                btnUsuarios.Enabled = false;
                btnDocumentos.Enabled = false;
                btnFormaPago.Enabled = false;
                frmperfilUsuario.Enabled = false;
            }
            else if(RGUsuario != null)
            {
                Visualizador();
                pnlUsuario.Visible = true;
                frmperfilUsuario.Enabled = true;

                if (RGUsuario.Acceso_O == "Administrador")
                {
                    btnEstudiantes.Enabled = true;
                    btnEmpleados.Enabled = true;
                    btnCarreras.Enabled = true;
                    btnServicios.Enabled = true;
                    btnMovimientos.Enabled = true;
                    btnUsuarios.Enabled = true;
                    btnDocumentos.Enabled = true;
                    btnFormaPago.Enabled = true;
                }
                else if (RGUsuario.Acceso_O == "Registro")
                {
                    btnEstudiantes.Enabled = true;
                    btnEmpleados.Enabled = true;
                    btnCarreras.Enabled = true;
                    btnServicios.Enabled = true;
                    btnMovimientos.Enabled = false;
                    btnUsuarios.Enabled = false;
                    btnDocumentos.Enabled = false;
                    btnFormaPago.Enabled = false;
                }
                else if (RGUsuario.Acceso_O == "Cajero")
                {
                    btnEstudiantes.Enabled = true;
                    btnEmpleados.Enabled = false;
                    btnCarreras.Enabled = false;
                    btnServicios.Enabled = true;
                    btnMovimientos.Enabled = false;
                    btnUsuarios.Enabled = false;
                    btnDocumentos.Enabled = false;
                    btnFormaPago.Enabled = false;
                }
            }
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            Visualizador();
            pnlInicio.BackColor = Color.FromArgb(192, 0, 0);

            if(RGUsuario == null)
            {
                frmInicio.Visible = true;
                frmInicio.InicializarLoging(ConectionString);
            } 
            else
            {
                frmperfilUsuario.DatosUsuario(RGUsuario.Nombre_O, RGUsuario.Identificador_O, RGUsuario.Acceso_O, RGUsuario.Estado_O);
                frmperfilUsuario.Visible = true;
            }
        }

        private void BtnEstudiantes_Click(object sender, EventArgs e)
        {
            Visualizador();
            pnlEstudiantes.BackColor = Color.FromArgb(192, 0, 0);
            frmEstudiantes.Visible = true;
            frmEstudiantes.InicializarEstudiante(ConectionString);
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            Visualizador();
            pnlEmpleados.BackColor = Color.FromArgb(192, 0, 0);
            frmEmpleados.Visible = true;
            frmEmpleados.InicializarEmpleado(ConectionString);
        }

        private void BtnCarreras_Click(object sender, EventArgs e)
        {
            Visualizador();
            pnlCarreras.BackColor = Color.FromArgb(192, 0, 0);
            frmCarreras.Visible = true;
            frmCarreras.InicializarCarreras(ConectionString);
        }

        private void BtnServicios_Click(object sender, EventArgs e)
        {
            Visualizador();
            pnlServicios.BackColor = Color.FromArgb(192, 0, 0);
            frmServicios.Visible = true;
            frmServicios.InicializarServicios(ConectionString);
        }

        private void BtnMovimientos_Click(object sender, EventArgs e)
        {
            Visualizador();
            pnlMovimientos.BackColor = Color.FromArgb(192, 0, 0);
            frmMovimientos.Visible = true;
            frmMovimientos.InicializarMovimientos(ConectionString);
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            Visualizador();
            pnlUsuarios.BackColor = Color.FromArgb(192, 0, 0);
            frmUsuarios.Visible = true;
            frmUsuarios.InicializarUsuarios(ConectionString);
        }

        private void BtnDocumentos_Click(object sender, EventArgs e)
        {
            Visualizador();
            pnlDocumentos.BackColor = Color.FromArgb(192, 0, 0);
            frmDocumentos.Visible = true;
            frmDocumentos.InicializarDocumentos(ConectionString);
        }

        private void BtnFormaPago_Click(object sender, EventArgs e)
        {
            Visualizador();
            pnlFormaPago.BackColor = Color.FromArgb(192, 0, 0);
            frmFormaPago.Visible = true;
            frmFormaPago.InicializarFormaDePago(ConectionString);
        }

        private void BtnINCSalir_Click(object sender, EventArgs e)
        {
            RGUsuario = null;

            lblUsuario.Text = "Usuario";
            lblIdentificador.Text = "Identificador";

            Visualizador();
            Acceso();
            frmInicio.Visible = true;
        }
        
        private void CmdPerfilUsuario()
        {
            Visualizador();
            frmperfilUsuario.InicializarPerfilUsuario(ConectionString);
            frmperfilUsuario.DatosUsuario(RGUsuario.Nombre_O, RGUsuario.Identificador_O, RGUsuario.Acceso_O, RGUsuario.Estado_O);
            frmperfilUsuario.Visible = true;
        }

        private void PnlCredenciales_Click(object sender, EventArgs e)
        {
            CmdPerfilUsuario();
        }

        private void PnlPerfilP_Click(object sender, EventArgs e)
        {
            CmdPerfilUsuario();
        }

        private void LblUsuario_Click(object sender, EventArgs e)
        {
            CmdPerfilUsuario();
        }

        private void LblIdentificador_Click(object sender, EventArgs e)
        {
            CmdPerfilUsuario();
        }

        private bool mouseDown;
        private Point lastLocation;

        private void FrmCajaUnapec_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void FrmCajaUnapec_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void FrmCajaUnapec_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
