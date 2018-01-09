namespace trabFinal
{
    partial class formGrafFilmes
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
            this.webBrowserFilmes = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserFilmes
            // 
            this.webBrowserFilmes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserFilmes.Location = new System.Drawing.Point(0, 0);
            this.webBrowserFilmes.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserFilmes.Name = "webBrowserFilmes";
            this.webBrowserFilmes.Size = new System.Drawing.Size(962, 527);
            this.webBrowserFilmes.TabIndex = 0;
            // 
            // formGrafFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 527);
            this.Controls.Add(this.webBrowserFilmes);
            this.Name = "formGrafFilmes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gráfico Filmes e Compras";
            this.Activated += new System.EventHandler(this.formGrafFilmes_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserFilmes;
    }
}