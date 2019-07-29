﻿using BL.Farmacia;
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
    public partial class FormMedicamentos : Form
    {
        MedicamentosBL _medicamentos;

        public FormMedicamentos()
        {
            InitializeComponent();

            _medicamentos = new MedicamentosBL();

            listaMedicamentosBindingSource.DataSource = _medicamentos.ObtenerMedicamentos();
        }
    }
}
