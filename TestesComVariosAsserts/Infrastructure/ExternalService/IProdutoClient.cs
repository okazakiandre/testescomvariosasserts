namespace TestesComVariosAsserts.Api.Infrastructure.ExternalService
{
    public interface IProdutoClient
    {
        decimal ObterPreco(int codigoProduto);
        ObterTaxasResponse ObterTaxas(int codigoProduto);
        decimal ObterTaxaPorTipo(int codigoProduto, short tipo);
    }
}
