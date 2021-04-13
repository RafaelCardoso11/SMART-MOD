using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SMART_MOD
{
    public partial class page_suport : Form    {
        private string user;
        int x, y;
        Point Point = new Point();
        public page_suport(string user)        {
            InitializeComponent();
            this.user = user;
            showMenu();
        }
        private void showMenu()        {
            panelConfig.Visible = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle Rect = new Rectangle(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, 50, 50, 180, 90);
            GraphPath.AddArc(Rect.X + Rect.Width - 50, Rect.Y, 50, 50, 270, 90);
            GraphPath.AddArc(Rect.X + Rect.Width - 50, Rect.Y + Rect.Height - 50, 50, 50, 0, 90);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - 50, 50, 50, 90, 90);
            this.Region = new Region(GraphPath);
        }

        private void Form2_Load(object sender, EventArgs e)        {

        }

        private void clickhere_Click(object sender, EventArgs e)        {

        }

        private void label6_Click(object sender, EventArgs e)        {

        }

        private void label3_Click(object sender, EventArgs e)        {
        }

        private void guna2Button1_Click(object sender, EventArgs e)        {
            System.Diagnostics.ProcessStartInfo sInfo = new ProcessStartInfo("http://www.google.com");
            Process.Start(sInfo);
        }

        private void home_Click(object sender, EventArgs e)        {
            this.Hide();
            home sp = new home(user);
            sp.ShowDialog();
            this.Close();
        }

        private void config_Click(object sender, EventArgs e)        {
            panelConfig.Visible = true;
        }

        private void config2_Click(object sender, EventArgs e)        {
            this.Hide();
            config sp = new config(user);
            sp.ShowDialog();
            this.Close();
        }

        private void clean_Click(object sender, EventArgs e)        {
            this.Hide();
            page_otimizador sp = new page_otimizador(user);
            sp.ShowDialog();
            this.Close();
        }

        private void login_Click(object sender, EventArgs e)        {
            this.Hide();
            influencers sp = new influencers(user);
            sp.ShowDialog();
            this.Close();
        }

        private void account_Click(object sender, EventArgs e)        {
            this.Hide();
            formPerfil sp = new formPerfil(user);
            sp.ShowDialog();
            this.Close();
        }
        private void topBar_MouseDown(object sender, MouseEventArgs e)        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void buttonMinimize_Click(object sender, EventArgs e)        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonClose_Click(object sender, EventArgs e)        {
            Application.Exit();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void suporte_Click(object sender, EventArgs e)
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
    }
}

