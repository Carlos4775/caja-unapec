namespace Caja_UNAPEC
{
    partial class Servicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel18 = new System.Windows.Forms.Panel();
            this.txtSVID = new System.Windows.Forms.MaskedTextBox();
            this.btnSVEliminar = new System.Windows.Forms.Button();
            this.btnSVGuardar = new System.Windows.Forms.Button();
            this.btnSVModificar = new System.Windows.Forms.Button();
            this.btnSVLimpiar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSVDescripcion = new System.Windows.Forms.TextBox();
            this.txtSVNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxSVCriterio = new System.Windows.Forms.ComboBox();
            this.txtSVDato = new System.Windows.Forms.TextBox();
            this.btnSVBuscar = new System.Windows.Forms.Button();
            this.dtgServicios = new System.Windows.Forms.DataGridView();
            this.txtSVMonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel18
            // 
            this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel18.Controls.Add(this.txtSVMonto);
            this.panel18.Controls.Add(this.label1);
            this.panel18.Controls.Add(this.txtSVID);
            this.panel18.Controls.Add(this.btnSVEliminar);
            this.panel18.Controls.Add(this.btnSVGuardar);
            this.panel18.Controls.Add(this.btnSVModificar);
            this.panel18.Controls.Add(this.btnSVLimpiar);
            this.panel18.Controls.Add(this.label9);
            this.panel18.Controls.Add(this.txtSVDescripcion);
            this.panel18.Controls.Add(this.txtSVNombre);
            this.panel18.Controls.Add(this.label6);
            this.panel18.Controls.Add(this.label10);
            this.panel18.Controls.Add(this.label11);
            this.panel18.Controls.Add(this.label12);
            this.panel18.Location = new System.Drawing.Point(603, 60);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(398, 367);
            this.panel18.TabIndex = 32;
            // 
            // txtSVID
            // 
            this.txtSVID.Location = new System.Drawing.Point(20, 222);
            this.txtSVID.Name = "txtSVID";
            this.txtSVID.ReadOnly = true;
            this.txtSVID.Size = new System.Drawing.Size(37, 22);
            this.txtSVID.TabIndex = 26;
            this.txtSVID.Visible = false;
            // 
            // btnSVEliminar
            // 
            this.btnSVEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSVEliminar.FlatAppearance.BorderSize = 0;
            this.btnSVEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSVEliminar.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSVEliminar.ForeColor = System.Drawing.Color.White;
            this.btnSVEliminar.Location = new System.Drawing.Point(261, 316);
            this.btnSVEliminar.Name = "btnSVEliminar";
            this.btnSVEliminar.Size = new System.Drawing.Size(115, 32);
            this.btnSVEliminar.TabIndex = 24;
            this.btnSVEliminar.Text = "Eliminar";
            this.btnSVEliminar.UseVisualStyleBackColor = false;
            this.btnSVEliminar.Click += new System.EventHandler(this.BtnSVEliminar_Click);
            // 
            // btnSVGuardar
            // 
            this.btnSVGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.btnSVGuardar.FlatAppearance.BorderSize = 0;
            this.btnSVGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSVGuardar.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSVGuardar.ForeColor = System.Drawing.Color.White;
            this.btnSVGuardar.Location = new System.Drawing.Point(11, 316);
            this.btnSVGuardar.Name = "btnSVGuardar";
            this.btnSVGuardar.Size = new System.Drawing.Size(115, 32);
            this.btnSVGuardar.TabIndex = 23;
            this.btnSVGuardar.Text = "Guardar";
            this.btnSVGuardar.UseVisualStyleBackColor = false;
            this.btnSVGuardar.Click += new System.EventHandler(this.BtnSVGuardar_Click);
            // 
            // btnSVModificar
            // 
            this.btnSVModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.btnSVModificar.FlatAppearance.BorderSize = 0;
            this.btnSVModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSVModificar.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSVModificar.ForeColor = System.Drawing.Color.White;
            this.btnSVModificar.Location = new System.Drawing.Point(136, 316);
            this.btnSVModificar.Name = "btnSVModificar";
            this.btnSVModificar.Size = new System.Drawing.Size(115, 32);
            this.btnSVModificar.TabIndex = 22;
            this.btnSVModificar.Text = "Modificar";
            this.btnSVModificar.UseVisualStyleBackColor = false;
            this.btnSVModificar.Click += new System.EventHandler(this.BtnSVModificar_Click);
            // 
            // btnSVLimpiar
            // 
            this.btnSVLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.btnSVLimpiar.FlatAppearance.BorderSize = 0;
            this.btnSVLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSVLimpiar.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSVLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnSVLimpiar.Location = new System.Drawing.Point(292, 24);
            this.btnSVLimpiar.Name = "btnSVLimpiar";
            this.btnSVLimpiar.Size = new System.Drawing.Size(90, 32);
            this.btnSVLimpiar.TabIndex = 3;
            this.btnSVLimpiar.Text = "Limpiar";
            this.btnSVLimpiar.UseVisualStyleBackColor = false;
            this.btnSVLimpiar.Click += new System.EventHandler(this.BtnSVLimpiar_Click);
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
            // txtSVDescripcion
            // 
            this.txtSVDescripcion.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.txtSVDescripcion.Location = new System.Drawing.Point(142, 125);
            this.txtSVDescripcion.Multiline = true;
            this.txtSVDescripcion.Name = "txtSVDescripcion";
            this.txtSVDescripcion.Size = new System.Drawing.Size(241, 119);
            this.txtSVDescripcion.TabIndex = 11;
            // 
            // txtSVNombre
            // 
            this.txtSVNombre.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.txtSVNombre.Location = new System.Drawing.Point(142, 91);
            this.txtSVNombre.Name = "txtSVNombre";
            this.txtSVNombre.Size = new System.Drawing.Size(241, 29);
            this.txtSVNombre.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(16, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Descripción";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(16, 94);
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
            this.label11.Size = new System.Drawing.Size(120, 32);
            this.label11.TabIndex = 1;
            this.label11.Text = "Servicios";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.label12.Location = new System.Drawing.Point(6, 282);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(376, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "______________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(260, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 22);
            this.label3.TabIndex = 47;
            this.label3.Text = "Dato";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(16, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 22);
            this.label13.TabIndex = 43;
            this.label13.Text = "Criterio";
            // 
            // cbxSVCriterio
            // 
            this.cbxSVCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSVCriterio.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.cbxSVCriterio.FormattingEnabled = true;
            this.cbxSVCriterio.Items.AddRange(new object[] {
            "Nombre",
            "Descripción"});
            this.cbxSVCriterio.Location = new System.Drawing.Point(93, 15);
            this.cbxSVCriterio.Name = "cbxSVCriterio";
            this.cbxSVCriterio.Size = new System.Drawing.Size(150, 30);
            this.cbxSVCriterio.TabIndex = 44;
            // 
            // txtSVDato
            // 
            this.txtSVDato.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.txtSVDato.Location = new System.Drawing.Point(310, 16);
            this.txtSVDato.Name = "txtSVDato";
            this.txtSVDato.Size = new System.Drawing.Size(150, 29);
            this.txtSVDato.TabIndex = 45;
            // 
            // btnSVBuscar
            // 
            this.btnSVBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.btnSVBuscar.FlatAppearance.BorderSize = 0;
            this.btnSVBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(92)))), ((int)(((byte)(166)))));
            this.btnSVBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSVBuscar.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSVBuscar.ForeColor = System.Drawing.Color.White;
            this.btnSVBuscar.Location = new System.Drawing.Point(478, 13);
            this.btnSVBuscar.Name = "btnSVBuscar";
            this.btnSVBuscar.Size = new System.Drawing.Size(115, 32);
            this.btnSVBuscar.TabIndex = 46;
            this.btnSVBuscar.Text = "Buscar";
            this.btnSVBuscar.UseVisualStyleBackColor = false;
            this.btnSVBuscar.Click += new System.EventHandler(this.BtnSVBuscar_Click);
            // 
            // dtgServicios
            // 
            this.dtgServicios.AllowUserToAddRows = false;
            this.dtgServicios.AllowUserToDeleteRows = false;
            this.dtgServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgServicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgServicios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("DINPro-Medium", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgServicios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgServicios.EnableHeadersVisualStyles = false;
            this.dtgServicios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.dtgServicios.Location = new System.Drawing.Point(12, 60);
            this.dtgServicios.Name = "dtgServicios";
            this.dtgServicios.ReadOnly = true;
            this.dtgServicios.RowHeadersWidth = 51;
            this.dtgServicios.RowTemplate.Height = 24;
            this.dtgServicios.Size = new System.Drawing.Size(579, 450);
            this.dtgServicios.TabIndex = 48;
            this.dtgServicios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgServicios_CellDoubleClick);
            // 
            // txtSVMonto
            // 
            this.txtSVMonto.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.txtSVMonto.Location = new System.Drawing.Point(141, 250);
            this.txtSVMonto.Name = "txtSVMonto";
            this.txtSVMonto.Size = new System.Drawing.Size(241, 29);
            this.txtSVMonto.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Monto";
            // 
            // Servicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbxSVCriterio);
            this.Controls.Add(this.txtSVDato);
            this.Controls.Add(this.btnSVBuscar);
            this.Controls.Add(this.dtgServicios);
            this.Controls.Add(this.panel18);
            this.Name = "Servicio";
            this.Size = new System.Drawing.Size(1011, 523);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button btnSVEliminar;
        private System.Windows.Forms.Button btnSVGuardar;
        private System.Windows.Forms.Button btnSVModificar;
        private System.Windows.Forms.Button btnSVLimpiar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSVDescripcion;
        private System.Windows.Forms.TextBox txtSVNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxSVCriterio;
        private System.Windows.Forms.TextBox txtSVDato;
        private System.Windows.Forms.Button btnSVBuscar;
        private System.Windows.Forms.DataGridView dtgServicios;
        private System.Windows.Forms.MaskedTextBox txtSVID;
        private System.Windows.Forms.TextBox txtSVMonto;
        private System.Windows.Forms.Label label1;
    }
}
