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
    public partial class Fornecedor : UserControl
    {
        private int codUsuario;
        public Fornecedor(int codUsuario)
        {
            InitializeComponent();
            fornecedoresTableAdapter.Fill(setConnection.fornecedores);
            this.codUsuario = codUsuario;
        }

        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            MiniFornecedor miniproduto = new MiniFornecedor(codUsuario);
            miniproduto.Show();
        }

        private void btnEditarFornecedor_Click(object sender, EventArgs e)
        {
            MiniFornecedor miniproduto = new MiniFornecedor(Convert.ToInt32(dgvFornecedor.Rows[dgvFornecedor.CurrentCell.RowIndex].Cells[0].Value.ToString()));
            miniproduto.Show();
        }

        private void btnExcluirFornecedor_Click(object sender, EventArgs e)
        {
            if (dgvFornecedor.CurrentCell.RowIndex > -1)
                if (MessageBox.Show("TEM CERTEZA QUE DESEJA DELETAR ESSE FORNECEDOR?", "PERIGO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        fornecedoresTableAdapter.DeletarFornecedor(Convert.ToInt32(dgvFornecedor.Rows[dgvFornecedor.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                        fornecedoresTableAdapter.Fill(setConnection.fornecedores);
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
        }

        private void fornecedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornecedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.setConnection);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            fornecedoresTableAdapter.FillByNomeFantasia(setConnection.fornecedores, '%'+ txtFornecedor.Text.ToUpper() +'%');
            txtFornecedor.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            fornecedoresTableAdapter.Fill(setConnection.fornecedores);
        }
    }
}
