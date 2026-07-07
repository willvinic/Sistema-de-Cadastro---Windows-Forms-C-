
namespace exercicio_4
{
    partial class fmrConsulta
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
            this.lblNomeB = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.clnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnVisitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblQuadrado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeB
            // 
            this.lblNomeB.AutoSize = true;
            this.lblNomeB.Location = new System.Drawing.Point(26, 28);
            this.lblNomeB.Name = "lblNomeB";
            this.lblNomeB.Size = new System.Drawing.Size(35, 13);
            this.lblNomeB.TabIndex = 0;
            this.lblNomeB.Text = "Nome";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnData,
            this.clnHora,
            this.clnVisitado,
            this.clnTipo});
            this.dgvConsulta.Location = new System.Drawing.Point(11, 79);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(453, 150);
            this.dgvConsulta.TabIndex = 1;
            // 
            // clnData
            // 
            this.clnData.HeaderText = "Data";
            this.clnData.Name = "clnData";
            // 
            // clnHora
            // 
            this.clnHora.HeaderText = "Hora";
            this.clnHora.Name = "clnHora";
            // 
            // clnVisitado
            // 
            this.clnVisitado.HeaderText = "Visitado";
            this.clnVisitado.Name = "clnVisitado";
            // 
            // clnTipo
            // 
            this.clnTipo.HeaderText = "Tipo";
            this.clnTipo.Name = "clnTipo";
            // 
            // lblQuadrado
            // 
            this.lblQuadrado.AutoSize = true;
            this.lblQuadrado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuadrado.Location = new System.Drawing.Point(67, 28);
            this.lblQuadrado.Name = "lblQuadrado";
            this.lblQuadrado.Size = new System.Drawing.Size(171, 15);
            this.lblQuadrado.TabIndex = 2;
            this.lblQuadrado.Text = "                                                      ";
            this.lblQuadrado.Click += new System.EventHandler(this.lblQuadrado_Click);
            // 
            // fmrConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 250);
            this.Controls.Add(this.lblQuadrado);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.lblNomeB);
            this.Name = "fmrConsulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.fmrConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblNomeB;
        public System.Windows.Forms.DataGridView dgvConsulta;
        public System.Windows.Forms.Label lblQuadrado;
        public System.Windows.Forms.DataGridViewTextBoxColumn clnData;
        public System.Windows.Forms.DataGridViewTextBoxColumn clnHora;
        public System.Windows.Forms.DataGridViewTextBoxColumn clnVisitado;
        public System.Windows.Forms.DataGridViewTextBoxColumn clnTipo;
    }
}