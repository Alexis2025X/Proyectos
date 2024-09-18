using System;
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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();

            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        

        private void btnSalir_Click(object sender, EventArgs e)
        {

            // Verifica si el formulario "formularioMenu" está abierto
            
            FormLogin form1 = new FormLogin();
            form1.Show();
            this.Close();
        }

        private void btnCuentas_Click(object sender, EventArgs e)
        {
            FormCuentas form3 = new FormCuentas();
            form3.Show();
            this.Close();
        }
    }
}
