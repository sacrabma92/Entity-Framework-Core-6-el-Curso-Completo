using CursoEntityCore.Models;
using Microsoft.EntityFrameworkCore;

namespace CursoEntityCore.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opciones) : base(opciones)
        {

        }
        // Escribir los modelos de las entidades. Que necesite
        public DbSet<Categoria> Categoria { get; set; }

        // Cuando crear migraciones (Buenas Practicas)
        // 1- Cuando se crea una nueva clase (Tabla en la bd)
        // 2- CUando agregue una nueva propiedad (Crear un campo nuevo en la bd)
        // 3- Cuando modifique un valor de campo en la bd (Modificar un campo en la bd)
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Articulo> Articulo { get; set; }
    }
}
