namespace TestesComVariosAsserts.Api.Domain
{
    public class PrecoProduto
    {
        public PrecoProduto(int codigo, decimal preco)
        {
            CodigoProduto = codigo;
            ValorUnitario = preco;
        }

        public int CodigoProduto { get; private set; }
        public decimal ValorUnitario { get; private set; }
        public decimal ValorEconomica { get; private set; }
        public decimal ValorNormal { get; private set; }
        public decimal ValorVip { get; private set; }

        public void CalcularPrecos(decimal vlrEconomica, decimal vlrNormal, decimal vlrVip)
        {
            ValorEconomica = ValorUnitario * vlrEconomica;
            ValorNormal = ValorUnitario * vlrNormal;
            ValorVip = ValorUnitario * vlrVip;
        }
    }
}
