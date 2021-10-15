using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_BlindScanner
{
    public partial class Calendario : Form
    {
        public Calendario()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form menuForm = new menú();
            menuForm.Show();
            this.Hide();
        }

        private void Calendario_Load(object sender, EventArgs e)
        {
            for (int f = 1; f <= 96; f++)
            {

            }
        }
    }
}
