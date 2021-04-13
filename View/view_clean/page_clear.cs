using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SMART_MOD
{
    public partial class page_clear : Form
    {
        GraphicsPath GraphPath;
        private string user;
        private int x, y;
        Point Point = new Point();
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle Rect = new Rectangle(0, 0, this.Width, this.Height);
            GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, 50, 50, 180, 90);
            GraphPath.AddArc(Rect.X + Rect.Width - 50, Rect.Y, 50, 50, 270, 90);
            GraphPath.AddArc(Rect.X + Rect.Width - 50, Rect.Y + Rect.Height - 50, 50, 50, 0, 90);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - 50, 50, 50, 90, 90);
            this.Region = new Region(GraphPath);
        }

        public page_clear(string user)        {
            InitializeComponent();
            this.user = user;
            showMenu();
        }
        private void showMenu()        {
            panelConfig.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)        {

        }

        private void label3_Click(object sender, EventArgs e)        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)        {

        }

        private void buttonMinimize_Click(object sender, EventArgs e)        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonClose_Click(object sender, EventArgs e)        {
            Application.Exit();
        }

        private void home_Click(object sender, EventArgs e)        {
            this.Hide();
            home h = new home(user);
            h.ShowDialog();
            this.Close();
        }

        private void config_Click(object sender, EventArgs e)        {
            if (panelConfig.Visible == true) {
                panelConfig.Visible = false;
            } else {
                panelConfig.Visible = true;
            }
        }

        private void config2_Click(object sender, EventArgs e)        {
            this.Hide();
            config c = new config(user);
            c.ShowDialog();
            this.Close();
        }

        private void clean_Click(object sender, EventArgs e)        {
            this.Hide();
            page_otimizador cf = new page_otimizador(user);
            cf.ShowDialog();
            this.Close();
        }

        private void login_Click(object sender, EventArgs e)        {
            this.Hide();
            influencers sp = new influencers(user);
            sp.ShowDialog();
            this.Close();
        }

        private void suporte_Click(object sender, EventArgs e)        {
            this.Hide();
            page_suport sp = new page_suport(user);
            sp.ShowDialog();
            this.Close();
        }

        private void account_Click(object sender, EventArgs e)        {
            this.Hide();
            formPerfil sp = new formPerfil(user);
            sp.ShowDialog();
            this.Close();
        }
        private void topBar_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void topBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point = Control.MousePosition;
                Point.X -= x;
                Point.Y -= y;
                this.Location = Point;
                Application.DoEvents();
            }
        }
    }
}
