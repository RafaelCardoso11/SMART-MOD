using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMART_MOD
{
    public partial class influencers : Form    {
        private string user;
        private int x, y;
        Point Point = new Point();
        public influencers(string user)        {
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

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)        {

        }

        private void button1_Click(object sender, EventArgs e)        {
            this.Hide();
            home sp = new home(user);
            sp.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)        {
            if (panelConfig.Visible == true)
            {
                panelConfig.Visible = false;
            } else
            {
                panelConfig.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)        {
            this.Hide();
            config sp = new config(user);
            sp.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)        {
            this.Hide();
            page_otimizador sp = new page_otimizador(user);
            sp.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)        {
            this.Hide();
            page_suport sp = new page_suport(user);
            sp.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)        {
            this.Hide();
            formPerfil sp = new formPerfil(user);
            sp.ShowDialog();
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
