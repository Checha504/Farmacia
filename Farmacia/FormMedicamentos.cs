using BL.Farmacia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BL.Farmacia.MedicamentosBL;

namespace Farmacia
{
    public partial class FormMedicamentos : Form
    {
        MedicamentosBL _medicamentos;
        CategoriasBL _categorias;
        TiposBL _tipos;

        public FormMedicamentos()
        {
            InitializeComponent();

            _medicamentos = new MedicamentosBL();
            listaMedicamentosBindingSource.DataSource = _medicamentos.ObtenerMedicamentos();

            _categorias = new CategoriasBL();
            listaCategoriasBindingSource.DataSource = _categorias.ObtenerCategorias();

            _tipos = new TiposBL();
            listaTiposBindingSource.DataSource = _tipos.ObtenerTipos();
        }

        private void listaMedicamentosBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void listaMedicamentosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaMedicamentosBindingSource.EndEdit();
            var medicamento = (Medicamento)listaMedicamentosBindingSource.Current;

            if(fotoPictureBox.Image != null)
            {
                medicamento.Foto = Program.imageToByteArray(fotoPictureBox.Image);
            }
            else
            {
                medicamento.Foto = null;
            }

            var resultado = _medicamentos.GuardarMedicamento(medicamento);

            if (resultado.Exitoso == true)
            {
                listaMedicamentosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Medicamento Guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _medicamentos.AgregarMedicamento();
            listaMedicamentosBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);

        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
            if(idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
            }
        }

        private void Eliminar(int id)
        {
            var resultado = _medicamentos.EliminarMedicamento(id);

            if (resultado == true)
            {
                listaMedicamentosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar un Medicamento");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _medicamentos.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var medicamento = (Medicamento)listaMedicamentosBindingSource.Current;

            if(medicamento != null)
            {
                openFileDialog1.ShowDialog();
                var archivo = openFileDialog1.FileName;

                if (archivo != "")
                {
                    var fileInfo = new FileInfo(archivo);
                    var fileStream = fileInfo.OpenRead();

                    fotoPictureBox.Image = Image.FromStream(fileStream);
                }
                
            }
            else
            {
                MessageBox.Show("Cree un nuevo medicamento antes de asignarle una imagen ");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            fotoPictureBox.Image = null;
        }
    }
}
