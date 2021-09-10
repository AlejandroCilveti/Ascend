using KeyAuth;
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
using Ascend;

namespace Ascend
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();

            //Intentar ficar foto de perfil
            try
            {
                string ImageLocation = @"C:\WINDOWS\IME\ImatgesAscend\imatge.png";

                pictureBox2.BackgroundImage = Image.FromFile(Path.Combine(ImageLocation));
            }
            catch (Exception) { }

            //Intentar ficar fons de pantalla
            try
            {
                string ImageLocation = @"C:\WINDOWS\IME\ImatgesAscend\fons.png";

                this.BackgroundImage = Image.FromFile(Path.Combine(ImageLocation));
                this.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox4.BackgroundImage = Image.FromFile(Path.Combine(ImageLocation));
                pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;

            }
            catch (Exception) { }

            //Ficar el fons transparent
            siticoneControlBox1.BackColor = System.Drawing.Color.Transparent;
            siticoneControlBox2.BackColor = System.Drawing.Color.Transparent;
            lbltitle.BackColor = System.Drawing.Color.Transparent;

            //Mostrar "Veritat"
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.pictureBox1, "Veritat");

            //Mirar si hi ha foto de perfil
            if (File.Exists(@"C:\WINDOWS\IME\ImatgesAscend\imatge.png"))
            {
                siticoneLabel1.Text = "Sí que hi ha foto de perfil";
                siticoneLabel2.Text = "Nom de l'archiu: imatge.png";
                siticoneLabel4.Text = @"C:\WINDOWS\IME\ImatgesAscend";

                //Mostrar informació
                System.Windows.Forms.ToolTip ToolTip3 = new System.Windows.Forms.ToolTip();
                ToolTip3.SetToolTip(this.siticoneLabel2, "Obrir archiu");

                System.Windows.Forms.ToolTip ToolTip4 = new System.Windows.Forms.ToolTip();
                ToolTip4.SetToolTip(this.webpage, "Navegar");
            }
            else
            {
                siticoneLabel1.Text = "No hi ha foto de perfil";
                siticoneLabel2.Text = "Nom de l'archiu: no existeix";
            }

            //Mostrar informació per a que l'usuari sàpiga on està el directori
            System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
            ToolTip2.SetToolTip(this.siticoneLabel4, "Navegar al directori");

            //Mirar si hi ha fons de pantalla
            if (File.Exists(@"C:\WINDOWS\IME\ImatgesAscend\fons.png"))
            {
                siticoneLabel5.Text = "Sí que hi ha fons";
                siticoneLabel6.Text = "Nom de l'archiu: fons.png";
                siticoneLabel8.Text = @"C:\WINDOWS\IME\ImatgesAscend";

                //Mostrar informació
                System.Windows.Forms.ToolTip ToolTip5 = new System.Windows.Forms.ToolTip();
                ToolTip5.SetToolTip(this.siticoneLabel6, "Obrir archiu");
            }
            else
            {
                siticoneLabel5.Text = "No hi ha fons";
                siticoneLabel6.Text = "Nom de l'archiu: no existeix";
            }
            
            //Mostrar informació
            System.Windows.Forms.ToolTip ToolTip6 = new System.Windows.Forms.ToolTip();
            ToolTip6.SetToolTip(this.siticoneLabel8, "Navegar");
        }

        //Seleccionar foto de perfil
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //Mira si existeix l'archiu i si existeix, dóna un error
            if (File.Exists(@"C:\WINDOWS\IME\ImatgesAscend\imatge.png"))
            {
                MessageBox.Show("Error, ja hi ha una foto de perfil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Si no existeix, crea el directori
                string path = @"C:\WINDOWS\IME\ImatgesAscend";

                try
                {
                    DirectoryInfo di = Directory.CreateDirectory(path);
                }
                finally
                { }

                //Aqui el que fà el programa és agafar on està la imatge seleccionada per l'usuari i fa una còpia amb un nom específic al directori abans creat
                string imageLocation = "";
                string destinationFile = @"C:\WINDOWS\IME\ImatgesAscend\imatge.png";

                try
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        imageLocation = dialog.FileName;
                    }

                    if (File.Exists(@"C:\WINDOWS\IME\ImatgesAscend\imatge.png"))
                    {
                        MessageBox.Show("La imatge locatlitzada a " + imageLocation + " ha sigut carregada correctament!", "Perfecte!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocorregut un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    File.Copy(imageLocation, destinationFile, true);

                    //Recarregant la finestra per a que apliqui els canvis
                    this.Hide();
                    Config f2 = new Config();
                    f2.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("No s'ha seleccionat ninguna foto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Borrar foto de perfil
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            //Mira si l'archiu existeix
            if (File.Exists(@"C:\WINDOWS\IME\ImatgesAscend\imatge.png"))
            {
                //Intenta eliminar la foto (cosa impossible) pero ho fa per probar
                try
                {
                    File.Delete(@"C:\WINDOWS\IME\ImatgesAscend\imatge.png");
                }
                /*
                Quan detecta un error, demana a l'usuari fer-ho de maner manual
                Això passa perquè l'arxiu està sent utilitzat pel programa i per tant, no es pot eliminar
                La solució a això és que l'usuari elimini l'archiu amb la aplicació tancada, i per tant, és el que fa el programa
                 */
                catch (Exception)
                {  
                    DialogResult dialogResult = MessageBox.Show("Aquest procés s'ha de fer manualment. Vols fer-lo?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Process.Start(@"C:\WINDOWS\IME\ImatgesAscend");
                        Environment.Exit(0);
                    }
                }
            }
            else
            {
                //Si detecta que l'archiu no existeix
                MessageBox.Show("No hi ha cap foto de perfil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Tancar app
        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atacar f2 = new Atacar();
            f2.Show();
        }

        private void Config_Load(object sender, EventArgs e)
        {
            //Fer la foto de perfil rodona
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox2.Width - 3, pictureBox2.Height - 3);
            Region rg = new Region(gp);
            pictureBox2.Region = rg;
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal f2 = new Principal();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Mostrar la "veritat"
            credits2.Text = "Idea de Alejandro Cilveti";
        }

        private void siticoneLabel4_Click(object sender, EventArgs e)
        {
            //Navegar al directori
            Process.Start(@"C:\WINDOWS\IME\ImatgesAscend");
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneLabel2_Click(object sender, EventArgs e)
        {
            //Si l'archiu existeix, navega al directori. Sinó , donaria error ja que no pots obrir quelcom que no exiteix
            if (File.Exists(@"C:\WINDOWS\IME\ImatgesAscend\imatge.png"))
            {
                Process.Start(@"C:\WINDOWS\IME\ImatgesAscend\imatge.png");
            }
        }

        //Navegar a la pàgina web
        private void webpage_Click(object sender, EventArgs e)
        {
            Process.Start("https://oroelcobaya.space");
        }

        //Seleccionar el fons (el mateix que la foto de perfil però ara l'archiu es diu 'fons.png')
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\WINDOWS\IME\ImatgesAscend\fons.png"))
            {
                MessageBox.Show("Error, ja hi ha un fons", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string path = @"C:\WINDOWS\IME\ImatgesAscend";

                try
                {
                    DirectoryInfo di = Directory.CreateDirectory(path);
                }
                finally
                { }

                string imageLocation = "";
                string destinationFile = @"C:\WINDOWS\IME\ImatgesAscend\fons.png";

                try
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        imageLocation = dialog.FileName;
                    }

                    if (File.Exists(@"C:\WINDOWS\IME\ImatgesAscend\fons.png")) 
                    {
                        MessageBox.Show("El fons locatlitzat a " + imageLocation + " ha sigut carregat correctament!", "Perfecte!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocorregut un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    File.Copy(imageLocation, destinationFile, true);

                    //Recarregant la finestra per a que apliqui els canvis
                    this.Hide();
                    Config f2 = new Config();
                    f2.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("No s'ha carregat ningun fons", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Borrar el fons (el mateix que la foto de perfil però ara l'archiu es diu 'fons.png')
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\WINDOWS\IME\ImatgesAscend\fons.png"))
            {
                try
                {
                    File.Delete(@"C:\WINDOWS\IME\ImatgesAscend\fons.png");
                }
                catch (Exception)
                {
                    DialogResult dialogResult = MessageBox.Show("Aquest procés s'ha de fer manualment. Vols fer-lo?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Process.Start(@"C:\WINDOWS\IME\ImatgesAscend");
                        Environment.Exit(0);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hi ha cap fons", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Si l'archiu existeix, es pot obrir
        private void siticoneLabel6_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\WINDOWS\IME\ImatgesAscend\imatge.png"))
            {
                Process.Start(@"C:\WINDOWS\IME\ImatgesAscend\fons.png");
            }
        }

        //Obrir el directori
        private void siticoneLabel8_Click(object sender, EventArgs e)
        {
            //Navegar al directori
            Process.Start(@"C:\WINDOWS\IME\ImatgesAscend");
        }
    }
}
