using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn_Soriana
{
    public partial class Login : Form
    {

        SQL_Control sqlControl = new SQL_Control();
        public Login()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void boton_logIn_Click(object sender, EventArgs e)
        {
            int result = sqlControl.Login(txtUsuario.Text, txtContraseña.Text);

            if (result == 1)
            {
                Frm_Menu Menu = new Frm_Menu();
                this.Hide();
                Menu.ShowDialog();

            }
            else if (result == 0)
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Contraseña_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                int result = sqlControl.Login(txtUsuario.Text, txtContraseña.Text);

                if (result == 1)
                {
                    Frm_Menu Menu = new Frm_Menu();
                    this.Hide();
                    Menu.ShowDialog();

                }
                else if (result == 0)
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }
            }
        }

        private void Link_Form(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Registro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registro registro = new Registro();
            registro.ShowDialog();
        }
    }
    }