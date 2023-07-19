using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriBemKids.Negocios
{
    [Table("Gastos")]
    public class Gastos
    {
        public Gastos() 
        {
            CodigoID= Guid.NewGuid();
            Data=DateTime.Now;
        }
        [Column("CodigoID")]
        [Key]
        public Guid CodigoID { get; set; }
        [Column("Tipo")]
        public string Tipo { get; set; }
        [Column("Valor")]
        public decimal Valor { get; set; }
        [Column("Data")]
        public DateTime Data { get; set; }
    }
}
