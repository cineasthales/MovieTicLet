namespace trabFinal
{
    partial class formCadFilmes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCadFilmes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSair = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btIncluir = new System.Windows.Forms.Button();
            this.gbCad = new System.Windows.Forms.GroupBox();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbClassificacao = new System.Windows.Forms.ComboBox();
            this.pbCartaz = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btCartaz = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSinopse = new System.Windows.Forms.TextBox();
            this.txtTituloNacional = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.txtTituloOriginal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.gbCad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCartaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(790, 50);
            this.panel1.TabIndex = 1;
            // 
            // btSair
            // 
            this.btSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSair.Location = new System.Drawing.Point(715, 0);
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
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
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
            // gbCad
            // 
            this.gbCad.Controls.Add(this.txtDuracao);
            this.gbCad.Controls.Add(this.label4);
            this.gbCad.Controls.Add(this.cbClassificacao);
            this.gbCad.Controls.Add(this.pbCartaz);
            this.gbCad.Controls.Add(this.panel2);
            this.gbCad.Controls.Add(this.btCartaz);
            this.gbCad.Controls.Add(this.label7);
            this.gbCad.Controls.Add(this.cbGenero);
            this.gbCad.Controls.Add(this.label6);
            this.gbCad.Controls.Add(this.txtSinopse);
            this.gbCad.Controls.Add(this.txtTituloNacional);
            this.gbCad.Controls.Add(this.label3);
            this.gbCad.Controls.Add(this.label2);
            this.gbCad.Controls.Add(this.btCancelar);
            this.gbCad.Controls.Add(this.btOk);
            this.gbCad.Controls.Add(this.txtTituloOriginal);
            this.gbCad.Controls.Add(this.label1);
            this.gbCad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbCad.Location = new System.Drawing.Point(0, 299);
            this.gbCad.Name = "gbCad";
            this.gbCad.Size = new System.Drawing.Size(790, 228);
            this.gbCad.TabIndex = 2;
            this.gbCad.TabStop = false;
            this.gbCad.Visible = false;
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(207, 141);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(70, 20);
            this.txtDuracao.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Duração (min)";
            // 
            // cbClassificacao
            // 
            this.cbClassificacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClassificacao.FormattingEnabled = true;
            this.cbClassificacao.Items.AddRange(new object[] {
            "0",
            "10",
            "12",
            "14",
            "16",
            "18"});
            this.cbClassificacao.Location = new System.Drawing.Point(16, 190);
            this.cbClassificacao.Name = "cbClassificacao";
            this.cbClassificacao.Size = new System.Drawing.Size(115, 21);
            this.cbClassificacao.TabIndex = 21;
            // 
            // pbCartaz
            // 
            this.pbCartaz.Location = new System.Drawing.Point(304, 19);
            this.pbCartaz.Name = "pbCartaz";
            this.pbCartaz.Size = new System.Drawing.Size(136, 188);
            this.pbCartaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCartaz.TabIndex = 18;
            this.pbCartaz.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(308, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 192);
            this.panel2.TabIndex = 20;
            // 
            // btCartaz
            // 
            this.btCartaz.Location = new System.Drawing.Point(155, 184);
            this.btCartaz.Name = "btCartaz";
            this.btCartaz.Size = new System.Drawing.Size(122, 27);
            this.btCartaz.TabIndex = 9;
            this.btCartaz.Text = "Ca&rregar cartaz...";
            this.btCartaz.UseVisualStyleBackColor = true;
            this.btCartaz.Click += new System.EventHandler(this.btCartaz_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Gênero";
            // 
            // cbGenero
            // 
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Ação",
            "Animação",
            "Aventura",
            "Comédia",
            "Documentário",
            "Drama",
            "Fantasia",
            "Ficção Científica",
            "Musical",
            "Romance",
            "Suspense",
            "Terror"});
            this.cbGenero.Location = new System.Drawing.Point(16, 141);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(172, 21);
            this.cbGenero.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Classificação Indicativa";
            // 
            // txtSinopse
            // 
            this.txtSinopse.Location = new System.Drawing.Point(474, 44);
            this.txtSinopse.Multiline = true;
            this.txtSinopse.Name = "txtSinopse";
            this.txtSinopse.Size = new System.Drawing.Size(194, 167);
            this.txtSinopse.TabIndex = 4;
            // 
            // txtTituloNacional
            // 
            this.txtTituloNacional.Location = new System.Drawing.Point(16, 93);
            this.txtTituloNacional.Name = "txtTituloNacional";
            this.txtTituloNacional.Size = new System.Drawing.Size(261, 20);
            this.txtTituloNacional.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Título Nacional";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sinopse";
            // 
            // btCancelar
            // 
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCancelar.Location = new System.Drawing.Point(691, 133);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 50);
            this.btCancelar.TabIndex = 11;
            this.btCancelar.Text = "&Cancelar";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btOk
            // 
            this.btOk.Image = ((System.Drawing.Image)(resources.GetObject("btOk.Image")));
            this.btOk.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btOk.Location = new System.Drawing.Point(691, 63);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 50);
            this.btOk.TabIndex = 10;
            this.btOk.Text = "&Ok";
            this.btOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // txtTituloOriginal
            // 
            this.txtTituloOriginal.Location = new System.Drawing.Point(16, 44);
            this.txtTituloOriginal.Name = "txtTituloOriginal";
            this.txtTituloOriginal.Size = new System.Drawing.Size(261, 20);
            this.txtTituloOriginal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título Original";
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
            this.dataGrid.Size = new System.Drawing.Size(790, 249);
            this.dataGrid.TabIndex = 3;
            // 
            // openFile
            // 
            this.openFile.Filter = "Imagem JPG|*.jpg";
            // 
            // formCadFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 527);
            this.ControlBox = false;
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.gbCad);
            this.Controls.Add(this.panel1);
            this.Name = "formCadFilmes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Filmes";
            this.Activated += new System.EventHandler(this.formCadFilmes_Activated);
            this.panel1.ResumeLayout(false);
            this.gbCad.ResumeLayout(false);
            this.gbCad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCartaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.GroupBox gbCad;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.TextBox txtTituloOriginal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSinopse;
        private System.Windows.Forms.TextBox txtTituloNacional;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCartaz;
        private System.Windows.Forms.PictureBox pbCartaz;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.ComboBox cbClassificacao;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.Label label4;
    }
}