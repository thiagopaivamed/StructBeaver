using StructBeaver.Listas.ListaDuplamenteEncadeada;
using StructBeaver.Listas.ListaDuplamenteEncadeada.Exercicios;

namespace StructBeaver.Tests.Listas.ListasDuplamenteEncadeadas.Exercicios
{
    public class RemocaoParesListaDuplamenteEncadeadaTest
    {
        private RemocaoParesListaDuplamenteEncadeada _remocaoPares;

        public RemocaoParesListaDuplamenteEncadeadaTest()
            => _remocaoPares = new RemocaoParesListaDuplamenteEncadeada();

        [Fact]
        public void Remover_Pares_Lista_Deve_Retornar_Lista_Sem_Pares()
        {
            ListaDuplamenteEncadeada listaEncadeada = new ListaDuplamenteEncadeada();
            listaEncadeada.AdicionarNoInicio(1);
            listaEncadeada.AdicionarNoInicio(2);
            listaEncadeada.AdicionarNoInicio(3);
            listaEncadeada.AdicionarNoInicio(4);
            listaEncadeada.AdicionarNoInicio(5);
            listaEncadeada.AdicionarNoInicio(6);
            listaEncadeada.AdicionarNoInicio(7);
            listaEncadeada.AdicionarNoInicio(8);
            listaEncadeada.AdicionarNoInicio(9);
            listaEncadeada.AdicionarNoInicio(10);

            ListaDuplamenteEncadeada listaSemPares = _remocaoPares.Remover(listaEncadeada);
            NoDuplamenteEncadeado primeiroNo = listaSemPares.PegarPrimeiroNo();

            while (primeiroNo is not null)
            {
                Assert.NotEqual(0, primeiroNo.Valor % 2);
                primeiroNo = primeiroNo.Proximo;
            }
        }
    }
}