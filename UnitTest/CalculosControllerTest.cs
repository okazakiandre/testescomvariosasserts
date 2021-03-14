using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestesComVariosAsserts.Api.Controllers;
using TestesComVariosAsserts.Api.Infrastructure.ExternalService;

namespace TestesComVariosAsserts.UnitTest
{
    [TestClass]
    public class CalculosControllerTest
    {
        [TestMethod]
        public void DeveriaCalcularATaxaCom3Valores()
        {
            var prd = new ProdutoClient();
            var calc = new CalculosController(prd);

            var ret = calc.ObterPrecosDoProduto(1);

            Assert.AreEqual(20, ret.Economica, "Não retornou 20 na econômica");
            Assert.AreEqual(50, ret.Normal, "Não retornou 50 na normal");
            Assert.AreEqual(80, ret.Vip, "Não retornou 80 na vip");
        }

        [TestMethod]
        public void DeveriaCalcularATaxaEconomica()
        {
            var prd = new ProdutoClient();
            var calc = new CalculosController(prd);

            var ret = calc.ObterPrecosDoProduto(1);

            Assert.AreEqual(20, ret.Economica);
        }

        [TestMethod]
        public void DeveriaCalcularATaxaNormal()
        {
            var prd = new ProdutoClient();
            var calc = new CalculosController(prd);

            var ret = calc.ObterPrecosDoProduto(1);

            Assert.AreEqual(50, ret.Normal);
        }

        [TestMethod]
        public void DeveriaCalcularATaxaVip()
        {
            var prd = new ProdutoClient();
            var calc = new CalculosController(prd);

            var ret = calc.ObterPrecosDoProduto(1);

            Assert.AreEqual(80, ret.Vip);
        }

        [TestMethod]
        public void DeveriaCalcularPorTipoATaxaEconomica()
        {
            var prd = new ProdutoClient();
            var calc = new CalculosController(prd);

            var ret = calc.ObterPrecoDoProdutoPorTipo(1, 1);

            Assert.AreEqual(20, ret);
        }

        [TestMethod]
        public void DeveriaCalcularPorTipoATaxaNormal()
        {
            var prd = new ProdutoClient();
            var calc = new CalculosController(prd);

            var ret = calc.ObterPrecoDoProdutoPorTipo(1, 2);

            Assert.AreEqual(50, ret);
        }

        [TestMethod]
        public void DeveriaCalcularPorTipoATaxaVip()
        {
            var prd = new ProdutoClient();
            var calc = new CalculosController(prd);

            var ret = calc.ObterPrecoDoProdutoPorTipo(1, 3);

            Assert.AreEqual(80, ret);
        }

        [TestMethod]
        public void DeveriaCalcularPorTipoOs3Valores()
        {
            var prd = new ProdutoClient();
            var calc = new CalculosController(prd);

            var ret = calc.ObterPrecoDoProdutoPorTipo(1, 1);
            Assert.AreEqual(20, ret);

            ret = calc.ObterPrecoDoProdutoPorTipo(1, 2);
            Assert.AreEqual(50, ret);

            ret = calc.ObterPrecoDoProdutoPorTipo(1, 3);
            Assert.AreEqual(20, ret);
        }
    }
}
