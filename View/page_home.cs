using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SMART_MOD
{
    public partial class home : Form
    {
        int x, y;
        Point Point = new Point();
        string user;
        public home(string user)        {
            this.user = user;
            InitializeComponent();
            showMenu();
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

        private void button2_Click(object sender, EventArgs e)        {

        }

        private void button5_Click(object sender, EventArgs e)        {
            WindowState = FormWindowState.Minimized;
        }
        private void button4_Click(object sender, EventArgs e)        {
            Application.Exit();
        }
        private void topBar_MouseDown(object sender, MouseEventArgs e)        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void button3_Click(object sender, EventArgs e)        {
            noticias.Visible = false;
            this.Hide();
            config c = new config(user);
            c.ShowDialog();
            c.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)        {
            if (panelConfig.Visible == false)
            {
                panelConfig.Visible = true;

            }
            else
            {
                panelConfig.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)        {

        }

        private void button6_Click(object sender, EventArgs e)        {
            noticias.Visible = false;
            this.Hide();
            formPerfil p = new formPerfil(user);
            p.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)        {
            this.Hide();
            page_otimizador p = new page_otimizador(user);
            p.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)        {
            System.Diagnostics.Process.Start("http://www.kodarbr.com");
        }

        private void pictureBox1_Click(object sender, EventArgs e)        {
            System.Diagnostics.Process.Start("https://www.instagram.com/kodarbr/");
        }

        private void pictureBox2_Click(object sender, EventArgs e)        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCH8KLYSlSruUmuNK_axvO_w");
        }

        private void button1_Click(object sender, EventArgs e)        {
            
        }

        private void button8_Click(object sender, EventArgs e)        {
            this.Hide();
            influencers sp = new influencers(user);
            sp.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)        {
            this.Hide();
            page_suport sp = new page_suport(user);
            sp.ShowDialog();
            this.Close();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonClose_Click(object sender, EventArgs e)        {
            Application.Exit();
        }

        private void topBar_Click(object sender, EventArgs e)        {

        }

        private void buttonMinimize_Click_1(object sender, EventArgs e)        {

        }

        private void buttonClose_Click_1(object sender, EventArgs e)        {

        }

        private void noticias_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
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
