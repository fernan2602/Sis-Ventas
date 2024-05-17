using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using capaEntidad;
using capaNegocio;


namespace capaPresentacionWindows.Mantenimiento
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            clienteBL clienteBl = new clienteBL();
            dgvCliente.DataSource = clienteBl.Listar();

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
