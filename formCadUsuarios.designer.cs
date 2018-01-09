namespace trabFinal
{
    partial class formCadUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCadUsuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSair = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btIncluir = new System.Windows.Forms.Button();
            this.gbCad = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbNivel = new System.Windows.Forms.ComboBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.gbCad.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(378, 50);
            this.panel1.TabIndex = 1;
            // 
            // btSair
            // 
            this.btSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSair.Location = new System.Drawing.Point(303, 0);
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
            this.gbCad.Controls.Add(this.label7);
            this.gbCad.Controls.Add(this.cbNivel);
            this.gbCad.Controls.Add(this.txtSenha);
            this.gbCad.Controls.Add(this.label3);
            this.gbCad.Controls.Add(this.btCancelar);
            this.gbCad.Controls.Add(this.btOk);
            this.gbCad.Controls.Add(this.txtLogin);
            this.gbCad.Controls.Add(this.label1);
            this.gbCad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbCad.Location = new System.Drawing.Point(0, 261);
            this.gbCad.Name = "gbCad";
            this.gbCad.Size = new System.Drawing.Size(378, 177);
            this.gbCad.TabIndex = 2;
            this.gbCad.TabStop = false;
            this.gbCad.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nível";
            // 
            // cbNivel
            // 
            this.cbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Items.AddRange(new object[] {
            "Administrador de Sistema",
            "Gerente",
            "Vendedor"});
            this.cbNivel.Location = new System.Drawing.Point(22, 140);
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(203, 21);
            this.cbNivel.TabIndex = 3;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(22, 92);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(203, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha";
            // 
            // btCancelar
            // 
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCancelar.Location = new System.Drawing.Point(271, 111);
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
            this.btOk.Location = new System.Drawing.Point(271, 43);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 50);
            this.btOk.TabIndex = 10;
            this.btOk.Text = "&Ok";
            this.btOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(22, 43);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(203, 20);
            this.txtLogin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
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
            this.dataGrid.Size = new System.Drawing.Size(378, 211);
            this.dataGrid.TabIndex = 3;
            // 
            // openFile
            // 
            this.openFile.Filter = "JPG|*.jpg";
            // 
            // formCadUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 438);
            this.ControlBox = false;
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.gbCad);
            this.Controls.Add(this.panel1);
            this.Name = "formCadUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.Activated += new System.EventHandler(this.formCadUsuarios_Activated);
            this.panel1.ResumeLayout(false);
            this.gbCad.ResumeLayout(false);
            this.gbCad.PerformLayout();
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
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbNivel;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}