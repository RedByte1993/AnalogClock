namespace AnalogClock
{
    partial class AnalogClock
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Surface = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Surface
            // 
            this.Surface.BackColor = System.Drawing.Color.LightGray;
            this.Surface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Surface.Location = new System.Drawing.Point(0, 0);
            this.Surface.Name = "Surface";
            this.Surface.Size = new System.Drawing.Size(978, 944);
            this.Surface.TabIndex = 0;
            // 
            // AnalogClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 944);
            this.Controls.Add(this.Surface);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "AnalogClock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnalogClock";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Surface;
    }
}

