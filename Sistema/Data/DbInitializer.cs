using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistema.Models;
namespace Sistema.Data
{
    public class DbInitializer
    {
        public static void Initialize (SistemaContext context)
        {
            context.Database.EnsureCreated();

            if (context.Categorias.Any())
            {
                return;
            }

            var categoria = new Categorias[]
            {
                new Categorias{Nombre="Programacion",Descripcion="Cursos de Programacion",Estado=true},
                new Categorias{Nombre="Diseño Grafico",Descripcion="Cursos de Photoshop",Estado=true}
            };

            foreach (Categorias c in categoria)
            {
                context.Categorias.Add(c);
            };
            context.SaveChanges();
        }
    }
}
