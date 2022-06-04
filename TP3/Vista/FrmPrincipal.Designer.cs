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
            this.SuspendLayout();
            // 
            // btnCargarVecino
            // 
            this.btnCargarVecino.Location = new System.Drawing.Point(27, 37);
            this.btnCargarVecino.Name = "btnCargarVecino";
            this.btnCargarVecino.Size = new System.Drawing.Size(273, 36);
            this.btnCargarVecino.TabIndex = 0;
            this.btnCargarVecino.Text = "Cargar vecino";
            this.btnCargarVecino.UseVisualStyleBackColor = true;
            this.btnCargarVecino.Click += new System.EventHandler(this.btnCargarVecino_Click);
            // 
            // btnCargarEmpleado
            // 
            this.btnCargarEmpleado.Location = new System.Drawing.Point(27, 117);
            this.btnCargarEmpleado.Name = "btnCargarEmpleado";
            this.btnCargarEmpleado.Size = new System.Drawing.Size(273, 36);
            this.btnCargarEmpleado.TabIndex = 1;
            this.btnCargarEmpleado.Text = "Cargar empleado";
            this.btnCargarEmpleado.UseVisualStyleBackColor = true;
            this.btnCargarEmpleado.Click += new System.EventHandler(this.btnCargarEmpleado_Click);
            // 
            // btnCargarReclamo
            // 
            this.btnCargarReclamo.Location = new System.Drawing.Point(27, 197);
            this.btnCargarReclamo.Name = "btnCargarReclamo";
            this.btnCargarReclamo.Size = new System.Drawing.Size(273, 36);
            this.btnCargarReclamo.TabIndex = 2;
            this.btnCargarReclamo.Text = "Cargar reclamo";
            this.btnCargarReclamo.UseVisualStyleBackColor = true;
            this.btnCargarReclamo.Click += new System.EventHandler(this.btnCargarReclamo_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 270);
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
    }
}
