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
    public partial class MiniProduto : Form
    {
        public int codUsuario;
        public int update = 0;
        public MiniProduto(int codUsuario)
        {
            InitializeComponent();
            this.codUsuario = codUsuario;
        }
        //public void Novo_Produto_Adicionar(string descricao,double preco,string unidade, double quantidade,double estoqueminimo,DateTime validade)
        public  MiniProduto(int codUsuario, int codigo)
        {
            InitializeComponent();
            produtosTableAdapter.FillByCodigo(this.setConnection.produtos, codigo);
            update = 1;
            this.codUsuario = codUsuario;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (update == 1)
            {
                try
                {
                    this.produtosTableAdapter.UpdateProdutos(
                                        txtdescricao.Text.ToString(),
                                        Convert.ToDouble(txtpreco.Text.ToString()),
                                        txtunidade.Text.ToString(),
                                        Convert.ToInt32(txtquantidade.Text.ToString()),
                                        Convert.ToInt32(txtestoqueMinimo.Text.ToString()),
                                        Convert.ToDateTime(dtpdataValidade.Value.ToString("dd/MM/yyyy")),
                                        Convert.ToInt32(txtcodTipo.Text.ToString()),
                                        codUsuario,
                                        Convert.ToInt32(txtcodProduto.Text.ToString())
                                        );
                    MessageBox.Show("Alterado Com sucesso");
                    this.Close();
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
                    this.produtosTableAdapter.InsertProdutos(
                                        txtdescricao.Text.ToString(),
                                        Convert.ToDouble(txtpreco.Text.ToString()),
                                        txtunidade.Text.ToString(),
                                        Convert.ToInt32(txtquantidade.Text.ToString()),
                                        Convert.ToInt32(txtestoqueMinimo.Text.ToString()),
                                        Convert.ToDateTime(dtpdataValidade.Value.ToString("dd/MM/yyyy")),
                                        Convert.ToInt32(txtcodTipo.Text.ToString()),
                                        codUsuario
                                        );
                    MessageBox.Show("Inserido Com sucesso");
                    this.Close();
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
