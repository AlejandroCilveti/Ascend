using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ascend
{
    public partial class TikTok : Form
    {
        public TikTok()
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

            //Intentar ficar imatge de perfil
            try
            {
                string ImageLocation = @"C:\WINDOWS\IME\ImatgesAscend\imatge.png";

                pictureBox1.BackgroundImage = Image.FromFile(Path.Combine(ImageLocation));
            }
            catch (Exception) { }

            //Ficar els iconers que no són transparent de sèria, a transparent per a que quedi millor
            siticoneControlBox1.BackColor = System.Drawing.Color.Transparent;
            siticoneControlBox2.BackColor = System.Drawing.Color.Transparent;
            lbltitle.BackColor = System.Drawing.Color.Transparent;
        }

        //Tancar la app
        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //Fer que la foto de perfil sigui rodona
        private void TikTok_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;
        }

        //Procés de ficar bots al video o a la conta
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string tiktok_user = user.Text;
            string tiktok_vidID = vid_id.Text;
            try
            {
                //Fa que el navegador integrat navequi al video
                webBrowser1.Navigate("https://www.tiktok.com/@" + tiktok_user + "/video/" + tiktok_vidID + "?is_copy_url=1&is_from_webapp=v1");
            }
            catch(Exception)
            {
                //Si no funciona, diu que hi ha un error
                MessageBox.Show("El navegador no s'ha pogut carregar correctament", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //He estat fent recerca i no existeixen bots per a TikTOk en c# i no són possibles de fer
            //Llavors, he pensat en buscar una pàgina web funcional i enviar a l'usuari allà amb unes instruccions de que ha de posar
            System.Diagnostics.Process.Start("https://www.zefoy.com");
            textBox14.Text = "Es necessita procés d'enviament manual per enviar bots a '" + tiktok_user + "', redirigint...";
            MessageBox.Show("1. escriu la paraula mostrada\n" + "2. Elegeix la opció que més et convingui (si surt en vermell s'esta actualitzant)\n" + "3. Introdueix el link del vídeo i dóna-li al botó\n\n" + "Després d'utilitzar-la et tindràs d'esperar una quantitat de temps limitada", "Passos a seguir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal f2 = new Principal();
            f2.Show();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atacar f2 = new Atacar();
            f2.Show();
        }

        private void btnCalender_Click(object sender, EventArgs e)
        {

        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            this.Hide();
            YouTube f2 = new YouTube();
            f2.Show();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            this.Show();
            Config f2 = new Config();
            f2.Show();
        }

        //Netejar
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            textBox14.Text = "";
            user.Text = "";
            vid_id.Text = "";
        }
    }
}
