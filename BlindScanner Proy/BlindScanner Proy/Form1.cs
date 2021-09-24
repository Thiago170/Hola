using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BlindScanner_Proy
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();

            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_usuarios.mdb");
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter da = new OleDbDataAdapter();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtNomUsuario.Text == "" && txtContraseña.Text == "")
            {
                MessageBox.Show("El nombre de usario y la contraseña se encuentran incompletos");
            }
            else if (txtNomUsuario.Text == txtContraseña.Text)
            {
                con.Open();
                string register = "INSERT INTO Tabla1 VALUES ('" + txtNomUsuario
            }
        }
    }
}
