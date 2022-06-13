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
        public int update = 0;
        public MiniProduto()
        {
            InitializeComponent();
        }
        //public void Novo_Produto_Adicionar(string descricao,double preco,string unidade, double quantidade,double estoqueminimo,DateTime validade)
        public  MiniProduto(int codigo)
        {
            InitializeComponent();
            this.produtosTableAdapter.FillByCodigo(this.setConnection.produtos, codigo);
            update = 1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void producoesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.producoesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.setConnection);

        }

        private void Novo_Produto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'setConnection.produtos'. Você pode movê-la ou removê-la conforme necessário.
            //
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (update == 1)
            {
                try
                {
                    this.produtosTableAdapter.UpdateProdutos(txtdescricao.Text.ToString(),
                                        Convert.ToDouble(txtpreco.Text.ToString()),
                                        txtunidade.Text.ToString(),
                                        Convert.ToInt32(txtquantidade.Text.ToString()),
                                        Convert.ToInt32(txtestoqueMinimo.Text.ToString()),
                                        null,
                                        //Convert.ToDateTime(dtpdataValidade.Text.ToString()),
                                        Convert.ToInt32(txtcodTipo.Text.ToString()),
                                        //Convert.ToInt32(txtcodUsuario.Text.ToString()),
                                        1,
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
                    this.produtosTableAdapter.InsertProdutos(txtdescricao.Text.ToString(),
                                        Convert.ToDouble(txtpreco.Text.ToString()),
                                        txtunidade.Text.ToString(),
                                        Convert.ToInt32(txtquantidade.Text.ToString()),
                                        Convert.ToInt32(txtestoqueMinimo.Text.ToString()),
                                        null,
                                        //Convert.ToDateTime(dtpdataValidade.Text.ToString()),
                                        Convert.ToInt32(txtcodTipo.Text.ToString()),
                                        //Convert.ToInt32(txtcodUsuario.Text.ToString()),
                                        1
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
    }
}
