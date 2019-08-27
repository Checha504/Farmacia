using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BL.Farmacia.CategoriasBL;

namespace BL.Farmacia
{
    public class MedicamentosBL
    {
        Contexto _contexto;

        public BindingList<Medicamento> listaMedicamentos { get; set; }

        public MedicamentosBL()
        {
            _contexto = new Contexto();
            listaMedicamentos = new BindingList<Medicamento>();
        }

        public BindingList<Medicamento> ObtenerMedicamentos()
        {
            _contexto.Medicamentos.Load();
            listaMedicamentos = _contexto.Medicamentos.Local.ToBindingList();
            return listaMedicamentos;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarMedicamento(Medicamento medicamento)
        {
            var resultado = Validar(medicamento);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }


        public void AgregarMedicamento()
        {
            var nuevoMedicamento = new Medicamento();

            _contexto.Medicamentos.Add(nuevoMedicamento);
        }


        public bool EliminarMedicamento(int id)
        {
            foreach (var medicamento in listaMedicamentos.ToList())
            {
                if (medicamento.Id == id)
                {
                    listaMedicamentos.Remove(medicamento);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        private Resultado Validar(Medicamento medicamento)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if(string.IsNullOrEmpty(medicamento.Descripcion) == true)
            {
                resultado.Mensaje = "Ingrese una Descripcion";
                resultado.Exitoso = false;
            }

            if (medicamento.Existencia < 0)
            {
                resultado.Mensaje = "La existencia debe ser mayor que cero";
                resultado.Exitoso = false;
            }

            if (medicamento.Precio < 0)
            {
                resultado.Mensaje = "El precio debe ser mayor que cero";
                resultado.Exitoso = false;
            }

            if (medicamento.TipoId == 0)
            {
                resultado.Mensaje = "Seleccione un Tipo";
                resultado.Exitoso = false;
            }

            if (medicamento.CategoriaId == 0)
            {
                resultado.Mensaje = "Seleccione una Categoria";
                resultado.Exitoso = false;
            }

            return resultado;
        }


        public class Medicamento
        {
            public int Id { get; set; }
            public string Descripcion { get; set; }
            public double Precio { get; set; }
            public int Existencia { get; set; }
            public int CategoriaId { get; set; }
            public Categoria Categoria { get; set; }
            public int TipoId { get; set; }
            public Tipo Tipo { get; set; }
            public byte[] Foto { get; set; }
            public bool Activo { get; set; }

            public Medicamento()
            {
                Activo = true;
            }

        }

        public class Resultado
        {
            public bool Exitoso { get; set; }
            public string Mensaje { get; set; }

        }
    }
}

