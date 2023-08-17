using System.ComponentModel.DataAnnotations;

namespace FullStackNET.Models
{
    
    public class Employee
    {
        [Key]
        public Guid Codigo { get;  set; }
        public string Nombre { get;  set; }
        public string Correo { get;  set; }
        public long Telefono { get; set; }
        public long Salario { get; set; }
        public string Area { get; set; }
    }
}
