namespace Caja_UNAPEC
{
    partial class FormaDePago
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
            this.txtFPID = new System.Windows.Forms.MaskedTextBox();
            this.btnFPEliminar = new System.Windows.Forms.Button();
            this.btnFPGuardar = new System.Windows.Forms.Button();
            this.btnFPModificar = new System.Windows.Forms.Button();
            this.btnFPLimpiar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFPDescripcion = new System.Windows.Forms.TextBox();
            this.txtFPNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxFPCriterio = new System.Windows.Forms.ComboBox();
            this.txtFPDato = new System.Windows.Forms.TextBox();
            this.btnFPBuscar = new System.Windows.Forms.Button();
            this.dtgFormaPago = new System.Windows.Forms.DataGridView();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFormaPago)).BeginInit();
            this.SuspendLayout();
            // 
            // panel18
            // 
            this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel18.Controls.Add(this.txtFPID);
            this.panel18.Controls.Add(this.btnFPEliminar);
            this.panel18.Controls.Add(this.btnFPGuardar);
            this.panel18.Controls.Add(this.btnFPModificar);
            this.panel18.Controls.Add(this.btnFPLimpiar);
            this.panel18.Controls.Add(this.label9);
            this.panel18.Controls.Add(this.txtFPDescripcion);
            this.panel18.Controls.Add(this.txtFPNombre);
            this.panel18.Controls.Add(this.label6);
            this.panel18.Controls.Add(this.label10);
            this.panel18.Controls.Add(this.label11);
            this.panel18.Controls.Add(this.label12);
            this.panel18.Location = new System.Drawing.Point(603, 60);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(398, 341);
            this.panel18.TabIndex = 36;
            // 
            // txtFPID
            // 
            this.txtFPID.Location = new System.Drawing.Point(17, 222);
            this.txtFPID.Name = "txtFPID";
            this.txtFPID.ReadOnly = true;
            this.txtFPID.Size = new System.Drawing.Size(37, 22);
            this.txtFPID.TabIndex = 43;
            this.txtFPID.Visible = false;
            // 
            // btnFPEliminar
            // 
            this.btnFPEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFPEliminar.FlatAppearance.BorderSize = 0;
            this.btnFPEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFPEliminar.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnFPEliminar.ForeColor = System.Drawing.Color.White;
            this.btnFPEliminar.Location = new System.Drawing.Point(267, 281);
            this.btnFPEliminar.Name = "btnFPEliminar";
            this.btnFPEliminar.Size = new System.Drawing.Size(115, 32);
            this.btnFPEliminar.TabIndex = 24;
            this.btnFPEliminar.Text = "Eliminar";
            this.btnFPEliminar.UseVisualStyleBackColor = false;
            this.btnFPEliminar.Click += new System.EventHandler(this.BtnFPEliminar_Click);
            // 
            // btnFPGuardar
            // 
            this.btnFPGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.btnFPGuardar.FlatAppearance.BorderSize = 0;
            this.btnFPGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFPGuardar.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnFPGuardar.ForeColor = System.Drawing.Color.White;
            this.btnFPGuardar.Location = new System.Drawing.Point(17, 281);
            this.btnFPGuardar.Name = "btnFPGuardar";
            this.btnFPGuardar.Size = new System.Drawing.Size(115, 32);
            this.btnFPGuardar.TabIndex = 23;
            this.btnFPGuardar.Text = "Guardar";
            this.btnFPGuardar.UseVisualStyleBackColor = false;
            this.btnFPGuardar.Click += new System.EventHandler(this.BtnFPGuardar_Click);
            // 
            // btnFPModificar
            // 
            this.btnFPModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.btnFPModificar.FlatAppearance.BorderSize = 0;
            this.btnFPModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFPModificar.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnFPModificar.ForeColor = System.Drawing.Color.White;
            this.btnFPModificar.Location = new System.Drawing.Point(142, 281);
            this.btnFPModificar.Name = "btnFPModificar";
            this.btnFPModificar.Size = new System.Drawing.Size(115, 32);
            this.btnFPModificar.TabIndex = 22;
            this.btnFPModificar.Text = "Modificar";
            this.btnFPModificar.UseVisualStyleBackColor = false;
            this.btnFPModificar.Click += new System.EventHandler(this.BtnFPModificar_Click);
            // 
            // btnFPLimpiar
            // 
            this.btnFPLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.btnFPLimpiar.FlatAppearance.BorderSize = 0;
            this.btnFPLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFPLimpiar.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnFPLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnFPLimpiar.Location = new System.Drawing.Point(292, 24);
            this.btnFPLimpiar.Name = "btnFPLimpiar";
            this.btnFPLimpiar.Size = new System.Drawing.Size(90, 32);
            this.btnFPLimpiar.TabIndex = 3;
            this.btnFPLimpiar.Text = "Limpiar";
            this.btnFPLimpiar.UseVisualStyleBackColor = false;
            this.btnFPLimpiar.Click += new System.EventHandler(this.BtnFPLimpiar_Click);
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
            // txtFPDescripcion
            // 
            this.txtFPDescripcion.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.txtFPDescripcion.Location = new System.Drawing.Point(142, 125);
            this.txtFPDescripcion.Multiline = true;
            this.txtFPDescripcion.Name = "txtFPDescripcion";
            this.txtFPDescripcion.Size = new System.Drawing.Size(241, 119);
            this.txtFPDescripcion.TabIndex = 11;
            // 
            // txtFPNombre
            // 
            this.txtFPNombre.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.txtFPNombre.Location = new System.Drawing.Point(142, 91);
            this.txtFPNombre.Name = "txtFPNombre";
            this.txtFPNombre.Size = new System.Drawing.Size(241, 29);
            this.txtFPNombre.TabIndex = 2;
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
            this.label11.Size = new System.Drawing.Size(199, 32);
            this.label11.TabIndex = 1;
            this.label11.Text = "Formas de Pago";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.label12.Location = new System.Drawing.Point(12, 247);
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
            this.label3.TabIndex = 41;
            this.label3.Text = "Dato";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(16, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 22);
            this.label13.TabIndex = 37;
            this.label13.Text = "Criterio";
            // 
            // cbxFPCriterio
            // 
            this.cbxFPCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFPCriterio.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.cbxFPCriterio.FormattingEnabled = true;
            this.cbxFPCriterio.Items.AddRange(new object[] {
            "Nombre",
            "Descripción"});
            this.cbxFPCriterio.Location = new System.Drawing.Point(93, 15);
            this.cbxFPCriterio.Name = "cbxFPCriterio";
            this.cbxFPCriterio.Size = new System.Drawing.Size(150, 30);
            this.cbxFPCriterio.TabIndex = 38;
            // 
            // txtFPDato
            // 
            this.txtFPDato.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.txtFPDato.Location = new System.Drawing.Point(310, 16);
            this.txtFPDato.Name = "txtFPDato";
            this.txtFPDato.Size = new System.Drawing.Size(150, 29);
            this.txtFPDato.TabIndex = 39;
            // 
            // btnFPBuscar
            // 
            this.btnFPBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.btnFPBuscar.FlatAppearance.BorderSize = 0;
            this.btnFPBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(92)))), ((int)(((byte)(166)))));
            this.btnFPBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFPBuscar.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnFPBuscar.ForeColor = System.Drawing.Color.White;
            this.btnFPBuscar.Location = new System.Drawing.Point(478, 13);
            this.btnFPBuscar.Name = "btnFPBuscar";
            this.btnFPBuscar.Size = new System.Drawing.Size(115, 32);
            this.btnFPBuscar.TabIndex = 40;
            this.btnFPBuscar.Text = "Buscar";
            this.btnFPBuscar.UseVisualStyleBackColor = false;
            this.btnFPBuscar.Click += new System.EventHandler(this.BtnFPBuscar_Click);
            // 
            // dtgFormaPago
            // 
            this.dtgFormaPago.AllowUserToAddRows = false;
            this.dtgFormaPago.AllowUserToDeleteRows = false;
            this.dtgFormaPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgFormaPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgFormaPago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("DINPro-Bold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgFormaPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgFormaPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("DINPro-Medium", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgFormaPago.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgFormaPago.EnableHeadersVisualStyles = false;
            this.dtgFormaPago.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(72)))), ((int)(((byte)(146)))));
            this.dtgFormaPago.Location = new System.Drawing.Point(12, 60);
            this.dtgFormaPago.Name = "dtgFormaPago";
            this.dtgFormaPago.ReadOnly = true;
            this.dtgFormaPago.RowHeadersWidth = 51;
            this.dtgFormaPago.RowTemplate.Height = 24;
            this.dtgFormaPago.Size = new System.Drawing.Size(579, 450);
            this.dtgFormaPago.TabIndex = 42;
            this.dtgFormaPago.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgFormaPago_CellDoubleClick);
            // 
            // FormaDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbxFPCriterio);
            this.Controls.Add(this.txtFPDato);
            this.Controls.Add(this.btnFPBuscar);
            this.Controls.Add(this.dtgFormaPago);
            this.Controls.Add(this.panel18);
            this.Name = "FormaDePago";
            this.Size = new System.Drawing.Size(1011, 523);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFormaPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button btnFPEliminar;
        private System.Windows.Forms.Button btnFPGuardar;
        private System.Windows.Forms.Button btnFPModificar;
        private System.Windows.Forms.Button btnFPLimpiar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFPDescripcion;
        private System.Windows.Forms.TextBox txtFPNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxFPCriterio;
        private System.Windows.Forms.TextBox txtFPDato;
        private System.Windows.Forms.Button btnFPBuscar;
        private System.Windows.Forms.DataGridView dtgFormaPago;
        private System.Windows.Forms.MaskedTextBox txtFPID;
    }
}
