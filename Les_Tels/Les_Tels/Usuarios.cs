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
    public partial class Usuarios : UserControl
    {
        public Usuarios()
        {
            InitializeComponent();
            this.usuariosTableAdapter.Fill(this.setConnection.usuarios);
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.setConnection);

        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            MiniUsuarios miniUsuarios = new MiniUsuarios(Convert.ToInt32(dgvUsuarios.Rows[dgvUsuarios.CurrentCell.RowIndex].Cells[0].Value.ToString()));
            miniUsuarios.Show();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            MiniUsuarios miniUsuarios = new MiniUsuarios();
            miniUsuarios.Show();
        }

        private void btnDeletarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentCell.RowIndex > 0)
                if (MessageBox.Show("TEM CERTEZA QUE DESEJA DELETAR ESSE PRODUTO?", "PERIGO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        this.usuariosTableAdapter.DeletarUsuario(Convert.ToInt32(dgvUsuarios.Rows[dgvUsuarios.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                        this.usuariosTableAdapter.Fill(this.setConnection.usuarios);
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
            
        }
    }
}
