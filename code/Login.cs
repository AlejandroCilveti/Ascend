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
using Ascend;
using System.Windows.Input;

namespace KeyAuth
{
    public partial class Login : Form
    {
        //Aixó és la part més important del programa, ja que és el que et connecta amb la base de dades
        static string name = "Ascend";
        static string ownerid = "Ew0WDwFYoj";
        static string secret = "bd845d4471d432221a1dca731a620a30ec7da2a40275185fb5222fb9b6d91fc0";
        static string version = "1.0";
       

        public static api KeyAuthApp = new api(name, ownerid, secret, version);

        public Login()
        {
            InitializeComponent();

            //Fer directori d'imatges
            string path_img = @"C:\WINDOWS\IME\ImatgesAscend";

            if (Directory.Exists(path_img))
            {     

            }
            else
            {
                try
                {
                    DirectoryInfo di = Directory.CreateDirectory(path_img);
                }
                catch (Exception)
                { }

                //Fer directori de programes
                string path_prg = @"C:\WINDOWS\IME\ProgramesAscend";

                if (Directory.Exists(path_prg))
                {

                }
                else
                {
                    try
                    {
                        DirectoryInfo di = Directory.CreateDirectory(path_prg);
                    }
                    catch (Exception)
                    { }
                }
        }

            //Ficar clau i iniciar sessió automàticament si aquesta és correcta
            key.Text = Ascend.Properties.Settings.Default.Key;

            //Fer transparent
            key.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            siticoneControlBox1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
        }

        //Tancar app
        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //Quan s'obre l'app, s'inicialitza el servidor
        private void Login_Load(object sender, EventArgs e)
        {
            KeyAuthApp.init();
        }

        //Iniciar sessió
        private void Login_button_Click(object sender, EventArgs e)
        {   
            //Si no hi ha text, dóna un error
            if(key.Text == "")
            {
                MessageBox.Show("No hi ha cap text escrit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Si hi ha text, mira si aquest coincideix amb alguna de les claus a la base de dades
            else if (KeyAuthApp.license(key.Text))
            {
                /*
                Si sí que ho fa, envia un missatge amb un bot de discord instal·lat a aquest servidor:
                https://discord.gg/S4PAqTUp2g
                Aquest missatge diu el nom de la app, quina clau ha sigut utilitzada i quan ha iniciat sessió
                */
                KeyAuthApp.log(name);

                //Això és el 'Enrecorda'm'
                //Si està actiu, guarda l'archiu en els ajustos de l'aplicació perquè s'enrecordi
                if(RememberCheckBox.Checked == true)
                {
                    Ascend.Properties.Settings.Default.Key = key.Text;
                    Ascend.Properties.Settings.Default.Save();
                }
                //Si no està marcat, el borra
                else
                {
                    Ascend.Properties.Settings.Default.Key = "";
                    Ascend.Properties.Settings.Default.Save();
                }

                //S'amaga a si mateix i obre 'Principal'
                this.Hide();
                Principal f2 = new Principal();
                f2.Show();
            }
        }

        private void key_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            //Si l'usuari fa clic al text de 'Enrecorda'm' també es pot activar i desactivar.
            if(RememberCheckBox.Checked == false)
            {
                RememberCheckBox.Checked = true;
            }
            else
            {
                RememberCheckBox.Checked = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Això és la petita imatge de l'ull a la dreta del lloc on has de ficar la clau

            //El primer que fa és que una sigui visible i l'altre no
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;

            //Si que sigui invisible està activat el desactiva
            if (key.PasswordChar == '•')
            {
                key.PasswordChar = '\0';
            }
            //I a l'inrevés
            else if (key.PasswordChar == '\0')
            {
                key.PasswordChar = '•';
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Com ara l'altre no existeix, si li dones click, li dones a la del fons i fa el mateix que l'altre, produint un bucle
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;

            //Si que sigui invisible està activat el desactiva
            if (key.PasswordChar == '•')
            {
                key.PasswordChar = '\0';
            }
            //I a l'inrevés
            else if (key.PasswordChar == '\0')
            {
                key.PasswordChar = '•';
            }
        }
    }
}
