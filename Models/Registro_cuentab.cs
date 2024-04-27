using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace examen_gestion_cuenta_bancarias.Models
{
    [Table("t_CuentaBancaria")]
    public class Registro_cuentab
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {   get; set;}
        public string? Name { get; set; }
        public string? Tipo_Cuenta { get; set; }
        public string? SaldoI { get; set; }
        public string? Email { get; set; }
    }
}