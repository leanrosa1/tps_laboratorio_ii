namespace Vista
{
    partial class FrmCargarReclamo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.rtbObservacion = new System.Windows.Forms.RichTextBox();
            this.btnSeleccionarVecino = new System.Windows.Forms.Button();
            this.btnSeleccionarEmpleado = new System.Windows.Forms.Button();
            this.lblVecino = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.Location = new System.Drawing.Point(12, 188);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 16);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblObservacion.Location = new System.Drawing.Point(13, 266);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(82, 16);
            this.lblObservacion.TabIndex = 2;
            this.lblObservacion.Text = "Observación:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(84, 452);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(171, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(13, 144);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(304, 23);
            this.dtpFecha.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(12, 116);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 16);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(13, 220);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(304, 23);
            this.cmbTipo.TabIndex = 4;
            // 
            // rtbObservacion
            // 
            this.rtbObservacion.Location = new System.Drawing.Point(12, 296);
            this.rtbObservacion.Name = "rtbObservacion";
            this.rtbObservacion.Size = new System.Drawing.Size(305, 120);
            this.rtbObservacion.TabIndex = 5;
            this.rtbObservacion.Text = "";
            // 
            // btnSeleccionarVecino
            // 
            this.btnSeleccionarVecino.Location = new System.Drawing.Point(13, 26);
            this.btnSeleccionarVecino.Name = "btnSeleccionarVecino";
            this.btnSeleccionarVecino.Size = new System.Drawing.Size(162, 23);
            this.btnSeleccionarVecino.TabIndex = 1;
            this.btnSeleccionarVecino.Text = "Seleccionar vecino";
            this.btnSeleccionarVecino.UseVisualStyleBackColor = true;
            this.btnSeleccionarVecino.Click += new System.EventHandler(this.btnSeleccionarVecino_Click);
            // 
            // btnSeleccionarEmpleado
            // 
            this.btnSeleccionarEmpleado.Location = new System.Drawing.Point(13, 68);
            this.btnSeleccionarEmpleado.Name = "btnSeleccionarEmpleado";
            this.btnSeleccionarEmpleado.Size = new System.Drawing.Size(162, 23);
            this.btnSeleccionarEmpleado.TabIndex = 2;
            this.btnSeleccionarEmpleado.Text = "Seleccionar empleado";
            this.btnSeleccionarEmpleado.UseVisualStyleBackColor = true;
            this.btnSeleccionarEmpleado.Click += new System.EventHandler(this.btnSeleccionarEmpleado_Click);
            // 
            // lblVecino
            // 
            this.lblVecino.AutoSize = true;
            this.lblVecino.Location = new System.Drawing.Point(199, 30);
            this.lblVecino.Name = "lblVecino";
            this.lblVecino.Size = new System.Drawing.Size(118, 15);
            this.lblVecino.TabIndex = 13;
            this.lblVecino.Text = "Aún no seleccionado";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(199, 72);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(118, 15);
            this.lblEmpleado.TabIndex = 14;
            this.lblEmpleado.Text = "Aún no seleccionado";
            // 
            // FrmCargarReclamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 487);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblVecino);
            this.Controls.Add(this.btnSeleccionarEmpleado);
            this.Controls.Add(this.btnSeleccionarVecino);
            this.Controls.Add(this.rtbObservacion);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.lblTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCargarReclamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo reclamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.RichTextBox rtbObservacion;
        private System.Windows.Forms.Button btnSeleccionarVecino;
        private System.Windows.Forms.Button btnSeleccionarEmpleado;
        private System.Windows.Forms.Label lblVecino;
        private System.Windows.Forms.Label lblEmpleado;
    }
}