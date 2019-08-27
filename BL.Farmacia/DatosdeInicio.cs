using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL.Farmacia
{
    public class DatosdeInicio : System.Data.Entity.CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var usuarioAdmin = new Usuario();
            usuarioAdmin.Nombre = "admin";
            usuarioAdmin.Contrasena = "123";

            contexto.Usuarios.Add(usuarioAdmin);

            var categoria1 = new Categoria();
            categoria1.Descripcion = "Antiinfecciosos";
            contexto.Categorias.Add(categoria1);

            var categoria2 = new Categoria();
            categoria2.Descripcion = "Analgèsicos";
            contexto.Categorias.Add(categoria2);

            var categoria3 = new Categoria();
            categoria3.Descripcion = "Antigripales";
            contexto.Categorias.Add(categoria3);

            var categoria4 = new Categoria();
            categoria4.Descripcion = "Antialèrgicos";
            contexto.Categorias.Add(categoria4);

            var tipo1 = new Tipo();
            tipo1.Descripcion = "Orales";
            contexto.Tipos.Add(tipo1);

            var tipo2 = new Tipo();
            tipo2.Descripcion = "Intravenosos";
            contexto.Tipos.Add(tipo2);

            var tipo3 = new Tipo();
            tipo3.Descripcion = "Tópicos";
            contexto.Tipos.Add(tipo3);

            var tipo4 = new Tipo();
            tipo4.Descripcion = "Soluciones ópticas";
            contexto.Tipos.Add(tipo4);

            base.Seed(contexto);
        }
    }
}
