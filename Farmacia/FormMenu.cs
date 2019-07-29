using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void usuariosYPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fromMedicamentos = new FormMedicamentos();
            fromMedicamentos.MdiParent = this;
            fromMedicamentos.Show();

        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFacturas = new FormFacturas();
            formFacturas.MdiParent = this;
            formFacturas.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProveedores = new FormProveedores();
            formProveedores.MdiParent = this;
            formProveedores.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

            Login();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClientes = new FormClientes();
            formClientes.MdiParent = this;
            formClientes.Show();
        }
    }
}
