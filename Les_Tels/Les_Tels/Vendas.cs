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
    public partial class Vendas : UserControl
    {
        public Vendas()
        {
            InitializeComponent();
            try
            {
                vendasTableAdapter.Fill(this.setConnection.vendas);
            }
            catch (Exception)
            {
            }
            
        }

        private void dgvVendas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if(dgvVendas.RowCount > 0)
                {
                    itensVendaTableAdapter.Fill(setConnection.itensVenda, Convert.ToInt32(dgvVendas.Rows[dgvVendas.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                    txtTotalVenda.Text = itensVendaTableAdapter.ScalarQueryTotalVenda(Convert.ToInt32(dgvVendas.Rows[dgvVendas.CurrentCell.RowIndex].Cells[0].Value.ToString())).ToString();
                }
            }
            catch (Exception)
            {
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                vendasTableAdapter.FillByData(setConnection.vendas, dtpInicio.Value.ToString(), dtpFim.Value.ToString());
                if (dgvVendas.RowCount < 1)
                {
                    itensVendaTableAdapter.Fill(setConnection.itensVenda, -1);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            vendasTableAdapter.Fill(setConnection.vendas);
        }
    }
}
