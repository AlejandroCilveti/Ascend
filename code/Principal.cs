using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ascend
{
    public partial class Principal : Form
    {
        public Principal()
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

            //Mostrar informació
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.siticoneLabel7, "Navegar");

            System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
            ToolTip2.SetToolTip(this.siticoneLabel7, "Navegar");

            System.Windows.Forms.ToolTip ToolTip3 = new System.Windows.Forms.ToolTip();
            ToolTip3.SetToolTip(this.siticoneLabel7, "Navegar");

            //Mostrar "La veritat"
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.label8, "Veritat");

            //Fer transparent
            siticoneControlBox1.BackColor = System.Drawing.Color.Transparent;
            siticoneControlBox2.BackColor = System.Drawing.Color.Transparent;
            lbltitle.BackColor = System.Drawing.Color.Transparent;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //Fer que la foto de perfil sigui rodona
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;
        }
        
        //Tancar la app
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

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atacar f2 = new Atacar();
            f2.Show();
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

        }

        private void btnAnalytics_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Atacar f2 = new Atacar();
            f2.Show();
        }

        private void btnCalender_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            TikTok f2 = new TikTok();
            f2.Show();
        }

        private void btnContactUs_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            YouTube f2 = new YouTube();
            f2.Show();
        }

        private void btnsettings_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Config f2 = new Config();
            f2.Show();
        }

        private void siticoneControlBox2_Click(object sender, EventArgs e)
        {

        }

        //Mostrar la 'veritat'
        private void label8_Click(object sender, EventArgs e)
        {
            siticoneLabel5.Text = "Sóc l'Alejandro Cilveti i he fet tot aquest projecte";
            siticoneLabel9.Text = "Jo he tingut un paper molt important";
        }

        //Navegar a les diferents`pàgines web
        private void siticoneLabel7_Click(object sender, EventArgs e)
        {
            Process.Start("https://keyauth.com/");
        }

        private void siticoneLabel8_Click(object sender, EventArgs e)
        {
            Process.Start("https://stackoverflow.com/");
        }

        private void siticoneLabel3_Click(object sender, EventArgs e)
        {
            Process.Start("https://auth.gg/");
        }
    }
}
