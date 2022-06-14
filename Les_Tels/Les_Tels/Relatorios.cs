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
    public partial class Relatorios : UserControl
    {
        public Relatorios()
        {
            InitializeComponent();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            RelatorioVendas relatorioVendas = new RelatorioVendas();
            relatorioVendas.Show();
        }

        private void btnSolicitacoes_Click(object sender, EventArgs e)
        {
            RelatorioSolicitacoes relatorioSolicitacoes = new RelatorioSolicitacoes();
            relatorioSolicitacoes.Show();
        }

        private void btnProducoes_Click(object sender, EventArgs e)
        {
            RelatorioProducoes relatorioProducoes = new RelatorioProducoes();
            relatorioProducoes.Show();
        }
    }
}
