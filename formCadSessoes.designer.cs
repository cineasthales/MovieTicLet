namespace trabFinal
{
    partial class formCadSessoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCadSessoes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSair = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btIncluir = new System.Windows.Forms.Button();
            this.gbCad = new System.Windows.Forms.GroupBox();
            this.calendarioData = new System.Windows.Forms.MonthCalendar();
            this.listFilmes = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chk3D = new System.Windows.Forms.CheckBox();
            this.chkLegendado = new System.Windows.Forms.CheckBox();
            this.txtHorario = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSala = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(833, 50);
            this.panel1.TabIndex = 1;
            // 
            // btSair
            // 
            this.btSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSair.Location = new System.Drawing.Point(758, 0);
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
            this.gbCad.Controls.Add(this.calendarioData);
            this.gbCad.Controls.Add(this.listFilmes);
            this.gbCad.Controls.Add(this.label9);
            this.gbCad.Controls.Add(this.chk3D);
            this.gbCad.Controls.Add(this.chkLegendado);
            this.gbCad.Controls.Add(this.txtHorario);
            this.gbCad.Controls.Add(this.label7);
            this.gbCad.Controls.Add(this.cbSala);
            this.gbCad.Controls.Add(this.label3);
            this.gbCad.Controls.Add(this.btCancelar);
            this.gbCad.Controls.Add(this.btOk);
            this.gbCad.Controls.Add(this.label1);
            this.gbCad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbCad.Location = new System.Drawing.Point(0, 310);
            this.gbCad.Name = "gbCad";
            this.gbCad.Size = new System.Drawing.Size(833, 217);
            this.gbCad.TabIndex = 2;
            this.gbCad.TabStop = false;
            this.gbCad.Visible = false;
            this.gbCad.Enter += new System.EventHandler(this.gbCad_Enter);
            // 
            // calendarioData
            // 
            this.calendarioData.Location = new System.Drawing.Point(429, 40);
            this.calendarioData.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.calendarioData.MaxSelectionCount = 1;
            this.calendarioData.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.calendarioData.Name = "calendarioData";
            this.calendarioData.ShowToday = false;
            this.calendarioData.ShowTodayCircle = false;
            this.calendarioData.TabIndex = 28;
            // 
            // listFilmes
            // 
            this.listFilmes.FormattingEnabled = true;
            this.listFilmes.Location = new System.Drawing.Point(12, 42);
            this.listFilmes.Name = "listFilmes";
            this.listFilmes.Size = new System.Drawing.Size(396, 160);
            this.listFilmes.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Filme";
            // 
            // chk3D
            // 
            this.chk3D.AutoSize = true;
            this.chk3D.Location = new System.Drawing.Point(749, 72);
            this.chk3D.Name = "chk3D";
            this.chk3D.Size = new System.Drawing.Size(40, 17);
            this.chk3D.TabIndex = 24;
            this.chk3D.Text = "3D";
            this.chk3D.UseVisualStyleBackColor = true;
            // 
            // chkLegendado
            // 
            this.chkLegendado.AutoSize = true;
            this.chkLegendado.Location = new System.Drawing.Point(749, 91);
            this.chkLegendado.Name = "chkLegendado";
            this.chkLegendado.Size = new System.Drawing.Size(80, 17);
            this.chkLegendado.TabIndex = 23;
            this.chkLegendado.Text = "Legendado";
            this.chkLegendado.UseVisualStyleBackColor = true;
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(668, 88);
            this.txtHorario.Mask = "00:00";
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(38, 20);
            this.txtHorario.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(665, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sala";
            // 
            // cbSala
            // 
            this.cbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Location = new System.Drawing.Point(668, 42);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(100, 21);
            this.cbSala.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data";
            // 
            // btCancelar
            // 
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCancelar.Location = new System.Drawing.Point(749, 131);
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
            this.btOk.Location = new System.Drawing.Point(668, 131);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 50);
            this.btOk.TabIndex = 10;
            this.btOk.Text = "&Ok";
            this.btOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(665, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Horário";
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
            this.dataGrid.Size = new System.Drawing.Size(833, 260);
            this.dataGrid.TabIndex = 3;
            // 
            // openFile
            // 
            this.openFile.Filter = "JPG|*.jpg";
            // 
            // formCadSessoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 527);
            this.ControlBox = false;
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.gbCad);
            this.Controls.Add(this.panel1);
            this.Name = "formCadSessoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Sessões";
            this.Activated += new System.EventHandler(this.formCadSessoes_Activated);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSala;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.MaskedTextBox txtHorario;
        private System.Windows.Forms.CheckBox chk3D;
        private System.Windows.Forms.CheckBox chkLegendado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MonthCalendar calendarioData;
        private System.Windows.Forms.ListBox listFilmes;
    }
}