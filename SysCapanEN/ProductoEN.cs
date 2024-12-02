using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysCapanEN
{
    public class ProductoEN
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        public decimal Precio { get; set; }

        [ForeignKey("Categoria")]
        public int idCategoria { get; set; }

        public Categoria Categoria { get; set; }
    }
}
