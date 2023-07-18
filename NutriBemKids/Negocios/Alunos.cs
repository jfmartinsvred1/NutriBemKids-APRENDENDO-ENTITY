using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriBemKids.Negocios
{
    [Table("AssinaturaNutribem")]
    public class Alunos
    {
        [Column("Codigo")]
        public Guid Codigo = Guid.Empty;
        [Column("Nome")]
        public string Nome { get; set; }
        [Column("Preco")]
        public double Mensalidade { get; set; }
    }
}
