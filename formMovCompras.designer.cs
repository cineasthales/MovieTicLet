namespace trabFinal
{
    partial class formMovCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMovCompras));
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.gbCad = new System.Windows.Forms.GroupBox();
            this.listSessoes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQnt = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSair = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btIncluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.gbCad.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 50);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(737, 219);
            this.dataGrid.TabIndex = 6;
            // 
            // gbCad
            // 
            this.gbCad.Controls.Add(this.listSessoes);
            this.gbCad.Controls.Add(this.label1);
            this.gbCad.Controls.Add(this.label7);
            this.gbCad.Controls.Add(this.cbUsuario);
            this.gbCad.Controls.Add(this.label6);
            this.gbCad.Controls.Add(this.txtQnt);
            this.gbCad.Controls.Add(this.txtPreco);
            this.gbCad.Controls.Add(this.label2);
            this.gbCad.Controls.Add(this.btCancelar);
            this.gbCad.Controls.Add(this.btOk);
            this.gbCad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbCad.Location = new System.Drawing.Point(0, 269);
            this.gbCad.Name = "gbCad";
            this.gbCad.Size = new System.Drawing.Size(737, 258);
            this.gbCad.TabIndex = 5;
            this.gbCad.TabStop = false;
            this.gbCad.Visible = false;
            // 
            // listSessoes
            // 
            this.listSessoes.FormattingEnabled = true;
            this.listSessoes.Location = new System.Drawing.Point(12, 32);
            this.listSessoes.Name = "listSessoes";
            this.listSessoes.Size = new System.Drawing.Size(460, 212);
            this.listSessoes.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Sessão";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(578, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Vendedor";
            // 
            // cbUsuario
            // 
            this.cbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(551, 124);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(112, 21);
            this.cbUsuario.TabIndex = 3;
            this.cbUsuario.SelectedIndexChanged += new System.EventHandler(this.listSessoes_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(631, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Quantidade";
            // 
            // txtQnt
            // 
            this.txtQnt.Location = new System.Drawing.Point(634, 50);
            this.txtQnt.Name = "txtQnt";
            this.txtQnt.Size = new System.Drawing.Size(79, 20);
            this.txtQnt.TabIndex = 5;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(496, 50);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(93, 20);
            this.txtPreco.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preço (R$)";
            // 
            // btCancelar
            // 
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCancelar.Location = new System.Drawing.Point(618, 194);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 50);
            this.btCancelar.TabIndex = 29;
            this.btCancelar.Text = "&Cancelar";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btOk
            // 
            this.btOk.Image = ((System.Drawing.Image)(resources.GetObject("btOk.Image")));
            this.btOk.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btOk.Location = new System.Drawing.Point(515, 194);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 50);
            this.btOk.TabIndex = 28;
            this.btOk.Text = "&Ok";
            this.btOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btSair);
            this.panel1.Controls.Add(this.btExcluir);
            this.panel1.Controls.Add(this.btAlterar);
            this.panel1.Controls.Add(this.btIncluir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 50);
            this.panel1.TabIndex = 4;
            // 
            // btSair
            // 
            this.btSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSair.Location = new System.Drawing.Point(662, 0);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 50);
            this.btSair.TabIndex = 3;
            this.btSair.Text = "&Sair";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btExcluir.Location = new System.Drawing.Point(150, 0);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 50);
            this.btExcluir.TabIndex = 2;
            this.btExcluir.Text = "&Excluir";
            this.btExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click_1);
            // 
            // btAlterar
            // 
            this.btAlterar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btAlterar.Image")));
            this.btAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAlterar.Location = new System.Drawing.Point(75, 0);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 50);
            this.btAlterar.TabIndex = 1;
            this.btAlterar.Text = "&Alterar";
            this.btAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btIncluir
            // 
            this.btIncluir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btIncluir.Image")));
            this.btIncluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btIncluir.Location = new System.Drawing.Point(0, 0);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(75, 50);
            this.btIncluir.TabIndex = 0;
            this.btIncluir.Text = "&Incluir";
            this.btIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // formMovCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 527);
            this.ControlBox = false;
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.gbCad);
            this.Controls.Add(this.panel1);
            this.Name = "formMovCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras de Ingressos";
            this.Activated += new System.EventHandler(this.formMovCompras_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.gbCad.ResumeLayout(false);
            this.gbCad.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.GroupBox gbCad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQnt;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.ListBox listSessoes;
    }
}