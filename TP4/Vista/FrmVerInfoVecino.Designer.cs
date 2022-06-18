namespace Vista
{
    partial class FrmVerInfoVecino
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
            this.rtbInfoVecino = new System.Windows.Forms.RichTextBox();
            this.btnSeleccionarVecino = new System.Windows.Forms.Button();
            this.lblVecino = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbInfoVecino
            // 
            this.rtbInfoVecino.Location = new System.Drawing.Point(12, 68);
            this.rtbInfoVecino.Name = "rtbInfoVecino";
            this.rtbInfoVecino.Size = new System.Drawing.Size(320, 378);
            this.rtbInfoVecino.TabIndex = 5;
            this.rtbInfoVecino.Text = "";
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
            // lblVecino
            // 
            this.lblVecino.AutoSize = true;
            this.lblVecino.Location = new System.Drawing.Point(199, 30);
            this.lblVecino.Name = "lblVecino";
            this.lblVecino.Size = new System.Drawing.Size(118, 15);
            this.lblVecino.TabIndex = 13;
            this.lblVecino.Text = "Aún no seleccionado";
            // 
            // FrmVerInfoVecino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 463);
            this.Controls.Add(this.lblVecino);
            this.Controls.Add(this.btnSeleccionarVecino);
            this.Controls.Add(this.rtbInfoVecino);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVerInfoVecino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información de vecino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbInfoVecino;
        private System.Windows.Forms.Button btnSeleccionarVecino;
        private System.Windows.Forms.Label lblVecino;
    }
}