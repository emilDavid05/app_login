using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using app_login;

namespace app_login
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //admin
            if (Form1.area == "A0001")

            {
                btnAlmacen.Enabled = true;
                btnVentas.Enabled = true;
                btnCompras.Enabled = true;

                lblCargo.Text = "Administrador";
                lblNombre.Text = "Dilon Baby";
            }

            //Ventas
            else if (Form1.area == "A0002")

            {
                btnAlmacen.Enabled = false;
                btnVentas.Enabled = true;
                btnCompras.Enabled = false;

                lblCargo.Text = "Ventas";
                lblNombre.Text = "Rochy RD";
            }
            //Compras
            else if (Form1.area == "A0003")

            {
                btnAlmacen.Enabled = false;
                btnVentas.Enabled = false;
                btnCompras.Enabled = true;

                lblCargo.Text = "Compras";
                lblNombre.Text = "Tolentino";
            }

            
        }

  
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
             
            AgregarDatos agregarDatos = new AgregarDatos();

            agregarDatos.Show();
        }
    }
}
