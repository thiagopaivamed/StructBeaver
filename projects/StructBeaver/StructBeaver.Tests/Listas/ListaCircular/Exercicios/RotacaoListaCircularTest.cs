using StructBeaver.Listas.ListaCircular;
using StructBeaver.Listas.ListaCircular.Exercicios;

namespace StructBeaver.Tests.Listas.ListaCircular.Exercicios
{
    public class RotacaoListaCircularTest
    {
        private RotacaoListaCircular _rotacaoListaCircular;

        public RotacaoListaCircularTest()
            => _rotacaoListaCircular = new RotacaoListaCircular();

        [Fact]
        public void Rotacao_Lista_Circular_Deve_Retornar_Lista_Circular_Rotacionada()
        {
            ListaCircularDuplamenteEncadeada listaCircular = new ListaCircularDuplamenteEncadeada();
            listaCircular.AdicionarNoFim(1);
            listaCircular.AdicionarNoFim(2);
            listaCircular.AdicionarNoFim(3);

            _rotacaoListaCircular.Rotacionar(listaCircular, 1);

            Assert.Equal(2, listaCircular.PrimeiroNo.Valor);
            Assert.Equal(3, listaCircular.PrimeiroNo.Proximo.Valor);
            Assert.Equal(1, listaCircular.PrimeiroNo.Proximo.Proximo.Valor);
        }
    }
}