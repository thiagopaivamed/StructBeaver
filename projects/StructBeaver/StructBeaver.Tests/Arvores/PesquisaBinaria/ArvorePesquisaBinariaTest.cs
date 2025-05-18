using Shouldly;
using StructBeaver.Arvores;
using StructBeaver.Arvores.ArvorePesquisaBinaria;

namespace StructBeaver.Tests.Arvores.PesquisaBinaria
{
    public class ArvorePesquisaBinariaTest
    {
        private readonly ArvorePesquisaBinaria _arvorePesquisaBinaria;

        public ArvorePesquisaBinariaTest()
            => _arvorePesquisaBinaria = new(new NoArvore(50));

        [Fact]
        public void Inserir_Deve_Retornar_ValorMenor_Na_Esquerda()
        {
            NoArvore? noInserido = _arvorePesquisaBinaria.Inserir(30);

            noInserido.ShouldNotBeNull();
            noInserido.Valor.ShouldBe(30);
            _arvorePesquisaBinaria.Raiz.NoEsquerdo.ShouldBe(noInserido);
        }

        [Fact]
        public void Inserir_Deve_Retornar_Valor_Maior_Na_Direita()
        {
            NoArvore? noInserido = _arvorePesquisaBinaria.Inserir(70);

            noInserido.ShouldNotBeNull();
            noInserido.Valor.ShouldBe(70);
            _arvorePesquisaBinaria.Raiz.NoDireito.ShouldBe(noInserido);
        }

        [Fact]
        public void Inserir_Deve_Ignorar_Valor_Duplicado()
        {
            _arvorePesquisaBinaria.Inserir(30);
            NoArvore? noDuplicado = _arvorePesquisaBinaria.Inserir(30);

            noDuplicado.ShouldBeNull(); 
        }

        [Fact]
        public void Pesquisar_Deve_Encontrar_Valor_Na_Raiz()
        {
            NoArvore? noPesquisado = _arvorePesquisaBinaria.Pesquisar(50);

            noPesquisado.ShouldNotBeNull();
            noPesquisado.Valor.ShouldBe(50);
        }

        [Fact]
        public void Pesquisar_Deve_Encontrar_Valor_Em_Subarvore()
        {
            _arvorePesquisaBinaria.Inserir(30);
            _arvorePesquisaBinaria.Inserir(20);
            _arvorePesquisaBinaria.Inserir(40);

            NoArvore? noPesquisado = _arvorePesquisaBinaria.Pesquisar(20);

            noPesquisado.ShouldNotBeNull();
            noPesquisado.Valor.ShouldBe(20);
        }

        [Fact]
        public void Pesquisar_Deve_Retornar_Null_Para_Valor_Inexistente()
        {
            NoArvore? noPesquisado = _arvorePesquisaBinaria.Pesquisar(999);

            noPesquisado.ShouldBeNull();
        }

        [Fact]
        public void Deve_Remover_No_Folha()
        {
            InicializarArvore();

            _arvorePesquisaBinaria.Remover(40);

            _arvorePesquisaBinaria.Pesquisar(40).ShouldBeNull();
        }

        [Fact]
        public void Deve_Remover_No_Com_Um_Filho()
        {
            InicializarArvore();

            _arvorePesquisaBinaria.Remover(60);

            _arvorePesquisaBinaria.Pesquisar(60).ShouldBeNull();
            _arvorePesquisaBinaria.Pesquisar(40).ShouldNotBeNull();
        }

        [Fact]
        public void Deve_Remover_No_Com_Dois_Filhos()
        {
            InicializarArvore();

            _arvorePesquisaBinaria.Remover(70); 

            _arvorePesquisaBinaria.Pesquisar(70).ShouldBeNull();
            _arvorePesquisaBinaria.Pesquisar(60).ShouldNotBeNull();
            _arvorePesquisaBinaria.Pesquisar(80).ShouldNotBeNull();
        }

        [Fact]
        public void Deve_Remover_A_Raiz()
        {
            InicializarArvore();

            _arvorePesquisaBinaria.Remover(30); 

            _arvorePesquisaBinaria.Pesquisar(30).ShouldBeNull();
        }

        [Fact]
        public void Nao_Deve_Falhar_Ao_Remover_Valor_Inexistente()
        {
            InicializarArvore();

            _arvorePesquisaBinaria.Remover(999); 

            _arvorePesquisaBinaria.Pesquisar(30).ShouldNotBeNull();
            _arvorePesquisaBinaria.Pesquisar(70).ShouldNotBeNull();
        }

        private void InicializarArvore()
        {
            _arvorePesquisaBinaria.Inserir(30);
            _arvorePesquisaBinaria.Inserir(70);
            _arvorePesquisaBinaria.Inserir(20);
            _arvorePesquisaBinaria.Inserir(40);
            _arvorePesquisaBinaria.Inserir(60);
            _arvorePesquisaBinaria.Inserir(80); 
        }
    }
}