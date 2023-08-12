
namespace AgendaUnip
{
    partial class frm_login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_login_user = new System.Windows.Forms.Panel();
            this.pnl_login = new System.Windows.Forms.Panel();
            this.pnl_login_password = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_login_user = new System.Windows.Forms.TextBox();
            this.tb_login_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_login_user
            // 
            this.pnl_login_user.BackColor = System.Drawing.Color.Transparent;
            this.pnl_login_user.BackgroundImage = global::AgendaUnip.Properties.Resources.users;
            this.pnl_login_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_login_user.Location = new System.Drawing.Point(25, 65);
            this.pnl_login_user.Name = "pnl_login_user";
            this.pnl_login_user.Size = new System.Drawing.Size(33, 30);
            this.pnl_login_user.TabIndex = 0;
            // 
            // pnl_login
            // 
            this.pnl_login.BackColor = System.Drawing.Color.Transparent;
            this.pnl_login.Controls.Add(this.label1);
            this.pnl_login.Controls.Add(this.btn_login);
            this.pnl_login.Controls.Add(this.pnl_login_password);
            this.pnl_login.Controls.Add(this.tb_login_password);
            this.pnl_login.Controls.Add(this.pnl_login_user);
            this.pnl_login.Controls.Add(this.tb_login_user);
            this.pnl_login.Location = new System.Drawing.Point(91, 24);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(320, 310);
            this.pnl_login.TabIndex = 1;
            // 
            // pnl_login_password
            // 
            this.pnl_login_password.BackColor = System.Drawing.Color.Transparent;
            this.pnl_login_password.BackgroundImage = global::AgendaUnip.Properties.Resources.senha_transp_maior;
            this.pnl_login_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_login_password.Location = new System.Drawing.Point(25, 133);
            this.pnl_login_password.Name = "pnl_login_password";
            this.pnl_login_password.Size = new System.Drawing.Size(33, 26);
            this.pnl_login_password.TabIndex = 1;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_login.Location = new System.Drawing.Point(25, 219);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(273, 50);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Entrar";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // tb_login_user
            // 
            this.tb_login_user.BackColor = System.Drawing.Color.AliceBlue;
            this.tb_login_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_login_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_login_user.Location = new System.Drawing.Point(25, 101);
            this.tb_login_user.Name = "tb_login_user";
            this.tb_login_user.Size = new System.Drawing.Size(273, 26);
            this.tb_login_user.TabIndex = 0;
            // 
            // tb_login_password
            // 
            this.tb_login_password.BackColor = System.Drawing.Color.AliceBlue;
            this.tb_login_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_login_password.Location = new System.Drawing.Point(25, 165);
            this.tb_login_password.Name = "tb_login_password";
            this.tb_login_password.Size = new System.Drawing.Size(273, 26);
            this.tb_login_password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(123, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AgendaUnip.Properties.Resources.LogoEscola01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.pnl_login);
            this.DoubleBuffered = true;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_login_user;
        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.Panel pnl_login_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_login_password;
        private System.Windows.Forms.TextBox tb_login_user;
        private System.Windows.Forms.Label label1;
    }
}

