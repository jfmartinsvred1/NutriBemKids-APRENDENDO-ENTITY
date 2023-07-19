using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NutriBemKids.Negocios
{
    [Table("AssinaturaNutribem")]
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
        public override string ToString()
        {
            return $"Aluno: {Nome}, Mensalidade Paga: {Mensalidade}";
        }
    }
}
