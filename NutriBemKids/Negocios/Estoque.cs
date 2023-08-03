using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace NutriBemKids.Negocios
{
    [Table("EstoqueNutribem")]
    public class Estoque
    {
        public Estoque() 
        {
            Id=Guid.NewGuid();
            Data=DateTime.Now;
        }

        [Column("Id")]
        [Key]
        public Guid Id { get; set; }
        [Column("Nome")]
        public string Nome { get; set; }
        [Column("Quantidade")]
        public int Quantidade { get; set; }
        [Column("ValorUnitario")]
        public double ValorUnitario { get; set; }
        [Column("Tipo")]
        public string Tipo { get; set; }
        [Column("Data")]
        public DateTime Data { get; set; }
        public override string ToString()
        {
            return $"Produto: {Nome} \n" +
                $"Quantidade: {Quantidade} \n" +
                $"Tipo: {Tipo} \n" +
                $"Ultima Alteração: {Data:dd/MM/yyyy} \n" +
                $"Valor Unitario Gasto: R${ValorUnitario.ToString("f2",CultureInfo.InvariantCulture)}\n" +
                $"-----------------------------------";
        }
    }

}
