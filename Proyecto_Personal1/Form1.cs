﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Personal1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Prueba  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {
          
        }
        public void textContraseña_TextChanged(object sender, EventArgs e)
        {
           
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
          if (textUsuario.Text == "Admin" && textContraseña.Text == "123")
            {
         
                textUsuario.Text = "";
                textContraseña.Text = "";
                //this.Hide();
                
                FormMenu form2 = new FormMenu();
                // Cierra el formulario de inicio de sesión
                form2.Show();
                   
            }
          else
            {
               
                //Por ahora no hay nada
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
