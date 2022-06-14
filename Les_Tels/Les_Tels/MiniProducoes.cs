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
    public partial class MiniProducoes : Form
    {
        private int update;

        int codUsuario;
        public MiniProducoes()
        {
            InitializeComponent();
        }

        public MiniProducoes(int codUsuario, int codigoProduto)
        {
            InitializeComponent();
            txtCodProduto.Text = codigoProduto.ToString();
            this.codUsuario = codUsuario;
        }

        public MiniProducoes(int codUsuario, int codigoProducao, int codigoProduto)
        {
            InitializeComponent();
            producoesTableAdapter.FillByCodProducao(setConnection.producoes, codigoProducao);
            update = 1;
            this.codUsuario = codUsuario;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (update == 1)
            {
                try
                {
                    producoesTableAdapter.UpdateQuery(
                                        Convert.ToInt32(txtCodProduto.Text.ToString()),
                                        Convert.ToDateTime(dtpDataProducao.Value.ToString("dd/MM/yyyy")),
                                        Convert.ToInt32(txtQuantidade.Text.ToString()),
                                        codUsuario,
                                        Convert.ToInt32(txtCodProducao.Text.ToString())
                                        );
                    MessageBox.Show("Alterado Com sucesso");
                    Close();
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

            }
            else
            {
                try
                {
                    producoesTableAdapter.InsertQuery(
                                        Convert.ToInt32(txtCodProduto.Text.ToString()),
                                        Convert.ToDateTime(dtpDataProducao.Value.ToString("dd/MM/yyyy")),
                                        Convert.ToInt32(txtQuantidade.Text.ToString()),
                                        codUsuario
                                        );
                    MessageBox.Show("Inserido Com sucesso");
                    Close();
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
