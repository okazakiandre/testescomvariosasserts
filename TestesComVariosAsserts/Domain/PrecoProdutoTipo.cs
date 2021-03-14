namespace TestesComVariosAsserts.Api.Domain
{
    public class PrecoProdutoTipo
    {
        public PrecoProdutoTipo(int codigo, decimal preco)
        {
            CodigoProduto = codigo;
            ValorUnitario = preco;
        }

        public int CodigoProduto { get; private set; }
        public decimal ValorUnitario { get; private set; }
        public decimal ValorTotal { get; private set; }

        public void CalcularPreco(decimal taxa)
        {
            ValorTotal = ValorUnitario * taxa;
        }
    }
}
