using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_4
{
    public partial class fmrEX4 : Form
    {
        public fmrEX4()
        {
            InitializeComponent();
        }
        struct info 
        {
            public string Nome, Documento, Tipo;
            public string Numero;
            public string Data, Hora;
        }
        fmrConsulta formulario = new fmrConsulta();
        //Declaração da variável global do tipo estrutura de dados
        info Visitas;
        /*Definição da instância das classe LinkedList do tipo estrutura de dados*/
        LinkedList<info> Lista = new LinkedList<info>();
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void fmrEX4_Load(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Visitas.Documento = cboDocumento.Text;
            Visitas.Nome = txtNome.Text;
            Visitas.Tipo = cboTipo.Text;
            Visitas.Data = dpdData.Text;
            Visitas.Numero = txtNumero.Text;
            Visitas.Hora = mtxHora.Text;

        }

        private void tsbAtualizar_Click(object sender, EventArgs e)
        {
            dgvGrelha.Rows.Add(Visitas.Nome, Visitas.Hora);
            formulario.dgvConsulta.Rows.Add(Visitas.Data, Visitas.Hora, "sim", Visitas.Tipo);

            txtNome.Text = " ";
            txtNumero.Text = " ";
            dpdData.Text = "";
            cboDocumento.Text = "";
            cboTipo.Text = "";
            mtxHora.Text = "";


        }

        private void tsbConsultar_Click(object sender, EventArgs e)
        {
            formulario.Show();
            
            txtNome.Text = " ";
            txtNumero.Text = " ";
            dpdData.Text = "";
            cboDocumento.Text = "";
            cboTipo.Text = "";
            mtxHora.Text = "";
        }

        private void tsbAnular_Click(object sender, EventArgs e)
        {
            txtNome.Text = " ";
            txtNumero.Text = " ";
            dpdData.Text = "";
            cboDocumento.Text = "";
            cboTipo.Text = "";
            mtxHora.Text = "";
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            txtNome.Text = " ";
            txtNumero.Text = " ";
            dpdData.Text = "";
            cboDocumento.Text = "";
            cboTipo.Text = "";
            mtxHora.Text = "";
        }
    }
}
