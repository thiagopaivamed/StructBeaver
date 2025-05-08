using StructBeaver.Listas.ListaEncadeada;
using StructBeaver.Listas.ListaEncadeada.Exercicios;

namespace StructBeaver.Tests.Listas.ListasEncadeadas.Exercicios
{
    public class JuncaoListasEncadeadasTest
    {
        private JuncaoListasEncadeadas _juncaoListasEncadeadas;

        public JuncaoListasEncadeadasTest()        
            => _juncaoListasEncadeadas = new JuncaoListasEncadeadas();

        [Fact]
        public void Juncao_Listas_Deve_Retornar_Lista_Combinada()
        {
            ListaEncadeada lista1 = new ListaEncadeada();
            lista1.AdicionarNoFim(1);
            lista1.AdicionarNoFim(2);
            lista1.AdicionarNoFim(3);
            lista1.AdicionarNoFim(4);
            lista1.AdicionarNoFim(5);

            ListaEncadeada lista2 = new ListaEncadeada();
            lista2.AdicionarNoFim(6);
            lista2.AdicionarNoFim(7);
            lista2.AdicionarNoFim(8);
            lista2.AdicionarNoFim(9);

            ListaEncadeada listaCombinada = _juncaoListasEncadeadas.FazerMerge(lista1, lista2);

            Assert.Equal(1, listaCombinada.RemoverNoInicio().Valor);
            Assert.Equal(6, listaCombinada.RemoverNoInicio().Valor);
            Assert.Equal(2, listaCombinada.RemoverNoInicio().Valor);
            Assert.Equal(7, listaCombinada.RemoverNoInicio().Valor);
            Assert.Equal(3, listaCombinada.RemoverNoInicio().Valor);
            Assert.Equal(8, listaCombinada.RemoverNoInicio().Valor);
            Assert.Equal(4, listaCombinada.RemoverNoInicio().Valor);
            Assert.Equal(9, listaCombinada.RemoverNoInicio().Valor);
            Assert.Equal(5, listaCombinada.RemoverNoInicio().Valor);
        }
    }
}