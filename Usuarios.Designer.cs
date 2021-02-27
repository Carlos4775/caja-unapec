namespace Caja_UNAPEC
{
    partial class Usuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxUSUCriterio = new System.Windows.Forms.ComboBox();
            this.txtUSUDato = new System.Windows.Forms.TextBox();
            this.btnUSUBuscar = new System.Windows.Forms.Button();
            this.panel18 = new System.Windows.Forms.Panel();
            this.btnUSUEliminar = new System.Windows.Forms.Button();
            this.btnUSUGuardar = new System.Windows.Forms.Button();
            this.btnUSUModificar = new System.Windows.Forms.Button();
            this.btnUSULimpiar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUSUIdentificador = new System.Windows.Forms.TextBox();
            this.txtUSUNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbUSUActivo = new System.Windows.Forms.RadioButton();
            this.rbUSUInactivo = new System.Windows.Forms.RadioButton();
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.cbxUSUAccesibilidad = new System.Windows.Forms.ComboBox();
            this.txtUSUClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUSURestablecer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUSUID = new System.Windows.Forms.TextBox();
            this.panel18.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(257, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 22);
            this.label3.TabIndex = 40;
            this.label3.Text = "Dato";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(13, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 22);
            this.label13.TabIndex = 36;
            this.label13.Text = "Criterio";
            // 
            // cbxUSUCriterio
            // 
            this.cbxUSUCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUSUCriterio.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.cbxUSUCriterio.FormattingEnabled = true;
            this.cbxUSUCriterio.Items.AddRange(new object[] {
            "Nombre",
            "Identificador",
            "Accesibilidad",
            "Estado"});
            this.cbxUSUCriterio.Location = new System.Drawing.Point(90, 15);
            this.cbxUSUCriterio.Name = "cbxUSUCriterio";
            this.cbxUSUCriterio.Size = new System.Drawing.Size(150, 30);
            this.cbxUSUCriterio.TabIndex = 37;
            // 
            // txtUSUDato
            // 
            this.txtUSUDato.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.txtUSUDato.Location = new System.Drawing.Point(307, 16);
            this.txtUSUDato.Name = "txtUSUDato";
            this.txtUSUDato.Size = new System.Drawing.Size(150, 29);
            this.txtUSUDato.TabIndex = 38;
            // 
            // btnUSUBuscar
            // 
            this.btnUSUBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.btnUSUBuscar.FlatAppearance.BorderSize = 0;
            this.btnUSUBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(92)))), ((int)(((byte)(166)))));
            this.btnUSUBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUSUBuscar.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnUSUBuscar.ForeColor = System.Drawing.Color.White;
            this.btnUSUBuscar.Location = new System.Drawing.Point(475, 13);
            this.btnUSUBuscar.Name = "btnUSUBuscar";
            this.btnUSUBuscar.Size = new System.Drawing.Size(115, 32);
            this.btnUSUBuscar.TabIndex = 39;
            this.btnUSUBuscar.Text = "Buscar";
            this.btnUSUBuscar.UseVisualStyleBackColor = false;
            this.btnUSUBuscar.Click += new System.EventHandler(this.btnUSUBuscar_Click);
            // 
            // panel18
            // 
            this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel18.Controls.Add(this.cbxUSUAccesibilidad);
            this.panel18.Controls.Add(this.btnUSUEliminar);
            this.panel18.Controls.Add(this.btnUSUGuardar);
            this.panel18.Controls.Add(this.btnUSUModificar);
            this.panel18.Controls.Add(this.btnUSULimpiar);
            this.panel18.Controls.Add(this.label9);
            this.panel18.Controls.Add(this.txtUSUIdentificador);
            this.panel18.Controls.Add(this.txtUSUNombre);
            this.panel18.Controls.Add(this.label5);
            this.panel18.Controls.Add(this.label4);
            this.panel18.Controls.Add(this.label6);
            this.panel18.Controls.Add(this.label10);
            this.panel18.Controls.Add(this.label11);
            this.panel18.Controls.Add(this.label12);
            this.panel18.Controls.Add(this.panel1);
            this.panel18.Location = new System.Drawing.Point(603, 60);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(398, 306);
            this.panel18.TabIndex = 35;
            // 
            // btnUSUEliminar
            // 
            this.btnUSUEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUSUEliminar.FlatAppearance.BorderSize = 0;
            this.btnUSUEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUSUEliminar.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnUSUEliminar.ForeColor = System.Drawing.Color.White;
            this.btnUSUEliminar.Location = new System.Drawing.Point(267, 253);
            this.btnUSUEliminar.Name = "btnUSUEliminar";
            this.btnUSUEliminar.Size = new System.Drawing.Size(115, 32);
            this.btnUSUEliminar.TabIndex = 24;
            this.btnUSUEliminar.Text = "Eliminar";
            this.btnUSUEliminar.UseVisualStyleBackColor = false;
            this.btnUSUEliminar.Click += new System.EventHandler(this.btnUSUEliminar_Click);
            // 
            // btnUSUGuardar
            // 
            this.btnUSUGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.btnUSUGuardar.FlatAppearance.BorderSize = 0;
            this.btnUSUGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUSUGuardar.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnUSUGuardar.ForeColor = System.Drawing.Color.White;
            this.btnUSUGuardar.Location = new System.Drawing.Point(17, 253);
            this.btnUSUGuardar.Name = "btnUSUGuardar";
            this.btnUSUGuardar.Size = new System.Drawing.Size(115, 32);
            this.btnUSUGuardar.TabIndex = 23;
            this.btnUSUGuardar.Text = "Guardar";
            this.btnUSUGuardar.UseVisualStyleBackColor = false;
            this.btnUSUGuardar.Click += new System.EventHandler(this.btnUSUGuardar_Click);
            // 
            // btnUSUModificar
            // 
            this.btnUSUModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.btnUSUModificar.FlatAppearance.BorderSize = 0;
            this.btnUSUModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUSUModificar.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnUSUModificar.ForeColor = System.Drawing.Color.White;
            this.btnUSUModificar.Location = new System.Drawing.Point(142, 253);
            this.btnUSUModificar.Name = "btnUSUModificar";
            this.btnUSUModificar.Size = new System.Drawing.Size(115, 32);
            this.btnUSUModificar.TabIndex = 22;
            this.btnUSUModificar.Text = "Modificar";
            this.btnUSUModificar.UseVisualStyleBackColor = false;
            this.btnUSUModificar.Click += new System.EventHandler(this.btnUSUModificar_Click);
            // 
            // btnUSULimpiar
            // 
            this.btnUSULimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.btnUSULimpiar.FlatAppearance.BorderSize = 0;
            this.btnUSULimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUSULimpiar.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnUSULimpiar.ForeColor = System.Drawing.Color.White;
            this.btnUSULimpiar.Location = new System.Drawing.Point(292, 24);
            this.btnUSULimpiar.Name = "btnUSULimpiar";
            this.btnUSULimpiar.Size = new System.Drawing.Size(90, 32);
            this.btnUSULimpiar.TabIndex = 3;
            this.btnUSULimpiar.Text = "Limpiar";
            this.btnUSULimpiar.UseVisualStyleBackColor = false;
            this.btnUSULimpiar.Click += new System.EventHandler(this.btnUSULimpiar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.label9.Location = new System.Drawing.Point(12, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(376, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "______________________________________________";
            // 
            // txtUSUIdentificador
            // 
            this.txtUSUIdentificador.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.txtUSUIdentificador.Location = new System.Drawing.Point(142, 125);
            this.txtUSUIdentificador.Name = "txtUSUIdentificador";
            this.txtUSUIdentificador.Size = new System.Drawing.Size(241, 29);
            this.txtUSUIdentificador.TabIndex = 11;
            // 
            // txtUSUNombre
            // 
            this.txtUSUNombre.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.txtUSUNombre.Location = new System.Drawing.Point(142, 91);
            this.txtUSUNombre.Name = "txtUSUNombre";
            this.txtUSUNombre.Size = new System.Drawing.Size(241, 29);
            this.txtUSUNombre.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(16, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(16, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Accesibilidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(16, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Identificador";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(16, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 22);
            this.label10.TabIndex = 4;
            this.label10.Text = "Nombre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("DINPro-Bold", 15F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.label11.Location = new System.Drawing.Point(11, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 32);
            this.label11.TabIndex = 1;
            this.label11.Text = "Usuarios";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.label12.Location = new System.Drawing.Point(12, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(376, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "______________________________________________";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbUSUActivo);
            this.panel1.Controls.Add(this.rbUSUInactivo);
            this.panel1.Location = new System.Drawing.Point(142, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 29);
            this.panel1.TabIndex = 32;
            // 
            // rbUSUActivo
            // 
            this.rbUSUActivo.AutoSize = true;
            this.rbUSUActivo.Font = new System.Drawing.Font("DINPro-Bold", 9F, System.Drawing.FontStyle.Bold);
            this.rbUSUActivo.Location = new System.Drawing.Point(0, 4);
            this.rbUSUActivo.Name = "rbUSUActivo";
            this.rbUSUActivo.Size = new System.Drawing.Size(71, 23);
            this.rbUSUActivo.TabIndex = 26;
            this.rbUSUActivo.TabStop = true;
            this.rbUSUActivo.Text = "Activo";
            this.rbUSUActivo.UseVisualStyleBackColor = true;
            // 
            // rbUSUInactivo
            // 
            this.rbUSUInactivo.AutoSize = true;
            this.rbUSUInactivo.Font = new System.Drawing.Font("DINPro-Bold", 9F, System.Drawing.FontStyle.Bold);
            this.rbUSUInactivo.Location = new System.Drawing.Point(89, 4);
            this.rbUSUInactivo.Name = "rbUSUInactivo";
            this.rbUSUInactivo.Size = new System.Drawing.Size(83, 23);
            this.rbUSUInactivo.TabIndex = 27;
            this.rbUSUInactivo.TabStop = true;
            this.rbUSUInactivo.Text = "Inactivo";
            this.rbUSUInactivo.UseVisualStyleBackColor = true;
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.AllowUserToAddRows = false;
            this.dtgUsuarios.AllowUserToDeleteRows = false;
            this.dtgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("DINPro-Medium", 10.2F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgUsuarios.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgUsuarios.EnableHeadersVisualStyles = false;
            this.dtgUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.dtgUsuarios.Location = new System.Drawing.Point(9, 60);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.ReadOnly = true;
            this.dtgUsuarios.RowHeadersWidth = 51;
            this.dtgUsuarios.RowTemplate.Height = 24;
            this.dtgUsuarios.Size = new System.Drawing.Size(579, 450);
            this.dtgUsuarios.TabIndex = 41;
            this.dtgUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuarios_CellDoubleClick);
            // 
            // cbxUSUAccesibilidad
            // 
            this.cbxUSUAccesibilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUSUAccesibilidad.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.cbxUSUAccesibilidad.FormattingEnabled = true;
            this.cbxUSUAccesibilidad.Items.AddRange(new object[] {
            "Administrador",
            "Registro",
            "Caja"});
            this.cbxUSUAccesibilidad.Location = new System.Drawing.Point(142, 159);
            this.cbxUSUAccesibilidad.Name = "cbxUSUAccesibilidad";
            this.cbxUSUAccesibilidad.Size = new System.Drawing.Size(240, 30);
            this.cbxUSUAccesibilidad.TabIndex = 33;
            // 
            // txtUSUClave
            // 
            this.txtUSUClave.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.txtUSUClave.Location = new System.Drawing.Point(21, 43);
            this.txtUSUClave.Name = "txtUSUClave";
            this.txtUSUClave.ReadOnly = true;
            this.txtUSUClave.Size = new System.Drawing.Size(219, 29);
            this.txtUSUClave.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 34;
            this.label1.Text = "Clave";
            // 
            // btnUSURestablecer
            // 
            this.btnUSURestablecer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.btnUSURestablecer.FlatAppearance.BorderSize = 0;
            this.btnUSURestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUSURestablecer.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnUSURestablecer.ForeColor = System.Drawing.Color.White;
            this.btnUSURestablecer.Location = new System.Drawing.Point(246, 40);
            this.btnUSURestablecer.Name = "btnUSURestablecer";
            this.btnUSURestablecer.Size = new System.Drawing.Size(136, 32);
            this.btnUSURestablecer.TabIndex = 36;
            this.btnUSURestablecer.Text = "Restablecer";
            this.btnUSURestablecer.UseVisualStyleBackColor = false;
            this.btnUSURestablecer.Click += new System.EventHandler(this.btnUSURestablecer_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnUSURestablecer);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtUSUClave);
            this.panel2.Location = new System.Drawing.Point(603, 373);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 86);
            this.panel2.TabIndex = 42;
            // 
            // txtUSUID
            // 
            this.txtUSUID.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.txtUSUID.Location = new System.Drawing.Point(621, 465);
            this.txtUSUID.Name = "txtUSUID";
            this.txtUSUID.ReadOnly = true;
            this.txtUSUID.Size = new System.Drawing.Size(32, 29);
            this.txtUSUID.TabIndex = 37;
            this.txtUSUID.Visible = false;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtUSUID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbxUSUCriterio);
            this.Controls.Add(this.txtUSUDato);
            this.Controls.Add(this.btnUSUBuscar);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.dtgUsuarios);
            this.Controls.Add(this.panel2);
            this.Name = "Usuarios";
            this.Size = new System.Drawing.Size(1011, 523);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxUSUCriterio;
        private System.Windows.Forms.TextBox txtUSUDato;
        private System.Windows.Forms.Button btnUSUBuscar;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button btnUSUEliminar;
        private System.Windows.Forms.Button btnUSUGuardar;
        private System.Windows.Forms.Button btnUSUModificar;
        private System.Windows.Forms.Button btnUSULimpiar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUSUIdentificador;
        private System.Windows.Forms.TextBox txtUSUNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbUSUActivo;
        private System.Windows.Forms.RadioButton rbUSUInactivo;
        private System.Windows.Forms.DataGridView dtgUsuarios;
        private System.Windows.Forms.ComboBox cbxUSUAccesibilidad;
        private System.Windows.Forms.Button btnUSURestablecer;
        private System.Windows.Forms.TextBox txtUSUClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUSUID;
    }
}
