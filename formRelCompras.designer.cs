namespace trabFinal
{
    partial class formRelCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRelCompras));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecoFinal = new System.Windows.Forms.TextBox();
            this.txtPrecoInicial = new System.Windows.Forms.TextBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btGerar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPrecoFinal);
            this.groupBox1.Controls.Add(this.txtPrecoInicial);
            this.groupBox1.Controls.Add(this.btSair);
            this.groupBox1.Controls.Add(this.btGerar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 156);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Intervalo por Preço Total de Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Preço Total Máximo (R$)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Preço Total Mínimo (R$)";
            // 
            // txtPrecoFinal
            // 
            this.txtPrecoFinal.Location = new System.Drawing.Point(12, 105);
            this.txtPrecoFinal.Name = "txtPrecoFinal";
            this.txtPrecoFinal.Size = new System.Drawing.Size(143, 20);
            this.txtPrecoFinal.TabIndex = 7;
            // 
            // txtPrecoInicial
            // 
            this.txtPrecoInicial.Location = new System.Drawing.Point(12, 47);
            this.txtPrecoInicial.Name = "txtPrecoInicial";
            this.txtPrecoInicial.Size = new System.Drawing.Size(143, 20);
            this.txtPrecoInicial.TabIndex = 6;
            // 
            // btSair
            // 
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSair.Location = new System.Drawing.Point(177, 89);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(70, 48);
            this.btSair.TabIndex = 5;
            this.btSair.Text = "&Sair";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click_1);
            // 
            // btGerar
            // 
            this.btGerar.Image = ((System.Drawing.Image)(resources.GetObject("btGerar.Image")));
            this.btGerar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGerar.Location = new System.Drawing.Point(177, 19);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(70, 48);
            this.btGerar.TabIndex = 4;
            this.btGerar.Text = "&Gerar";
            this.btGerar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGerar.UseVisualStyleBackColor = true;
            this.btGerar.Click += new System.EventHandler(this.btGerar_Click);
            // 
            // formRelCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 146);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "formRelCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Compras";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btGerar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecoFinal;
        private System.Windows.Forms.TextBox txtPrecoInicial;
        private System.Windows.Forms.Button btSair;
    }
}