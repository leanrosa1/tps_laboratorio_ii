namespace Vista
{
    partial class FrmVerReclamos
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
            this.rtbReclamos = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbReclamos
            // 
            this.rtbReclamos.Location = new System.Drawing.Point(12, 15);
            this.rtbReclamos.Name = "rtbReclamos";
            this.rtbReclamos.Size = new System.Drawing.Size(320, 434);
            this.rtbReclamos.TabIndex = 5;
            this.rtbReclamos.Text = "";
            // 
            // FrmVerReclamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 463);
            this.Controls.Add(this.rtbReclamos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVerReclamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reclamos";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbReclamos;
    }
}