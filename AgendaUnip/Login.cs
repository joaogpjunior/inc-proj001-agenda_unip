using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaUnip
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
            pnl_login.Visible = false;
        }

        #region EVENTOS
        private void frm_login_Load(object sender, EventArgs e)
        {
            pnl_login.Location = new Point(this.Width / 2 - 160, this.Height / 2 - 190);
            pnl_login.Visible = true;
        }

        private void frm_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chamarLogin();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            chamarLogin();
        }

        private void Frm_Login_Resize(object sender, EventArgs e)
        {
            pnl_login.Location = new Point(this.Width / 2 - 160, this.Height / 2 - 190);
        }
        #endregion


        #region CODIGO PERSONALIZADO
        private void chamarLogin()
        {
            if (tb_login_user.Text == "" && tb_login_password.Text == "")
            {
                MessageBox.Show("Os campos Usuário e Senha não podem estar vazios!");
                tb_login_user.Focus();
                return;
            }

            if (tb_login_user.Text == "")
            {
                MessageBox.Show("Preencha o Usuário");
                tb_login_user.Focus();
                return;
            }

            if (tb_login_password.Text == "")
            {
                MessageBox.Show("Preencha a Senha");
                tb_login_password.Focus();
                return;
            }

            // AQUI VAI O CONDIGO PARA O LOGIN ...

            Frm_Menu menu = new Frm_Menu();
            //this.Hide();
            limparLogin();
            menu.Show();
        }

        private void limparLogin()
        {
            tb_login_user.Clear();
            tb_login_password.Clear();
            tb_login_user.Focus();
        }
        #endregion

    }
}
