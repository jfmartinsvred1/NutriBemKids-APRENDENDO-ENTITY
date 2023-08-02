using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace NutriBemKids.Negocios
{
    
    public class Alunos
    {
        public Alunos()
        {
            CodigoID= Guid.NewGuid();
        }

        [Column("CodigoID")]
        [Key]
        public Guid CodigoID { get; set; }
        [Column("Nome")]
        public string Nome { get; set; }
        [Column("Preco")]
        public decimal Mensalidade { get; set; }
        [Column("NomeMae")]
        public string NomeMae { get; set; }
        public override string ToString()
        {
            return $"Aluno: {Nome}\nMensalidade Paga: R${Mensalidade.ToString("f2",CultureInfo.InvariantCulture)}\n";
        }
    }
}
