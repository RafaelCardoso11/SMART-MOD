using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using SMART_MOD.Login;

namespace SMART_MOD
{
    public partial class page_login : Form    {
        int x, y;
        private string erro;
        Point Point = new Point();
      
       
        public page_login()        {
            Conexao login = new Conexao();

            if (login.ConexaoOn() == true)
            {
                InitializeComponent();
                showMenu();
                this.account.Visible = false;
                this.PainelMenu.Enabled = false;

            }
            else
            {
                this.Hide();
                page_erroConexao erroConexao = new page_erroConexao();
                erroConexao.Show();
            }

        }
        private void showMenu()        {
            panelConfig.Visible = false;
        }
        private Form activeControl = null;
        protected override void OnPaint(PaintEventArgs e)        {
            base.OnPaint(e);
            Rectangle Rect = new Rectangle(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, 50, 50, 180, 90);
            GraphPath.AddArc(Rect.X + Rect.Width - 50, Rect.Y, 50, 50, 270, 90);
            GraphPath.AddArc(Rect.X + Rect.Width - 50, Rect.Y + Rect.Height - 50, 50, 50, 0, 90);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - 50, 50, 50, 90, 90);
            this.Region = new Region(GraphPath);
        }
       
        private void loginButton_Click(object sender, EventArgs e)        {
            erroLogin();
        }
        private void erroLogin()
        {
            string apelido = Tbox_apelido.Text;
            string senha = Tbox_senha.Text;
            login con = new login();

            if (apelido == string.Empty && senha == string.Empty)
            {
                MessageBox.Show("NENHUM CAMPO PREENCHIDO");
            }
            else if (apelido == string.Empty)
            {
                MessageBox.Show("DIGITE ALGO EM APELIDO");
            }
            else if (senha == string.Empty)
            {
                MessageBox.Show("DIGITE ALGO EM SENHA");
            }
            else
            {
                con.conexaoBanco()
                
                
            }
        }
        private void TradePerfil(string perfil)
        {
          
        }
        private void panelTopBar_MouseDown(object sender, MouseEventArgs e)        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void buttonClose_Click(object sender, EventArgs e)        {
            Application.Exit();
        }

        private void config_Click(object sender, EventArgs e)        {
            panelConfig.Visible = true;
        }

        private void suporte_Click(object sender, EventArgs e)        {
           
        }

        private void buttonMinimize_Click(object sender, EventArgs e)        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonMinimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clickLabel_Click(object sender, EventArgs e)
        {

        }

        private void labelApelido_Click(object sender, EventArgs e)
        {

        }

        private void apelidoLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void senhaLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void topBar_MouseMove(object sender, MouseEventArgs e)        {
            if (e.Button == MouseButtons.Left)
            {
                Point = Control.MousePosition;
                Point.X -= x;
                Point.Y -= y;
                this.Location = Point;
                Application.DoEvents();
            }
        }
        private void topBar_MouseDown(object sender, MouseEventArgs e)        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }
    }
}
