using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les_Tels
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void rbtnMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas();
            pnlJanelas.Controls.Add(vendas);
            vendas.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos();
            pnlJanelas.Controls.Add(produtos);
            produtos.Show();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa();
            pnlJanelas.Controls.Add(caixa);
            caixa.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            /*Pedidos vendas = new Vendas();
            pnlJanelas.Controls.Add(vendas);
            vendas.Show();*/
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            Relatorios vendas = new Relatorios();
            pnlJanelas.Controls.Add(vendas);
            vendas.Show();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            Fornecedor vendas = new Fornecedor();
            pnlJanelas.Controls.Add(vendas);
            vendas.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios vendas = new Usuarios();
            pnlJanelas.Controls.Add(vendas);
            vendas.Show();
        }
    }
}
