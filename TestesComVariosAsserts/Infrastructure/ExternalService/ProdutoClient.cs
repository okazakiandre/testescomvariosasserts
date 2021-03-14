namespace TestesComVariosAsserts.Api.Infrastructure.ExternalService
{
    public class ProdutoClient : IProdutoClient
    {
        public decimal ObterPreco(int codigoProduto)
        {
            if (codigoProduto == 1)
            {
                return 1000;
            }
            return 700;
        }

        public ObterTaxasResponse ObterTaxas(int codigoProduto)
        {
            if (codigoProduto == 1)
            {
                return new ObterTaxasResponse
                {
                    TaxaEconomica = 0.02m,
                    TaxaNormal = 0.05m,
                    TaxaVip = 0.08m
                };
            }
            return new ObterTaxasResponse
            {
                TaxaEconomica = 0.01m,
                TaxaNormal = 0.03m,
                TaxaVip = 0.07m
            };
        }

        public decimal ObterTaxaPorTipo(int codigoProduto, short tipo)
        {
            if (codigoProduto == 1)
            {
                return tipo switch
                {
                    1 => 0.02m,
                    2 => 0.05m,
                    3 => 0.08m,
                    _ => 1
                };
            }
            return tipo switch
            {
                1 => 0.01m,
                2 => 0.03m,
                3 => 0.07m,
                _ => 1
            };
        }
    }
}
