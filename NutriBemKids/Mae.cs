using NutriBemKids.Negocios;

namespace NutriBemKids
{
    public class Mae
    {
        public Mae()
        {
            if(QuantidadeFilhos>1)
            {
                Mensalidade = QuantidadeFilhos * 250;
            }
            else
            {
                Mensalidade = QuantidadeFilhos * 310;
            }
        }
        public int Id { get; set; }
        public string Nome { get; internal set; }
        public string Filho { get; internal set; }
        public int QuantidadeFilhos { get; set; }
        public double Mensalidade { get; set; }

        



    }
}