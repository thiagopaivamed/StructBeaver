using Shouldly;
using StructBeaver.Grafos;

namespace StructBeaver.Tests.Grafos
{
    public sealed class GrafoMatrizAdjacenciaTest
    {
        private readonly GrafoMatrizAdjacencia _grafoNaoDirecionado;
        private readonly GrafoMatrizAdjacencia _grafoDirecionado;

        public GrafoMatrizAdjacenciaTest()
        {
            _grafoNaoDirecionado = new GrafoMatrizAdjacencia(5);               
            _grafoDirecionado = new GrafoMatrizAdjacencia(5, direcionado: true); 
        }

        [Fact]
        public void Adicionar_Aresta_Nao_Direcionada_Deve_Adicionar_Peso_Correto()
        {
            int origem = 0;
            int destino = 1;
            int peso = 5;

            bool arestaFoiAdicionada = _grafoNaoDirecionado.AdicionarAresta(origem, destino, peso);

            arestaFoiAdicionada.ShouldBeTrue();
            _grafoNaoDirecionado.ExisteAresta(origem, destino).ShouldBeTrue();
            _grafoNaoDirecionado.ExisteAresta(destino, origem).ShouldBeTrue();
        }

        [Fact]
        public void Adicionar_Aresta_Direcionada_Deve_Adicionar_Peso_Correto()
        {
            int origem = 0;
            int destino = 1;
            int peso = 7;

            bool arestaFoiAdicionada = _grafoDirecionado.AdicionarAresta(origem, destino, peso);

            arestaFoiAdicionada.ShouldBeTrue();
            _grafoDirecionado.ExisteAresta(origem, destino).ShouldBeTrue();
            _grafoDirecionado.ExisteAresta(destino, origem).ShouldBeFalse(); 
        }

        [Fact]
        public void Remover_Aresta_Nao_Direcionada_Deve_Remover_Corretamente()
        {
            _grafoNaoDirecionado.AdicionarAresta(2, 3, 4);

            bool arestaFoiRemovida = _grafoNaoDirecionado.RemoverAresta(2, 3);

            arestaFoiRemovida.ShouldBeTrue();
            _grafoNaoDirecionado.ExisteAresta(2, 3).ShouldBeFalse();
            _grafoNaoDirecionado.ExisteAresta(3, 2).ShouldBeFalse();
        }

        [Fact]
        public void Remover_Aresta_Direcionada_Deve_Remover_Corretamente()
        {
            _grafoDirecionado.AdicionarAresta(2, 3, 4);

            bool arestaFoiRemovida = _grafoDirecionado.RemoverAresta(2, 3);

            arestaFoiRemovida.ShouldBeTrue();
            _grafoDirecionado.ExisteAresta(2, 3).ShouldBeFalse();
            _grafoDirecionado.ExisteAresta(3, 2).ShouldBeFalse();
        }        
    }
}
