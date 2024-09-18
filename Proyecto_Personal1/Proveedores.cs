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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
            TemaColor.colorLbl(lblProveedores);
            TemaColor.colorFondoVentana(this);
            
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {

        }
    }
}
