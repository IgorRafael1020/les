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
    public partial class MiniUsuarios : Form
    {
        int update;
        public MiniUsuarios()
        {
            InitializeComponent();
        }
        public MiniUsuarios(int codigo)
        {
            InitializeComponent();
            this.usuariosTableAdapter.FillByCodigo(this.setConnection.usuarios,codigo);
            update = 1;
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.setConnection);

        }

        private void MiniUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'setConnection.usuarios'. Você pode movê-la ou removê-la conforme necessário.
            

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (update == 1)
            {
                try
                {
                    this.usuariosTableAdapter.UpdateQuery("",
                                        txtLogin.Text.ToString(),
                                        txtSenha.Text.ToString(),
                                        Convert.ToInt32(txtNivel.Text.ToString()),
                                        Convert.ToInt32(txtCodUsuario.Text.ToString())
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
                    this.usuariosTableAdapter.InsertQuery("",
                                        txtLogin.Text.ToString(),
                                        txtSenha.Text.ToString(),
                                        Convert.ToInt32(txtNivel.Text.ToString())
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
            this.Close();
        }
    }
}
