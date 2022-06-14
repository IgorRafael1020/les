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
    public partial class MiniFornecedor : Form
    {
        private int codUsuario;
        private int update;
        public MiniFornecedor(int codUsuario)
        {
            InitializeComponent();
            this.codUsuario = codUsuario;
        }
        public MiniFornecedor(int codUsuario, int codigo)
        {
            InitializeComponent();
            fornecedoresTableAdapter.FillByCodFornecedor(setConnection.fornecedores, codigo);
            this.codUsuario = codUsuario;
            update = 1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (update == 1)
            {
                try
                {
                    fornecedoresTableAdapter.UpdateFornecedor(
                                            txtNomeRazao.Text.ToString(),
                                            txtNomeFantasia.Text.ToString(),
                                            txtCnpj.Text.ToString(),
                                            txtCep.Text.ToString(),
                                            txtUf.Text.ToString(),
                                            txtCidade.Text.ToString(),
                                            txtBairro.Text.ToString(),
                                            txtEndereco.Text.ToString(),
                                            Convert.ToDateTime(dtpDataCadastro.Value.ToString("dd/MM/yyyy")),
                                            codUsuario,
                                            Convert.ToInt32(txtCodFornecedor.Text.ToString())
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
                    fornecedoresTableAdapter.InsertFornecedor(
                                        txtNomeRazao.Text.ToString(),
                                        txtNomeFantasia.Text.ToString(),
                                        txtCnpj.Text.ToString(),
                                        txtCep.Text.ToString(),
                                        txtUf.Text.ToString(),
                                        txtCidade.Text.ToString(),
                                        txtBairro.Text.ToString(),
                                        txtEndereco.Text.ToString(),
                                        Convert.ToDateTime(dtpDataCadastro.Value.ToString("dd/MM/yyyy")),
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
    }
}
