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
    public partial class Solicitacoes : UserControl
    {
        public Solicitacoes()
        {
            InitializeComponent();
            solicitacoesTableAdapter.Fill(setConnection.solicitacoes);
            itensSolicitacaoTableAdapter.Fill(setConnection.itensSolicitacao);
        }

    }
}
