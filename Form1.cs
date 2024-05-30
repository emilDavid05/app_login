using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Entidades;
using Capa_Negocio;

namespace app_login
{
    public partial class Form1 : Form
    {

        N_users objnuser = new N_users();
        E_users objeuser = new E_users();
        Principal frm1 = new Principal();

        public static string usuario_nombre;
        public static string area;

        void p_logueo()
        {

            DataTable dt = new DataTable();
            objeuser.usuario = txtUsuario.Text;
            objeuser.clave = txtClave.Text;

            dt = objnuser.N_user(objeuser);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido " + dt.Rows[0][1].ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario_nombre = dt.Rows[0][1].ToString();
                area = dt.Rows[0][0].ToString();

                frm1.ShowDialog();

                Form1 login = new Form1  ();
                login.ShowDialog();

                if (login.DialogResult == DialogResult.OK)
                    Application.Run(new Principal());

                txtUsuario.Clear();
                txtClave.Clear();


            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInicial_Click(object sender, EventArgs e)
        {
            p_logueo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
