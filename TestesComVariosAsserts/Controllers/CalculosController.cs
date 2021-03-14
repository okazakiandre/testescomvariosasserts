using Microsoft.AspNetCore.Mvc;
using TestesComVariosAsserts.Api.Domain;
using TestesComVariosAsserts.Api.Infrastructure.ExternalService;

namespace TestesComVariosAsserts.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculosController : ControllerBase
    {
        private IProdutoClient ProdCli { get; }

        public CalculosController(IProdutoClient prd)
        {
            ProdCli = prd;
        }

        [HttpGet("produto/{codigoProduto}")]
        public ObterPrecosDoProdutoResponse ObterPrecosDoProduto(int codigoProduto)
        {
            var preco = ProdCli.ObterPreco(codigoProduto);
            var taxas = ProdCli.ObterTaxas(codigoProduto);

            var ret = new PrecoProduto(codigoProduto, preco);
            ret.CalcularPrecos(taxas.TaxaEconomica, taxas.TaxaNormal, taxas.TaxaVip);

            return new ObterPrecosDoProdutoResponse
            {
                Economica = ret.ValorEconomica,
                Normal = ret.ValorNormal,
                Vip = ret.ValorVip
            };
        }

        [HttpGet("produto/{codigoProduto}/tipotaxa/{tipoTaxa}")]
        public decimal ObterPrecoDoProdutoPorTipo(int codigoProduto, short tipoTaxa)
        {
            var preco = ProdCli.ObterPreco(codigoProduto);
            var taxa = ProdCli.ObterTaxaPorTipo(codigoProduto, tipoTaxa);

            var ret = new PrecoProdutoTipo(codigoProduto, preco);
            ret.CalcularPreco(taxa);

            return ret.ValorTotal;
        }
    }
}
