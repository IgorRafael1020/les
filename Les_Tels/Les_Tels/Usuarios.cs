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
            usuariosTableAdapter.Fill(setConnection.usuarios);
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            usuariosBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(setConnection);

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
                        usuariosTableAdapter.DeleteQuery(Convert.ToInt32(dgvUsuarios.Rows[dgvUsuarios.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                        usuariosTableAdapter.Fill(setConnection.usuarios);
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            usuariosTableAdapter.FillByNomeUsuario(setConnection.usuarios, '%'+txtUsuario.Text.ToUpper()+'%');
            txtUsuario.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            usuariosTableAdapter.Fill(setConnection.usuarios);
        }
    }
}
