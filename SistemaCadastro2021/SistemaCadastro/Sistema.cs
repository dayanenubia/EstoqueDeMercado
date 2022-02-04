using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SistemaCadastro
{
    public partial class Sistema : Form
    {
        int idAlterar;
        public Sistema()
        {
            InitializeComponent();
            
        }
        
       
        private void btnCadastra_Click(object sender, EventArgs e)
        {
            marcador.Height = btnCadastraProduto.Height;
            marcador.Top = btnCadastraProduto.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[0];
        }
        

        private void btnBusca_Click(object sender, EventArgs e)
        {
            marcador.Height = btnBuscaProduto.Height;
            marcador.Top = btnBuscaProduto.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }


        void listaDGProdutos()
        {
            ConectaBanco con = new ConectaBanco();
            dgProdutos.DataSource = con.listaProdutos();
            lblMensagem.Text = con.mensagem;
        }


        private void Sistema_Load(object sender, EventArgs e)
        {
            listaDGProdutos();
        }

        void limpaCampos()
        {
            txtnome.Clear();
            txtquantEstoque.Clear();
            txtmarca.Clear();
            txtsecao.Clear();
        }


        private void BtnConfirmaCadastro_Click_1(object sender, EventArgs e)
        {
            Produto b = new Produto();
            b.Nome = txtnome.Text;
            b.QuantEstoque = txtquantEstoque.Text;
            b.Marca = txtmarca.Text;
            b.Secao = txtsecao.Text;
            ConectaBanco con = new ConectaBanco();
            bool r = con.insereProduto(b);
            if (r == true)
            {
                MessageBox.Show("Dados inseridos com sucesso:)!");
                listaDGProdutos();
                limpaCampos();
                txtnome.Focus();
            }
            else
                MessageBox.Show(con.mensagem);
        }

        private void dgBandas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dgProdutos.DataSource as DataTable).DefaultView.RowFilter = string.Format("nome like '{0}%'", textBusca.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            (dgProdutos.DataSource as DataTable).DefaultView.RowFilter = string.Format("secao like '{0}%'", textbuscas.Text);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            (dgProdutos.DataSource as DataTable).DefaultView.RowFilter = string.Format("marca like '{0}%'", textbuscam.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int linha = dgProdutos.CurrentRow.Index;
            int id = Convert.ToInt32(dgProdutos.Rows[linha].Cells["codP"].Value.ToString());
            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir?", "Remove Produto", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                ConectaBanco con = new ConectaBanco();
                bool retorno = con.deletaProduto(id);
                if (retorno == true)
                {
                    MessageBox.Show("Produto excluida com sucesso!");
                    listaDGProdutos();
                }// fim if retorno true
                else
                    MessageBox.Show(con.mensagem);
            }// fim if Ok Cancela
            else
                MessageBox.Show("Exclusão cancelada");
        }

        private void tabAterar_Click(object sender, EventArgs e)
        {

        }

        private void tabBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int linha = dgProdutos.CurrentRow.Index;
            idAlterar = Convert.ToInt32(dgProdutos.Rows[linha].Cells["codP"].Value.ToString());
            textAlteraNome.Text = dgProdutos.Rows[linha].Cells["nome"].Value.ToString();
            textAlteraQuant.Text = dgProdutos.Rows[linha].Cells["quantEstoque"].Value.ToString();
            textAlteraMarca.Text = dgProdutos.Rows[linha].Cells["marca"].Value.ToString();
            textAlteraSecao.Text = dgProdutos.Rows[linha].Cells["secao"].Value.ToString();
            tabControl1.SelectedTab = tabAlterar;
        }

        private void btnConfirmaAlteracao_Click(object sender, EventArgs e)
        {
            Produto b = new Produto();
            b.Nome = textAlteraNome.Text;
            b.QuantEstoque= textAlteraQuant.Text;
            b.Marca = textAlteraMarca.Text;
            b.Secao = textAlteraSecao.Text;
            ConectaBanco con = new ConectaBanco();
            bool ret = con.alteraProduto(b, idAlterar);
            if (ret == true)
            {
                MessageBox.Show("Produto alterado com sucesso!");
                listaDGProdutos();
                tabControl1.SelectedTab = tabBuscar;
            }// fim if true
            else
                MessageBox.Show(con.mensagem);
        }

        private void btnFecharS_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
