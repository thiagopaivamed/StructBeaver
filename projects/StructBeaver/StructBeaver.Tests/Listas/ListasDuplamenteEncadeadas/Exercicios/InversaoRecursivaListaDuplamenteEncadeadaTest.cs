using StructBeaver.Listas.ListaDuplamenteEncadeada;
using StructBeaver.Listas.ListaDuplamenteEncadeada.Exercicios;

namespace StructBeaver.Tests.Listas.ListasDuplamenteEncadeadas.Exercicios
{
    public class InversaoRecursivaListaDuplamenteEncadeadaTest
    {
        private readonly InversaoRecursivaListaDuplamenteEncadeada _inversaoRecursivaListaDuplamenteEncadeada;

        public InversaoRecursivaListaDuplamenteEncadeadaTest()
            => _inversaoRecursivaListaDuplamenteEncadeada = new InversaoRecursivaListaDuplamenteEncadeada();

        [Fact]
        public void Inverter_Lista_Deve_Retornar_Lista_Invertida()
        {
            ListaDuplamenteEncadeada listaParaInversao = new ListaDuplamenteEncadeada();
            listaParaInversao.AdicionarNoFinal(1);
            listaParaInversao.AdicionarNoFinal(2);
            listaParaInversao.AdicionarNoFinal(3);
            listaParaInversao.AdicionarNoFinal(4);
            listaParaInversao.AdicionarNoFinal(5);

            ListaDuplamenteEncadeada listaInvertida = _inversaoRecursivaListaDuplamenteEncadeada.Inverter(listaParaInversao);

            int valor = 5;
            NoDuplamenteEncadeado primeiroNo = listaInvertida.PegarPrimeiroNo();

            while(primeiroNo is not null)
            {
                Assert.Equal(primeiroNo.Valor, valor);
                primeiroNo = primeiroNo.Proximo;
                valor = valor - 1;
            }
        }
    }
}