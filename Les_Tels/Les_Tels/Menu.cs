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
        int codUsuario;
        public Menu()
        {
            InitializeComponent();
        }

        public Menu(int codUsuario)
        {
            InitializeComponent();
            this.codUsuario = codUsuario;
        }

        private void rbtnMenu_Click(object sender, EventArgs e)
        {
            pnlJanelas.Controls.Clear();
            limparBotoes();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            pnlJanelas.Controls.Clear();
            Vendas vendas = new Vendas();
            pnlJanelas.Controls.Add(vendas);
            limparBotoes();
            btnVendas.BackgroundImage = Les_Tels.Properties.Resources.Vendas_Amarelo_Preto;
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            pnlJanelas.Controls.Clear();
            Produtos produtos = new Produtos(codUsuario);
            pnlJanelas.Controls.Add(produtos);
            limparBotoes();
            btnProdutos.BackgroundImage = Les_Tels.Properties.Resources.Produtos_Amarelo_Preto;
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            pnlJanelas.Controls.Clear();
            Caixa caixa = new Caixa();
            pnlJanelas.Controls.Add(caixa);
            limparBotoes();
            btnCaixa.BackgroundImage = Les_Tels.Properties.Resources.Caixa_Amarelo_Preto;
        }

        private void btnSolicitacoes_Click(object sender, EventArgs e)
        {
            pnlJanelas.Controls.Clear();
            Solicitacoes solicitacoes = new Solicitacoes();
            pnlJanelas.Controls.Add(solicitacoes);
            limparBotoes();
            btnSolicitacoes.BackgroundImage = Les_Tels.Properties.Resources.Solicitações_Amarelo_Preto;
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            pnlJanelas.Controls.Clear();
            Relatorios vendas = new Relatorios();
            pnlJanelas.Controls.Add(vendas);
            limparBotoes();
            btnRelatorios.BackgroundImage = Les_Tels.Properties.Resources.Relatório_Amarelo_Preto;
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            pnlJanelas.Controls.Clear();
            Fornecedor vendas = new Fornecedor(codUsuario);
            pnlJanelas.Controls.Add(vendas);
            limparBotoes();
            btnFornecedores.BackgroundImage = Les_Tels.Properties.Resources.Fornecedor_Amarelo_Preto;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            pnlJanelas.Controls.Clear();
            Usuarios vendas = new Usuarios();
            pnlJanelas.Controls.Add(vendas);
            limparBotoes();
            btnUsuarios.BackgroundImage = Les_Tels.Properties.Resources.Usuários_Amarelo_Preto;
        }

        private void limparBotoes()
        {
            btnVendas.BackgroundImage = Les_Tels.Properties.Resources.Vendas_Cinza_Preto;
            btnProdutos.BackgroundImage = Les_Tels.Properties.Resources.Produtos_Cinza_Preto;
            btnCaixa.BackgroundImage = Les_Tels.Properties.Resources.Caixa_Cinza_Preto;
            btnSolicitacoes.BackgroundImage = Les_Tels.Properties.Resources.Solicitações_Cinza_Preto;
            btnRelatorios.BackgroundImage = Les_Tels.Properties.Resources.Relatório_Cinza_Preto;
            btnFornecedores.BackgroundImage = Les_Tels.Properties.Resources.Fornecedor_Cinza_Preto;
            btnUsuarios.BackgroundImage = Les_Tels.Properties.Resources.Usuários_Cinza_Preto;
        }
    }
}
