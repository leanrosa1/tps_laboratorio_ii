namespace Vista
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCargarVecino = new System.Windows.Forms.Button();
            this.btnCargarEmpleado = new System.Windows.Forms.Button();
            this.btnCargarReclamo = new System.Windows.Forms.Button();
            this.btnVerInfoVecino = new System.Windows.Forms.Button();
            this.btnVerReclamos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargarVecino
            // 
            this.btnCargarVecino.Location = new System.Drawing.Point(27, 37);
            this.btnCargarVecino.Name = "btnCargarVecino";
            this.btnCargarVecino.Size = new System.Drawing.Size(273, 36);
            this.btnCargarVecino.TabIndex = 1;
            this.btnCargarVecino.Text = "Cargar vecino";
            this.btnCargarVecino.UseVisualStyleBackColor = true;
            this.btnCargarVecino.Click += new System.EventHandler(this.btnCargarVecino_Click);
            // 
            // btnCargarEmpleado
            // 
            this.btnCargarEmpleado.Location = new System.Drawing.Point(27, 117);
            this.btnCargarEmpleado.Name = "btnCargarEmpleado";
            this.btnCargarEmpleado.Size = new System.Drawing.Size(273, 36);
            this.btnCargarEmpleado.TabIndex = 2;
            this.btnCargarEmpleado.Text = "Cargar empleado";
            this.btnCargarEmpleado.UseVisualStyleBackColor = true;
            this.btnCargarEmpleado.Click += new System.EventHandler(this.btnCargarEmpleado_Click);
            // 
            // btnCargarReclamo
            // 
            this.btnCargarReclamo.Location = new System.Drawing.Point(27, 197);
            this.btnCargarReclamo.Name = "btnCargarReclamo";
            this.btnCargarReclamo.Size = new System.Drawing.Size(273, 36);
            this.btnCargarReclamo.TabIndex = 3;
            this.btnCargarReclamo.Text = "Cargar reclamo";
            this.btnCargarReclamo.UseVisualStyleBackColor = true;
            this.btnCargarReclamo.Click += new System.EventHandler(this.btnCargarReclamo_Click);
            // 
            // btnVerInfoVecino
            // 
            this.btnVerInfoVecino.Location = new System.Drawing.Point(27, 276);
            this.btnVerInfoVecino.Name = "btnVerInfoVecino";
            this.btnVerInfoVecino.Size = new System.Drawing.Size(273, 36);
            this.btnVerInfoVecino.TabIndex = 4;
            this.btnVerInfoVecino.Text = "Ver información de vecino";
            this.btnVerInfoVecino.UseVisualStyleBackColor = true;
            this.btnVerInfoVecino.Click += new System.EventHandler(this.btnVerInfoVecino_Click);
            // 
            // btnVerReclamos
            // 
            this.btnVerReclamos.Enabled = false;
            this.btnVerReclamos.Location = new System.Drawing.Point(27, 352);
            this.btnVerReclamos.Name = "btnVerReclamos";
            this.btnVerReclamos.Size = new System.Drawing.Size(273, 36);
            this.btnVerReclamos.TabIndex = 5;
            this.btnVerReclamos.Text = "Ver reclamos";
            this.btnVerReclamos.UseVisualStyleBackColor = true;
            this.btnVerReclamos.Click += new System.EventHandler(this.btnVerReclamos_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 421);
            this.Controls.Add(this.btnVerReclamos);
            this.Controls.Add(this.btnVerInfoVecino);
            this.Controls.Add(this.btnCargarReclamo);
            this.Controls.Add(this.btnCargarEmpleado);
            this.Controls.Add(this.btnCargarVecino);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnCargarVecino;
        private System.Windows.Forms.Button btnCargarEmpleado;
        private System.Windows.Forms.Button btnCargarReclamo;
        private System.Windows.Forms.Button btnVerInfoVecino;
        private System.Windows.Forms.Button btnVerReclamos;
    }
}
