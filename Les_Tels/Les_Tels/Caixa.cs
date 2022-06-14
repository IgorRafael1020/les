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
    public partial class Caixa : UserControl
    {
        private int codVenda;
        private int editar;
        private int codUsuario;
        public Caixa(int codUsuario)
        {
            InitializeComponent();
            this.codUsuario = codUsuario;
        }

        private void btnAbrirVenda_Click(object sender, EventArgs e)
        {
            //vendasTableAdapter.Insert();
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnFecharVenda.Enabled = true;
            btnSalvar.Enabled = true;

            txtCodProduto.Enabled = true;
            txtQuantidade.Enabled = true;

            dgvItensVenda.Enabled = true;

            String data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            vendasTableAdapter.InsertQuery(
                                data, 
                                codUsuario
                            );
            itensVendaTableAdapter.FillByDataCod(setConnection.itensVenda, data, codUsuario);
            codVenda = Convert.ToInt32(vendasTableAdapter.ScalarQueryDataCod(data, codUsuario));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtCodProduto.Enabled = false;
            txtCodProduto.Text = dgvItensVenda.Rows[dgvItensVenda.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtQuantidade.Text = dgvItensVenda.Rows[dgvItensVenda.CurrentCell.RowIndex].Cells[2].Value.ToString();
            editar = 1;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("TEM CERTEZA QUE DESEJA DELETAR ESSE PRODUTO?", "PERIGO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                itensVendaTableAdapter.DeleteQuery(codVenda, Convert.ToInt32(dgvItensVenda.Rows[dgvItensVenda.CurrentCell.RowIndex].Cells[1].Value));
            }
        }

        private void btnFecharVenda_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnFecharVenda.Enabled = false;
            btnSalvar.Enabled = false;

            txtCodProduto.Enabled = false;
            txtQuantidade.Enabled = false;

            dgvItensVenda.Enabled = false;

            txtCodProduto.Text = "";
            txtQuantidade.Text = "";

            itensVendaTableAdapter.FillBy(setConnection.itensVenda, 0);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(editar == 1)
            {
                itensVendaTableAdapter.UpdateQuery(Convert.ToInt32(txtQuantidade.Text), codVenda, Convert.ToInt32(txtCodProduto.Text));

                txtCodProduto.Text = "";
                txtQuantidade.Text = "";

                txtCodProduto.Enabled = true;

                editar = 0;
            }
            else
            {
                itensVendaTableAdapter.InsertQuery(codVenda, Convert.ToInt32(txtCodProduto.Text), Convert.ToInt32(txtQuantidade.Text));

                txtCodProduto.Text = "";
                txtQuantidade.Text = "";
            }
        }
    }
}
