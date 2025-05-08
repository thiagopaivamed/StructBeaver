using StructBeaver.Listas.ListaCircular;
using StructBeaver.Listas.ListaCircular.Exercicios;

namespace StructBeaver.Tests.Listas.ListaCircular.Exercicios
{
    public class QuantidadeNosListaCircularTest
    {
        private QuantidadeNosListaCircular _quantidadeNosListaCircular;

        public QuantidadeNosListaCircularTest()
            => _quantidadeNosListaCircular = new QuantidadeNosListaCircular();

        [Fact]
        public void Quantidade_Nos_Lista_Circular_Deve_Retornar_Quantidade_De_Nos_Na_Lista_Circular()
        {
            ListaCircularDuplamenteEncadeada listaCircular = new ListaCircularDuplamenteEncadeada();
            listaCircular.AdicionarNoInicio(1);
            listaCircular.AdicionarNoInicio(2);
            listaCircular.AdicionarNoInicio(3);
            listaCircular.AdicionarNoInicio(4);
            listaCircular.AdicionarNoInicio(5);
            
            int quantidadeNos = _quantidadeNosListaCircular.ContarQuantidadeNos(listaCircular);
            Assert.Equal(5, quantidadeNos);
        }
    }
}