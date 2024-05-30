using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_login
{
    public partial class AgregarDatos : Form
    {
        public AgregarDatos()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon = new SqlConnection($"Data Source=Albert5to;Initial Catalog=loginprueba;Persist Security Info=True;User ID=Albert;Password=yonalber");

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string consulta = $"insert into Tabla_ventas(Producto,Precio,Cantidad,Categoria) values ('{txtProducto.Text}',{txtPrecio.Text},{txtCantidad.Text},'{txtCategoria.Text}');";
            sqlcon.Open();
            SqlDataAdapter data = new SqlDataAdapter(consulta, sqlcon);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dataGridView1.DataSource = dt;
            



            string consulta2 = "select * from Tabla_ventas";
            SqlDataAdapter data2 = new SqlDataAdapter(consulta2, sqlcon);

            DataTable dt2 = new DataTable();
            data.Fill(dt2);
            dataGridView1.DataSource = dt2;
            sqlcon.Close();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtProducto.Clear();
            txtPrecio.Clear();  
            txtCantidad.Clear();
            txtCategoria.Clear();
        }
    }


}
