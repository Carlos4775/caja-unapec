namespace Caja_UNAPEC
{
    partial class Inicio
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.label3 = new System.Windows.Forms.Label();
            this.btnINCSalir = new System.Windows.Forms.Button();
            this.btnINCIngresar = new System.Windows.Forms.Button();
            this.txtINCClave = new System.Windows.Forms.TextBox();
            this.txtINCUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DINPro-Bold", 25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(59, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 54);
            this.label3.TabIndex = 4;
            this.label3.Text = "Inicio de Sesión";
            // 
            // btnINCSalir
            // 
            this.btnINCSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnINCSalir.FlatAppearance.BorderSize = 0;
            this.btnINCSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnINCSalir.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnINCSalir.ForeColor = System.Drawing.Color.White;
            this.btnINCSalir.Location = new System.Drawing.Point(193, 349);
            this.btnINCSalir.Name = "btnINCSalir";
            this.btnINCSalir.Size = new System.Drawing.Size(115, 32);
            this.btnINCSalir.TabIndex = 26;
            this.btnINCSalir.Text = "Salir";
            this.btnINCSalir.UseVisualStyleBackColor = false;
            this.btnINCSalir.Click += new System.EventHandler(this.btnINCSalir_Click);
            // 
            // btnINCIngresar
            // 
            this.btnINCIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.btnINCIngresar.FlatAppearance.BorderSize = 0;
            this.btnINCIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnINCIngresar.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnINCIngresar.ForeColor = System.Drawing.Color.White;
            this.btnINCIngresar.Location = new System.Drawing.Point(68, 349);
            this.btnINCIngresar.Name = "btnINCIngresar";
            this.btnINCIngresar.Size = new System.Drawing.Size(115, 32);
            this.btnINCIngresar.TabIndex = 25;
            this.btnINCIngresar.Text = "Ingresar";
            this.btnINCIngresar.UseVisualStyleBackColor = false;
            this.btnINCIngresar.Click += new System.EventHandler(this.btnINCIngresar_Click);
            // 
            // txtINCClave
            // 
            this.txtINCClave.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.txtINCClave.Location = new System.Drawing.Point(68, 294);
            this.txtINCClave.Name = "txtINCClave";
            this.txtINCClave.PasswordChar = '■';
            this.txtINCClave.Size = new System.Drawing.Size(301, 29);
            this.txtINCClave.TabIndex = 30;
            // 
            // txtINCUsuario
            // 
            this.txtINCUsuario.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.txtINCUsuario.Location = new System.Drawing.Point(68, 222);
            this.txtINCUsuario.Name = "txtINCUsuario";
            this.txtINCUsuario.Size = new System.Drawing.Size(301, 29);
            this.txtINCUsuario.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(64, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 29;
            this.label6.Text = "Contraseña";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(64, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 22);
            this.label10.TabIndex = 28;
            this.label10.Text = "Usuario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(510, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 425);
            this.panel1.TabIndex = 31;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtINCClave);
            this.Controls.Add(this.txtINCUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnINCSalir);
            this.Controls.Add(this.btnINCIngresar);
            this.Controls.Add(this.label3);
            this.Name = "Inicio";
            this.Size = new System.Drawing.Size(1011, 523);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnINCSalir;
        private System.Windows.Forms.Button btnINCIngresar;
        private System.Windows.Forms.TextBox txtINCClave;
        private System.Windows.Forms.TextBox txtINCUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
    }
}
