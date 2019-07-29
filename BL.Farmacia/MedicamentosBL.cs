using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Farmacia
{
    public class MedicamentosBL
    {
        public BindingList<Medicamento> listaMedicamentos { get; set; }

        public MedicamentosBL()
        {
            listaMedicamentos = new BindingList<Medicamento>();

            var medicamento1 = new Medicamento();

            medicamento1.Id = 1;
            medicamento1.Descripcion = "Aspirina";
            medicamento1.Precio = 10;
            medicamento1.Existencia = 120;
            medicamento1.Activo = true;

            var medicamento2 = new Medicamento();

            medicamento2.Id = 2;
            medicamento2.Descripcion = "Amoxicilina";
            medicamento2.Precio = 25;
            medicamento2.Existencia = 150;
            medicamento2.Activo = true;

            var medicamento3 = new Medicamento();

            medicamento3.Id = 3;
            medicamento3.Descripcion = "Panadol";
            medicamento3.Precio = 7;
            medicamento3.Existencia = 80;
            medicamento3.Activo = true;

            listaMedicamentos.Add(medicamento1);
            listaMedicamentos.Add(medicamento2);
            listaMedicamentos.Add(medicamento3);
        }

        public BindingList<Medicamento> ObtenerMedicamentos()
        {
            return listaMedicamentos;
        }

        public class Medicamento
        {
            public int Id { get; set; }
            public string Descripcion { get; set; }
            public double Precio { get; set; }
            public int Existencia { get; set; }
            public bool Activo { get; set; }

        }
    }
}

