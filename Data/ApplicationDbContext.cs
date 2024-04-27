using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace examen_gestion_cuenta_bancarias.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {}
        
    public DbSet<examen_gestion_cuenta_bancarias.Models.Registro_cuentab> DataProducto {get; set; }
    
}
