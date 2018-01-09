namespace trabFinal
{
    partial class formPesqFilmes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPesqFilmes));
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.gbCad = new System.Windows.Forms.GroupBox();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbClassificacao = new System.Windows.Forms.ComboBox();
            this.pbCartaz = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSinopse = new System.Windows.Forms.TextBox();
            this.txtTituloNacional = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.txtTituloOriginal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btDetalhes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.txtFiltroTituloNac = new System.Windows.Forms.TextBox();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbFiltroGenero = new System.Windows.Forms.ComboBox();
            this.btSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.gbCad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCartaz)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.dataGrid.Size = new System.Drawing.Size(741, 251);
            this.dataGrid.TabIndex = 6;
            // 
            // gbCad
            // 
            this.gbCad.Controls.Add(this.txtDuracao);
            this.gbCad.Controls.Add(this.label4);
            this.gbCad.Controls.Add(this.cbClassificacao);
            this.gbCad.Controls.Add(this.pbCartaz);
            this.gbCad.Controls.Add(this.panel2);
            this.gbCad.Controls.Add(this.label7);
            this.gbCad.Controls.Add(this.cbGenero);
            this.gbCad.Controls.Add(this.label6);
            this.gbCad.Controls.Add(this.txtSinopse);
            this.gbCad.Controls.Add(this.txtTituloNacional);
            this.gbCad.Controls.Add(this.label3);
            this.gbCad.Controls.Add(this.label2);
            this.gbCad.Controls.Add(this.btOk);
            this.gbCad.Controls.Add(this.txtTituloOriginal);
            this.gbCad.Controls.Add(this.label1);
            this.gbCad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbCad.Location = new System.Drawing.Point(0, 301);
            this.gbCad.Name = "gbCad";
            this.gbCad.Size = new System.Drawing.Size(741, 226);
            this.gbCad.TabIndex = 5;
            this.gbCad.TabStop = false;
            this.gbCad.Visible = false;
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(207, 141);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(70, 20);
            this.txtDuracao.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Duração (min)";
            // 
            // cbClassificacao
            // 
            this.cbClassificacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClassificacao.FormattingEnabled = true;
            this.cbClassificacao.Items.AddRange(new object[] {
            "Livre",
            "10",
            "12",
            "14",
            "16",
            "18"});
            this.cbClassificacao.Location = new System.Drawing.Point(16, 190);
            this.cbClassificacao.Name = "cbClassificacao";
            this.cbClassificacao.Size = new System.Drawing.Size(115, 21);
            this.cbClassificacao.TabIndex = 38;
            // 
            // pbCartaz
            // 
            this.pbCartaz.Location = new System.Drawing.Point(304, 19);
            this.pbCartaz.Name = "pbCartaz";
            this.pbCartaz.Size = new System.Drawing.Size(136, 188);
            this.pbCartaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCartaz.TabIndex = 36;
            this.pbCartaz.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(308, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 192);
            this.panel2.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 35;
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
            this.cbGenero.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Classificação Indicativa";
            // 
            // txtSinopse
            // 
            this.txtSinopse.Location = new System.Drawing.Point(471, 44);
            this.txtSinopse.Multiline = true;
            this.txtSinopse.Name = "txtSinopse";
            this.txtSinopse.Size = new System.Drawing.Size(258, 114);
            this.txtSinopse.TabIndex = 29;
            // 
            // txtTituloNacional
            // 
            this.txtTituloNacional.Location = new System.Drawing.Point(16, 93);
            this.txtTituloNacional.Name = "txtTituloNacional";
            this.txtTituloNacional.Size = new System.Drawing.Size(261, 20);
            this.txtTituloNacional.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Título Nacional";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Sinopse";
            // 
            // btOk
            // 
            this.btOk.Image = ((System.Drawing.Image)(resources.GetObject("btOk.Image")));
            this.btOk.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btOk.Location = new System.Drawing.Point(658, 164);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(71, 50);
            this.btOk.TabIndex = 32;
            this.btOk.Text = "&Ok";
            this.btOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click_1);
            // 
            // txtTituloOriginal
            // 
            this.txtTituloOriginal.Location = new System.Drawing.Point(16, 44);
            this.txtTituloOriginal.Name = "txtTituloOriginal";
            this.txtTituloOriginal.Size = new System.Drawing.Size(261, 20);
            this.txtTituloOriginal.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Título Original";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btDetalhes);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btSair);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 50);
            this.panel1.TabIndex = 4;
            // 
            // btDetalhes
            // 
            this.btDetalhes.Dock = System.Windows.Forms.DockStyle.Left;
            this.btDetalhes.Image = ((System.Drawing.Image)(resources.GetObject("btDetalhes.Image")));
            this.btDetalhes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btDetalhes.Location = new System.Drawing.Point(562, 0);
            this.btDetalhes.Name = "btDetalhes";
            this.btDetalhes.Size = new System.Drawing.Size(71, 50);
            this.btDetalhes.TabIndex = 7;
            this.btDetalhes.Text = "&Detalhar";
            this.btDetalhes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btDetalhes.UseVisualStyleBackColor = true;
            this.btDetalhes.Click += new System.EventHandler(this.btDetalhes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btLimpar);
            this.groupBox2.Controls.Add(this.txtFiltroTituloNac);
            this.groupBox2.Controls.Add(this.btFiltrar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(198, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 50);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro por Título Nacional";
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(287, 12);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(67, 30);
            this.btLimpar.TabIndex = 2;
            this.btLimpar.Text = "&Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // txtFiltroTituloNac
            // 
            this.txtFiltroTituloNac.Location = new System.Drawing.Point(16, 19);
            this.txtFiltroTituloNac.Name = "txtFiltroTituloNac";
            this.txtFiltroTituloNac.Size = new System.Drawing.Size(185, 20);
            this.txtFiltroTituloNac.TabIndex = 1;
            // 
            // btFiltrar
            // 
            this.btFiltrar.Location = new System.Drawing.Point(214, 12);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(67, 30);
            this.btFiltrar.TabIndex = 0;
            this.btFiltrar.Text = "&Filtrar";
            this.btFiltrar.UseVisualStyleBackColor = true;
            this.btFiltrar.Click += new System.EventHandler(this.btFiltrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbFiltroGenero);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 50);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro por Gênero";
            // 
            // cbFiltroGenero
            // 
            this.cbFiltroGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroGenero.FormattingEnabled = true;
            this.cbFiltroGenero.Items.AddRange(new object[] {
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
            "Terror",
            "TODOS"});
            this.cbFiltroGenero.Location = new System.Drawing.Point(12, 19);
            this.cbFiltroGenero.Name = "cbFiltroGenero";
            this.cbFiltroGenero.Size = new System.Drawing.Size(172, 21);
            this.cbFiltroGenero.TabIndex = 0;
            // 
            // btSair
            // 
            this.btSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSair.Location = new System.Drawing.Point(670, 0);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(71, 50);
            this.btSair.TabIndex = 3;
            this.btSair.Text = "&Sair";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // formPesqFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 527);
            this.ControlBox = false;
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.gbCad);
            this.Controls.Add(this.panel1);
            this.Name = "formPesqFilmes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Filmes";
            this.Activated += new System.EventHandler(this.formPesqFilmes_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.gbCad.ResumeLayout(false);
            this.gbCad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCartaz)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.GroupBox gbCad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btDetalhes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFiltroTituloNac;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbClassificacao;
        private System.Windows.Forms.PictureBox pbCartaz;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSinopse;
        private System.Windows.Forms.TextBox txtTituloNacional;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.TextBox txtTituloOriginal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFiltroGenero;
    }
}