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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void rbtnLogan_Click(object sender, EventArgs e)
        {
            if (usuariosTableAdapter.ScalarQueryExiste(txtLogin.Text, txtSenha.Text) == 1)
            {
                Menu menu = new Menu(Convert.ToInt32(usuariosTableAdapter.ScalarQueryObterCod(txtLogin.Text, txtSenha.Text)));
                Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Combinação de Login e Senha está incorreta");
            }
        }
    }
}
