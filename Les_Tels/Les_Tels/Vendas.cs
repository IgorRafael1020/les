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
                this.vendasTableAdapter.Fill(this.setConnection.vendas);
            }
            catch (Exception)
            {
            }
            
        }

        private void dgvVendas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                this.itensVendaTableAdapter.Fill(this.setConnection.itensVenda, Convert.ToInt32(dgvVendas.Rows[dgvVendas.CurrentCell.RowIndex].Cells[0].Value.ToString()));
            }
            catch (Exception)
            {
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
