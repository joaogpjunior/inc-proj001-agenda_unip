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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            pnl_login.Location = new Point(this.Width / 2 - 160, this.Height / 2 - 190);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_login_user.Text == "" && tb_login_password.Text == "")
            {
                MessageBox.Show("Ocampos Usuário e Senha não podem estar vazios!");
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
            this.Hide();
            menu.Show();
        }
    }
}
