using Shouldly;
using StructBeaver.Arvores;
using StructBeaver.Arvores.Avl;

namespace StructBeaver.Tests.Arvores.Avl
{
    public class ArvoreAvlTest
    {
        private ArvoreAvl _arvoreAvl;

        public ArvoreAvlTest()        
            => _arvoreAvl = new(null);

        [Fact]
        public void Inserir_Deve_Balancear_Com_Rotacao_Simples_Direita()
        {
            NoAvl raiz = null;

            raiz = _arvoreAvl.Inserir(raiz, 30);
            raiz = _arvoreAvl.Inserir(raiz, 20);
            raiz = _arvoreAvl.Inserir(raiz, 10); 

            raiz.Valor.ShouldBe(20);
            raiz.NoEsquerdo.Valor.ShouldBe(10);
            raiz.NoDireito.Valor.ShouldBe(30);
        }

        [Fact]
        public void Inserir_Deve_Balancear_Com_Rotacao_Simples_Esquerda()
        {
            NoAvl raiz = null;

            raiz = _arvoreAvl.Inserir(raiz, 10);
            raiz = _arvoreAvl.Inserir(raiz, 20);
            raiz = _arvoreAvl.Inserir(raiz, 30); 

            raiz.Valor.ShouldBe(20);
            raiz.NoEsquerdo.Valor.ShouldBe(10);
            raiz.NoDireito.Valor.ShouldBe(30);
        }

        [Fact]
        public void Inserir_Deve_Balancear_Com_Rotacao_Dupla_Esquerda_Direita()
        {            
            NoAvl raiz = null;

            raiz = _arvoreAvl.Inserir(raiz, 30);
            raiz = _arvoreAvl.Inserir(raiz, 10);
            raiz = _arvoreAvl.Inserir(raiz, 20); 

            raiz.Valor.ShouldBe(20);
            raiz.NoEsquerdo.Valor.ShouldBe(10);
            raiz.NoDireito.Valor.ShouldBe(30);
        }

        [Fact]
        public void Inserir_Deve_Balancear_Com_Rotacao_Dupla_Direita_Esquerda()
        {            
            NoAvl raiz = null;

            raiz = _arvoreAvl.Inserir(raiz, 10);
            raiz = _arvoreAvl.Inserir(raiz, 30);
            raiz = _arvoreAvl.Inserir(raiz, 20); 

            raiz.Valor.ShouldBe(20);
            raiz.NoEsquerdo.Valor.ShouldBe(10);
            raiz.NoDireito.Valor.ShouldBe(30);
        }

        [Fact]
        public void Deve_Remover_Folha_Sem_Desbalancear()
        {            
            _arvoreAvl.RaizAvl = _arvoreAvl.Inserir(null, 10);
            _arvoreAvl.RaizAvl = _arvoreAvl.Inserir(_arvoreAvl.RaizAvl, 5);
            _arvoreAvl.RaizAvl = _arvoreAvl.Inserir(_arvoreAvl.RaizAvl, 15);

            _arvoreAvl.RaizAvl = _arvoreAvl.Remover(_arvoreAvl.RaizAvl, 5);

            _arvoreAvl.RaizAvl.Valor.ShouldBe(10);
            _arvoreAvl.RaizAvl.NoEsquerdo.ShouldBeNull(); 
            _arvoreAvl.RaizAvl.NoDireito.Valor.ShouldBe(15);
        }

        [Fact]
        public void Deve_Remover_Nodo_Com_Um_Filho_E_Reorganizar()
        {
            _arvoreAvl.RaizAvl = _arvoreAvl.Inserir(null, 10);
            _arvoreAvl.RaizAvl = _arvoreAvl.Inserir(_arvoreAvl.RaizAvl, 5);
            _arvoreAvl.RaizAvl = _arvoreAvl.Inserir(_arvoreAvl.RaizAvl, 2); 

            _arvoreAvl.RaizAvl = _arvoreAvl.Remover(_arvoreAvl.RaizAvl, 5); 

            _arvoreAvl.RaizAvl.NoEsquerdo.Valor.ShouldBe(2); 
        }

        [Fact]
        public void Deve_Remover_Nodo_Com_Dois_Filhos_E_Manter_Balanceamento()
        {
            int[] valores = [30, 20, 40, 10, 25, 35, 50];
            foreach (int v in valores)
                _arvoreAvl.RaizAvl = _arvoreAvl.Inserir(_arvoreAvl.RaizAvl, v);

            _arvoreAvl.RaizAvl = _arvoreAvl.Remover(_arvoreAvl.RaizAvl, 20);

            _arvoreAvl.RaizAvl.NoEsquerdo.Valor.ShouldBe(25); 
            _arvoreAvl.RaizAvl.NoEsquerdo.NoEsquerdo.Valor.ShouldBe(10);
            _arvoreAvl.RaizAvl.NoEsquerdo.NoDireito.ShouldBeNull(); 
        }

        [Fact]
        public void Deve_Manter_Arvore_Balanceada_Apos_Remocoes_Sucessivas()
        {
            int[] valores = [50, 30, 70, 20, 40, 60, 80];
            foreach (int v in valores)
                _arvoreAvl.RaizAvl = _arvoreAvl.Inserir(_arvoreAvl.RaizAvl, v);

            _arvoreAvl.RaizAvl = _arvoreAvl.Remover(_arvoreAvl.RaizAvl, 20);
            _arvoreAvl.RaizAvl = _arvoreAvl.Remover(_arvoreAvl.RaizAvl, 30);
            _arvoreAvl.RaizAvl = _arvoreAvl.Remover(_arvoreAvl.RaizAvl, 40);

            _arvoreAvl.RaizAvl.ShouldNotBeNull();
            _arvoreAvl.RaizAvl.Valor.ShouldBe(70);

            NoAvl noEsquerdo = _arvoreAvl.RaizAvl.NoEsquerdo;
            noEsquerdo.ShouldNotBeNull();
            noEsquerdo.Valor.ShouldBe(50);

            noEsquerdo.NoEsquerdo.ShouldBeNull();
            noEsquerdo.NoDireito.ShouldNotBeNull();
            noEsquerdo.NoDireito.Valor.ShouldBe(60);

            NoAvl noDireito = _arvoreAvl.RaizAvl.NoDireito;
            noDireito.ShouldNotBeNull();
            noDireito.Valor.ShouldBe(80);
        }
    }
}