using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ascend;
using KeyAuth;

namespace Ascend
{
    public partial class YouTube : Form
    {
        public YouTube()
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

            //Fer transparent
            siticoneControlBox1.BackColor = System.Drawing.Color.Transparent;
            siticoneControlBox2.BackColor = System.Drawing.Color.Transparent;
            label18.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
        }

        void download_bot()
        {
            //Descarregar els archius del bot
            using (var client = new WebClient())
            {
                WebClient D = new WebClient();

                string dll1_url = "https://cdn.discordapp.com/attachments/815336257013022724/843969757547200532/Leaf.Core.dll";
                string dll1_path = @"C:\WINDOWS\IME\ProgramesAscend\Leaf.Core.dll";
                
            
                string dll2_url = "https://cdn.discordapp.com/attachments/848664854448308274/848664932178329600/Leaf.xNet.dll";
                string dll2_path = @"C:\WINDOWS\IME\ProgramesAscend\Leaf.xNet.dll";

                string bot_url = "https://cdn.discordapp.com/attachments/815336257013022724/843969762962964520/YtBot.exe";
                string bot_path = @"C:\WINDOWS\IME\ProgramesAscend\YtBot.exe";

                //Si ja existeixen, no els descarreguis
                if (File.Exists(dll1_path) && File.Exists(dll2_path) && File.Exists(bot_path))
                {  
                }
                //Si no existeixen, descarrega'ls
                else 
                {
                    D.DownloadFile(dll1_url, dll1_path);
                    D.DownloadFile(dll2_url, dll2_path);
                    D.DownloadFile(bot_url, bot_path);
                    Thread.Sleep(2000);
                }
                //Executar el programa
                Process.Start(bot_path);
            }
        }
        private void siticoneControlBox2_Click(object sender, EventArgs e)
        {

        }

        //Tancar la app
        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void YouTube_Load(object sender, EventArgs e)
        {
            //Fer que la foto de perfil sigui rodona
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;
        }

        //Enviar bots
        private void start_button_Click(object sender, EventArgs e)
        {
            string path = @"C:\WINDOWS\IME\ProgramesAscend";

            //Si el directori existeix, no fagis res
            if (Directory.Exists(path))
            {
                
            }
            //Si no existeix, crea'l
            else
            {
                try
                {
                    DirectoryInfo di = Directory.CreateDirectory(path);
                }
                catch(Exception)
                {
                    MessageBox.Show("Ha ocorregut un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //Crida a la funció que descarregarà i executarà el bot
            download_bot();

            //Mostrar el directe al navegador integrat
            string video_id = vid_id.Text;

            webBrowser1.Navigate("https://www.youtube.com/watch?v=" + video_id);
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
            this.Hide();
            TikTok f2 = new TikTok();
            f2.Show();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Config f2 = new Config();
            f2.Show();
        }
    }
}
