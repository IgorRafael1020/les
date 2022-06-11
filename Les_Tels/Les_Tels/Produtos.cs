using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les_Tels
{
    public partial class Produtos : UserControl
    {
        public Produtos()
        {
            InitializeComponent();
            try
            {
                this.produtosTableAdapter.Fill(this.setConnection.produtos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillByNadaToolStripButton_Click(object sender, EventArgs e)
        {
            

        }
        public Produtos(string sim)
        {
            this.produtosTableAdapter.Fill(this.setConnection.produtos);
        }
            private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.CurrentCell.RowIndex > 0)
                if (MessageBox.Show("TEM CERTEZA QUE DESEJA DELETAR ESSE PRODUTO?", "PERIGO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        this.produtosTableAdapter.DeletaProduto(Convert.ToInt32(dgvProdutos.Rows[dgvProdutos.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                        this.produtosTableAdapter.Fill(this.setConnection.produtos);
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
            }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            Novo_Produto miniproduto = new Novo_Produto();
            miniproduto.Show();
        }

        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            Novo_Produto miniproduto = new Novo_Produto(Convert.ToInt32(dgvProdutos.Rows[dgvProdutos.CurrentCell.RowIndex].Cells[0].Value.ToString()));
            miniproduto.Show();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {

        }
    }
}
