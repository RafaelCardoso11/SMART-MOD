using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SMART_MOD
{
    public partial class page_otimizador : Form    {
        private Form activeControl = null;
        private string user;
        private int x, y;
        private Point Point = new Point();
        public page_otimizador(string user)        {
            InitializeComponent();
            this.user = user;
            showMenu();
        }
        private void showMenu()        {
            panelConfig.Visible = true;
        }
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

        private void guna2Button1_Click(object sender, EventArgs e)        {
            this.Hide();
            page_clear c2 = new page_clear(user);
            c2.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)        {

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)        {
            MessageBox.Show("Checado");
        }

        private void cleanPanel_Paint(object sender, PaintEventArgs e)        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)        {
            if (panelConfig.Visible == true)
            {
                panelConfig.Visible = false;
            }
            else
            {
                panelConfig.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)        {
            this.Hide();
            config c = new config(user);
            c.ShowDialog();
            this.Close();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonClose_Click(object sender, EventArgs e)        {
            Application.Exit();
        }

        private void topBar_MouseDown(object sender, MouseEventArgs e)        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void button1_Click(object sender, EventArgs e)        {
            this.Hide();
            home c = new home(user);
            c.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)        {

        }

        private void button8_Click(object sender, EventArgs e)        {
            this.Hide();
            influencers c = new influencers(user);
            c.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)        {
            this.Hide();
            page_suport c = new page_suport(user);
            c.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)        {
            this.Hide();
            formPerfil c = new formPerfil(user);
            c.ShowDialog();
            this.Close();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)        {
            this.Hide();
            page_clear c = new page_clear(user);
            c.ShowDialog();
            this.Close();
        }

        private void topBar_MouseMove(object sender, MouseEventArgs e)        {
            if (e.Button == MouseButtons.Left)            {
                Point = Control.MousePosition;
                Point.X -= x;
                Point.Y -= y;
                this.Location = Point;
                Application.DoEvents();
            }
        }
    }
}
