
namespace exercicio_4
{
    partial class fmrEX4
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrEX4));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNovo = new System.Windows.Forms.ToolStripButton();
            this.tsbAnular = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAtualizar = new System.Windows.Forms.ToolStripButton();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cboDocumento = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.dpdData = new System.Windows.Forms.DateTimePicker();
            this.mtxHora = new System.Windows.Forms.MaskedTextBox();
            this.dgvGrelha = new System.Windows.Forms.DataGridView();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrelha)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNovo,
            this.tsbAnular,
            this.tsbGuardar,
            this.toolStripSeparator1,
            this.tsbConsultar,
            this.toolStripSeparator2,
            this.tsbAtualizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(369, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNovo
            // 
            this.tsbNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNovo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNovo.Image")));
            this.tsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovo.Name = "tsbNovo";
            this.tsbNovo.Size = new System.Drawing.Size(23, 22);
            this.tsbNovo.Text = "Novo";
            this.tsbNovo.Click += new System.EventHandler(this.tsbNovo_Click);
            // 
            // tsbAnular
            // 
            this.tsbAnular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAnular.Image = ((System.Drawing.Image)(resources.GetObject("tsbAnular.Image")));
            this.tsbAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAnular.Name = "tsbAnular";
            this.tsbAnular.Size = new System.Drawing.Size(23, 22);
            this.tsbAnular.Text = "Anular";
            this.tsbAnular.Click += new System.EventHandler(this.tsbAnular_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(23, 22);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbConsultar
            // 
            this.tsbConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbConsultar.Image = ((System.Drawing.Image)(resources.GetObject("tsbConsultar.Image")));
            this.tsbConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConsultar.Name = "tsbConsultar";
            this.tsbConsultar.Size = new System.Drawing.Size(23, 22);
            this.tsbConsultar.Text = "Consultar";
            this.tsbConsultar.Click += new System.EventHandler(this.tsbConsultar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAtualizar
            // 
            this.tsbAtualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("tsbAtualizar.Image")));
            this.tsbAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAtualizar.Name = "tsbAtualizar";
            this.tsbAtualizar.Size = new System.Drawing.Size(23, 22);
            this.tsbAtualizar.Text = "Atualizar";
            this.tsbAtualizar.Click += new System.EventHandler(this.tsbAtualizar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 63);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(12, 98);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(62, 13);
            this.lblDocumento.TabIndex = 2;
            this.lblDocumento.Text = "Documento";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(207, 101);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Numero";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(12, 144);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(12, 195);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(264, 195);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 6;
            this.lblHora.Text = "Hora";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(53, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(304, 20);
            this.txtNome.TabIndex = 7;
            // 
            // cboDocumento
            // 
            this.cboDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocumento.FormattingEnabled = true;
            this.cboDocumento.Items.AddRange(new object[] {
            "Passaporte",
            "Residencia"});
            this.cboDocumento.Location = new System.Drawing.Point(80, 95);
            this.cboDocumento.Name = "cboDocumento";
            this.cboDocumento.Size = new System.Drawing.Size(121, 21);
            this.cboDocumento.TabIndex = 8;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(257, 98);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 9;
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(53, 141);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(159, 21);
            this.cboTipo.TabIndex = 10;
            // 
            // dpdData
            // 
            this.dpdData.Location = new System.Drawing.Point(48, 192);
            this.dpdData.Name = "dpdData";
            this.dpdData.Size = new System.Drawing.Size(159, 20);
            this.dpdData.TabIndex = 11;
            // 
            // mtxHora
            // 
            this.mtxHora.Location = new System.Drawing.Point(310, 188);
            this.mtxHora.Mask = "00:00";
            this.mtxHora.Name = "mtxHora";
            this.mtxHora.Size = new System.Drawing.Size(47, 20);
            this.mtxHora.TabIndex = 12;
            this.mtxHora.ValidatingType = typeof(System.DateTime);
            this.mtxHora.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // dgvGrelha
            // 
            this.dgvGrelha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrelha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnNome,
            this.clnHora});
            this.dgvGrelha.Location = new System.Drawing.Point(12, 261);
            this.dgvGrelha.Name = "dgvGrelha";
            this.dgvGrelha.Size = new System.Drawing.Size(345, 150);
            this.dgvGrelha.TabIndex = 13;
            // 
            // clnNome
            // 
            this.clnNome.HeaderText = "Nome";
            this.clnNome.Name = "clnNome";
            this.clnNome.Width = 210;
            // 
            // clnHora
            // 
            this.clnHora.HeaderText = "Hora";
            this.clnHora.Name = "clnHora";
            this.clnHora.Width = 70;
            // 
            // fmrEX4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 423);
            this.Controls.Add(this.dgvGrelha);
            this.Controls.Add(this.mtxHora);
            this.Controls.Add(this.dpdData);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.cboDocumento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.toolStrip1);
            this.Name = "fmrEX4";
            this.Text = "Exercicio 4";
            this.Load += new System.EventHandler(this.fmrEX4_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrelha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNovo;
        private System.Windows.Forms.ToolStripButton tsbAnular;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbConsultar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbAtualizar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cboDocumento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.DateTimePicker dpdData;
        private System.Windows.Forms.MaskedTextBox mtxHora;
        private System.Windows.Forms.DataGridView dgvGrelha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnHora;
    }
}

