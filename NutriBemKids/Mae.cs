using NutriBemKids.Negocios;

namespace NutriBemKids
{
    public class Mae
    {
        public Mae()
        {
        }
        public int Id { get; set; }
        public string Nome { get; internal set; }
        public Alunos Filho { get; internal set; }
    }
}