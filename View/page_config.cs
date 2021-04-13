using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace SMART_MOD
{
    public partial class config : Form    {
        private string vmouseclick = "2";
        private string vautoy = "2";
        private string vctrl = "2";
        private string vaspas = "2";
        private string user;
        private string cursor = "";
        Point Point = new Point();
        int x, y;
        public config(string user)        {
            InitializeComponent();
            this.user = user;
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

        private void pictureBox10_Click(object sender, EventArgs e)        {

        }

        private void xuiCheckBox3_Click(object sender, EventArgs e)        {
            bool a = false;
            if (!ctrlSelect.Checked == true)
            {
                vctrl = "Ctrl";
            }
            else if (ctrlSelect.Checked == true)
            {
                vctrl = "null";
            }
        }

        private void key1_KeyDown(object sender, KeyEventArgs e)        {
            string a = e.KeyCode.ToString(); //STRING 
            string teclaDigitada = Convert.ToString(e.KeyValue); //INT
            Console.WriteLine(e.KeyCode);
            string num = "D1D2D3D4D5D6D7D8D9D0";
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWYXZF1F2F3F4F5F6F7F8F9F10F11F12";
            if ((alpha).Contains(a) == true)
            {
                key1.Text = a;
            }
            else if (num.Contains(a))
            {
                string[] value = a.Split('D');
                key1.Text = value.GetValue(0).ToString();
            }
            else
            {
                if (teclaDigitada == "38") { key1.Text = "Acima"; }
                if (teclaDigitada == "40") { key1.Text = "Abaixo"; }
                if (teclaDigitada == "37") { key1.Text = "Esquerda"; }
                if (teclaDigitada == "39") { key1.Text = "Direita"; }
                if (teclaDigitada == "9") { key1.Text = "TAB"; }
                if (teclaDigitada == "20") { key1.Text = "CAPS LOOK"; }
                if (teclaDigitada == "16") { key1.Text = "SHIFT"; }
                if (teclaDigitada == "17") { key1.Text = "CTRL"; }
                if (teclaDigitada == "91") { key1.Text = "LWin"; }
                if (teclaDigitada == "18") { key1.Text = "ALT"; }
                if (teclaDigitada == "32") { key1.Text = "ESPAÇO"; }
                if (teclaDigitada == "226") { key3out.Text = ""; }
                if (teclaDigitada == "192") { key1.Text = "'"; }
                if (teclaDigitada == "13") { key1.Text = "ENTER"; }
                if (teclaDigitada == "189") { key1.Text = "-"; }
                if (teclaDigitada == "187") { key1.Text = "="; }
                if (teclaDigitada == "8") { key1.Text = "BACKSPACE"; }
                if (teclaDigitada == "219") { key1.Text = "´"; }
                if (teclaDigitada == "222") { key1.Text = "~"; }
                if (teclaDigitada == "191") { key1.Text = ";"; }
                if (teclaDigitada == "190") { key1.Text = "."; }
                if (teclaDigitada == "188") { key1.Text = ","; }
                if (teclaDigitada == "220") { key1.Text = "]"; }
                if (teclaDigitada == "221") { key1.Text = "["; }
                if (teclaDigitada == "27") { key1.Text = "ESC"; }
            }
        }

        private void key2_KeyDown(object sender, KeyEventArgs e)
        {
            string a = e.KeyCode.ToString(); //STRING 
            string teclaDigitada = Convert.ToString(e.KeyValue); //INT
            string num = "D1D2D3D4D5D6D7D8D9D0";
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWYXZF1F2F3F4F5F6F7F8F9F10F11F12";
            if ((alpha).Contains(a) == true)
            {
                key2.Text = a;
            }
            else if (num.Contains(a))
            {
                string[] value = a.Split('D');
                key2.Text = value.GetValue(0).ToString();
            }
            else
            {
                if (teclaDigitada == "38") { key2.Text = "Acima"; }
                if (teclaDigitada == "40") { key2.Text = "Abaixo"; }
                if (teclaDigitada == "37") { key2.Text = "Esquerda"; }
                if (teclaDigitada == "39") { key2.Text = "Direita"; }
                if (teclaDigitada == "9") { key2.Text = "TAB"; }
                if (teclaDigitada == "20") { key2.Text = "CAPS LOOK"; }
                if (teclaDigitada == "16") { key2.Text = "SHIFT"; }
                if (teclaDigitada == "17") { key2.Text = "CTRL"; }
                if (teclaDigitada == "91") { key2.Text = "LWin"; }
                if (teclaDigitada == "18") { key2.Text = "ALT"; }
                if (teclaDigitada == "32") { key2.Text = "ESPAÇO"; }
                if (teclaDigitada == "226") { key3out.Text = ""; }
                if (teclaDigitada == "192") { key2.Text = "'"; }
                if (teclaDigitada == "13") { key2.Text = "ENTER"; }
                if (teclaDigitada == "189") { key2.Text = "-"; }
                if (teclaDigitada == "187") { key2.Text = "="; }
                if (teclaDigitada == "8") { key2.Text = "BACKSPACE"; }
                if (teclaDigitada == "219") { key2.Text = "´"; }
                if (teclaDigitada == "222") { key2.Text = "~"; }
                if (teclaDigitada == "191") { key2.Text = ";"; }
                if (teclaDigitada == "190") { key2.Text = "."; }
                if (teclaDigitada == "188") { key2.Text = ","; }
                if (teclaDigitada == "220") { key2.Text = "]"; }
                if (teclaDigitada == "221") { key2.Text = "["; }
                if (teclaDigitada == "27") { key2.Text = "ESC"; }
            }
        }

        private void key3_KeyDown(object sender, KeyEventArgs e)
        {
            string a = e.KeyCode.ToString(); //STRING 
            string teclaDigitada = Convert.ToString(e.KeyValue); //INT
            string num = "D1D2D3D4D5D6D7D8D9D0";
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWYXZF1F2F3F4F5F6F7F8F9F10F11F12";
            if ((alpha).Contains(a) == true)
            {
                key3.Text = a;
            }
            else if (num.Contains(a))
            {
                string[] value = a.Split('D');
                key3.Text = value.GetValue(0).ToString();
            }
            else
            {
                if (teclaDigitada == "38") { key3.Text = "Acima"; }
                if (teclaDigitada == "40") { key3.Text = "Abaixo"; }
                if (teclaDigitada == "37") { key3.Text = "Esquerda"; }
                if (teclaDigitada == "39") { key3.Text = "Direita"; }
                if (teclaDigitada == "9") { key3.Text = "TAB"; }
                if (teclaDigitada == "20") { key3.Text = "CAPS LOOK"; }
                if (teclaDigitada == "16") { key3.Text = "SHIFT"; }
                if (teclaDigitada == "17") { key3.Text = "CTRL"; }
                if (teclaDigitada == "91") { key3.Text = "LWin"; }
                if (teclaDigitada == "18") { key3.Text = "ALT"; }
                if (teclaDigitada == "32") { key3.Text = "ESPAÇO"; }
                if (teclaDigitada == "226") { key3out.Text = ""; }
                if (teclaDigitada == "192") { key3.Text = "'"; }
                if (teclaDigitada == "13") { key3.Text = "ENTER"; }
                if (teclaDigitada == "189") { key3.Text = "-"; }
                if (teclaDigitada == "187") { key3.Text = "="; }
                if (teclaDigitada == "8") { key3.Text = "BACKSPACE"; }
                if (teclaDigitada == "219") { key3.Text = "´"; }
                if (teclaDigitada == "222") { key3.Text = "~"; }
                if (teclaDigitada == "191") { key3.Text = ";"; }
                if (teclaDigitada == "190") { key3.Text = "."; }
                if (teclaDigitada == "188") { key3.Text = ","; }
                if (teclaDigitada == "220") { key3.Text = "]"; }
                if (teclaDigitada == "221") { key3.Text = "["; }
                if (teclaDigitada == "27") { key3.Text = "ESC"; }
            }
        }

        private void key3out_KeyDown(object sender, KeyEventArgs e)
        {
            string a = e.KeyCode.ToString(); //STRING 
            string teclaDigitada = Convert.ToString(e.KeyValue); //INT
            string num = "D1D2D3D4D5D6D7D8D9D0";
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWYXZF1F2F3F4F5F6F7F8F9F10F11F12";
            if ((alpha).Contains(a) == true)
            {
                key3out.Text = a;
            }
            else if (num.Contains(a))
            {
                string[] value = a.Split('D');
                key3out.Text = value.GetValue(0).ToString();
            }
            else
            {
                if (teclaDigitada == "38") { key3out.Text = "Acima"; }
                if (teclaDigitada == "40") { key3out.Text = "Abaixo"; }
                if (teclaDigitada == "37") { key3out.Text = "Esquerda"; }
                if (teclaDigitada == "39") { key3out.Text = "Direita"; }
                if (teclaDigitada == "9") { key3out.Text = "TAB"; }
                if (teclaDigitada == "20") { key3out.Text = "CAPS LOOK"; }
                if (teclaDigitada == "16") { key3out.Text = "SHIFT"; }
                if (teclaDigitada == "17") { key3out.Text = "CTRL"; }
                if (teclaDigitada == "91") { key3out.Text = "LWin"; }
                if (teclaDigitada == "18") { key3out.Text = "ALT"; }
                if (teclaDigitada == "32") { key3out.Text = "ESPAÇO"; }
                if (teclaDigitada == "226") { key3out.Text = ""; }
                if (teclaDigitada == "192") { key3out.Text = "'"; }
                if (teclaDigitada == "13") { key3out.Text = "ENTER"; }
                if (teclaDigitada == "189") { key3out.Text = "-"; }
                if (teclaDigitada == "187") { key3out.Text = "="; }
                if (teclaDigitada == "8") { key3out.Text = "BACKSPACE"; }
                if (teclaDigitada == "219") { key3out.Text = "´"; }
                if (teclaDigitada == "222") { key3out.Text = "~"; }
                if (teclaDigitada == "191") { key3out.Text = ";"; }
                if (teclaDigitada == "190") { key3out.Text = "."; }
                if (teclaDigitada == "188") { key3out.Text = ","; }
                if (teclaDigitada == "220") { key3out.Text = "]"; }
                if (teclaDigitada == "221") { key3out.Text = "["; }
                if (teclaDigitada == "27") { key3out.Text = "ESC"; }
            }
        }

        private void key2out_KeyDown(object sender, KeyEventArgs e)
        {
            string a = e.KeyCode.ToString(); //STRING 
            string teclaDigitada = Convert.ToString(e.KeyValue); //INT
            string num = "D1D2D3D4D5D6D7D8D9D0";
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWYXZF1F2F3F4F5F6F7F8F9F10F11F12";
            if ((alpha).Contains(a) == true)
            {
                key2out.Text = a;
            }
            else if (num.Contains(a))
            {
                string[] value = a.Split('D');
                key2out.Text = value.GetValue(0).ToString();
            }
            else
            {
                if (teclaDigitada == "38") { key2out.Text = "Acima"; }
                if (teclaDigitada == "40") { key2out.Text = "Abaixo"; }
                if (teclaDigitada == "37") { key2out.Text = "Esquerda"; }
                if (teclaDigitada == "39") { key2out.Text = "Direita"; }
                if (teclaDigitada == "9") { key2out.Text = "TAB"; }
                if (teclaDigitada == "20") { key2out.Text = "CAPS LOOK"; }
                if (teclaDigitada == "16") { key2out.Text = "SHIFT"; }
                if (teclaDigitada == "17") { key2out.Text = "CTRL"; }
                if (teclaDigitada == "91") { key2out.Text = "LWin"; }
                if (teclaDigitada == "18") { key2out.Text = "ALT"; }
                if (teclaDigitada == "32") { key2out.Text = "ESPAÇO"; }
                if (teclaDigitada == "226") { key3out.Text = ""; }
                if (teclaDigitada == "192") { key2out.Text = "'"; }
                if (teclaDigitada == "13") { key2out.Text = "ENTER"; }
                if (teclaDigitada == "189") { key2out.Text = "-"; }
                if (teclaDigitada == "187") { key2out.Text = "="; }
                if (teclaDigitada == "8") { key2out.Text = "BACKSPACE"; }
                if (teclaDigitada == "219") { key2out.Text = "´"; }
                if (teclaDigitada == "222") { key2out.Text = "~"; }
                if (teclaDigitada == "191") { key2out.Text = ";"; }
                if (teclaDigitada == "190") { key2out.Text = "."; }
                if (teclaDigitada == "188") { key2out.Text = ","; }
                if (teclaDigitada == "220") { key2out.Text = "]"; }
                if (teclaDigitada == "221") { key2out.Text = "["; }
                if (teclaDigitada == "27") { key2out.Text = "ESC"; }
            }
        }

        private void key1out_KeyDown(object sender, KeyEventArgs e)
        {
            string a = e.KeyCode.ToString(); //STRING 
            string teclaDigitada = Convert.ToString(e.KeyValue); //INT
            string num = "D1D2D3D4D5D6D7D8D9D0";
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWYXZF1F2F3F4F5F6F7F8F9F10F11F12";
            if ((alpha).Contains(a) == true)
            {
                key1out.Text = a;
            }
            else if (num.Contains(a))
            {
                string[] value = a.Split('D');
                key1out.Text = value.GetValue(0).ToString();
            }
            else
            {
                if (teclaDigitada == "38") { key1out.Text = "Acima"; }
                if (teclaDigitada == "40") { key1out.Text = "Abaixo"; }
                if (teclaDigitada == "37") { key1out.Text = "Esquerda"; }
                if (teclaDigitada == "39") { key1out.Text = "Direita"; }
                if (teclaDigitada == "9") { key1out.Text = "TAB"; }
                if (teclaDigitada == "20") { key1out.Text = "CAPS LOOK"; }
                if (teclaDigitada == "16") { key1out.Text = "SHIFT"; }
                if (teclaDigitada == "17") { key1out.Text = "CTRL"; }
                if (teclaDigitada == "91") { key1out.Text = "LWin"; }
                if (teclaDigitada == "18") { key1out.Text = "ALT"; }
                if (teclaDigitada == "32") { key1out.Text = "ESPAÇO"; }
                if (teclaDigitada == "226") { key3out.Text = ""; }
                if (teclaDigitada == "192") { key1out.Text = "'"; }
                if (teclaDigitada == "13") { key1out.Text = "ENTER"; }
                if (teclaDigitada == "189") { key1out.Text = "-"; }
                if (teclaDigitada == "187") { key1out.Text = "="; }
                if (teclaDigitada == "8") { key1out.Text = "BACKSPACE"; }
                if (teclaDigitada == "219") { key1out.Text = "´"; }
                if (teclaDigitada == "222") { key1out.Text = "~"; }
                if (teclaDigitada == "191") { key1out.Text = ";"; }
                if (teclaDigitada == "190") { key1out.Text = "."; }
                if (teclaDigitada == "188") { key1out.Text = ","; }
                if (teclaDigitada == "220") { key1out.Text = "]"; }
                if (teclaDigitada == "221") { key1out.Text = "["; }
                if (teclaDigitada == "27") { key1out.Text = "ESC"; }
            }
        }

        private void button1_Click(object sender, EventArgs e)        {
            selectCursor.Filter = "Cursor|*.cur";
            if (selectCursor.ShowDialog() == DialogResult.OK)            {
                string caminnhoMousePersonalizado = selectCursor.FileName;
                cursor = caminnhoMousePersonalizado;
            }
            this.cursor1.CausesValidation = false;
            this.cursor2.CausesValidation = false;
            this.cursor1.Checked = false;
            this.cursor2.Checked = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)        {

        }

        private void bluestacksSensi_Click(object sender, EventArgs e)        {
            sensiX.Text = "0.5";
            sensiY.Text = "0.5";
        }

        private void ldplayerSensi_Click(object sender, EventArgs e)        {
            sensiX.Text = "0.3";
            sensiY.Text = "0.4";
        }

        private void smartgagaSensi_Click(object sender, EventArgs e)        {
            sensiX.Text = "0.2";
            sensiY.Text = "0.2";
        }

        private void misSensi_Click(object sender, EventArgs e)        {
            sensiX.Text = "0.4";
            sensiY.Text = "0.5";
        }

        private void mouseClick_Click(object sender, EventArgs e)        {
            bool a = false;
            //SE TIVER CHECADO
            if (!mouseClick.Checked == true)            {
                vmouseclick = "1";
            }
            else if (mouseClick.Checked == true)            {
                vmouseclick = "2";
            }
        }

        private void yAuto_Click(object sender, EventArgs e)
        {
            bool a = false;
            //SE TIVER CHECADO
            if (!yAuto.Checked == true)
            {
                vautoy = "1";
            }
            else if (yAuto.Checked == true)
            {
                vautoy = "2";
            }
        }

        private void aspasSelect_Click(object sender, EventArgs e)        {
            bool a = false;
            //SE TIVER CHECADO
            if (!aspasSelect.Checked == true)
            {
                vaspas = "'";
            }
            else if (aspasSelect.Checked == true)
            {
                vaspas = "null";
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)        {
            StreamWriter salvar = new StreamWriter("C:\\Users\\paulo\\Desktop\\sensi.txt");
            salvar.WriteLine("SensiX = " + sensiX.Text + "\n" + "SensiY = " + sensiY.Text + "\n"
                + "Mouse Click = " + vmouseclick + "\n" + "Y Auto = " + vautoy);
            salvar.Close();
        }


        private void saveCusror_Click(object sender, EventArgs e)        {
            StreamWriter salvar = new StreamWriter("C:\\Users\\paulo\\Desktop\\cursor.txt");
            if (this.cursor1.Checked == true)            {
                salvar.WriteLine("Cursor = CUR1");
                            
            } else if (this.cursor2.Checked == true)            {
                salvar.WriteLine("Cursor = CUR2");
            }
            salvar.Close();
        }

        private void pictureBox11_Click(object sender, EventArgs e)        {
            StreamWriter salvar = new StreamWriter("C:\\Users\\paulo\\Desktop\\keys.txt");
            salvar.WriteLine("KEY1 = " + key1.Text + "::" + key1out.Text + "\n" + "KEY2 = " + key2.Text
                + "::" + key2out.Text + "\n" + "KEY3 = " + key3.Text + "::" + key3out.Text + "\n\n"
                + "CRTL = " + vctrl + "::" + "\n" + "Aspas = " + vaspas + "::");
            salvar.Close();
        }

        private void sensiY_ValueChanged(object sender, EventArgs e)        {

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

        private void button4_Click(object sender, EventArgs e)        {
            this.Hide();
            home h = new home(user);
            h.ShowDialog();
            this.Close();

        }

        private void button7_Click(object sender, EventArgs e)        {
            this.Hide();
            page_otimizador c = new page_otimizador(user);
            c.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)        {
            this.Hide();
            page_suport sp = new page_suport(user);
            sp.ShowDialog();
            this.Close();
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

        private void button8_Click(object sender, EventArgs e)        {
            this.Hide();
            influencers sp = new influencers(user);
            sp.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)        {
            this.Hide();
            formPerfil sp = new formPerfil(user);
            sp.ShowDialog();
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)        {

        }

        private void sensiX_ValueChanged(object sender, EventArgs e)        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)        {
            StreamWriter salvar = new StreamWriter("C:\\Users\\paulo\\Desktop\\sensi.txt");
            salvar.WriteLine("SensiX = " + sensiX.Text + "\n" + "SensiY = " + sensiY.Text + "\n"
                + "Mouse Click = " + vmouseclick + "\n" + "Y Auto = " + vautoy);
            salvar.Close();
        }

        private void ctrlSelect_Click(object sender, EventArgs e)        {
            bool a = false;
            //SE TIVER CHECADO
            if (!ctrlSelect.Checked == true)
            {
                vctrl = "Ctrl";
            }
            else if (ctrlSelect.Checked == true)            {
                vctrl = "null";
            }
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
