using StructBeaver.Listas;

namespace StructBeaver.Tests.Listas
{
    public class ListaEncadeadaTest
    {
        private ListaEncadeada _listaEncadeada;

        public ListaEncadeadaTest()
            => _listaEncadeada = new ListaEncadeada();
        

        [Fact]
        public void AdicionarInicio_Deve_Adicionar_No_Inicio()
        {
            No no = _listaEncadeada.AdicionarInicio(10);

            Assert.Equal(10, no.valor);
            Assert.Equal(1, _listaEncadeada.Size());

            Console.WriteLine($"O nó com valor {no.valor} foi adicionado.");
        }

        [Fact]
        public void AdicionarFim_Deve_Adicionar_No_Fim()
        {
            No no = _listaEncadeada.AdicionarFim(20);

            Assert.Equal(20, no.valor);
            Assert.Equal(1, _listaEncadeada.Size());

            Console.WriteLine($"O nó com valor {no.valor} foi adicionado.");
        }        

        [Fact]
        public void RemoverInicio_Deve_Remover_Primeiro_Elemento()
        {
            _listaEncadeada.AdicionarInicio(5);
            _listaEncadeada.AdicionarInicio(10); 

            No removido = _listaEncadeada.RemoverInicio();

            Assert.Equal(10, removido.valor);
            Assert.Equal(1, _listaEncadeada.Size());

            Console.WriteLine($"O nó com valor {removido.valor} foi removido.");
        }

        [Fact]
        public void RemoverInicio_Em_Lista_Vazia_Deve_Retornar_Null()
        {     
            No removido = _listaEncadeada.RemoverInicio();

            Assert.Null(removido);

            Console.WriteLine($"A lista está vazia, portanto, o nó retornado é null.");
        }

        [Fact]
        public void RemoverFim_ListaComUmElemento_DeveZerarLista()
        {            
            _listaEncadeada.AdicionarInicio(42);

            No removido = _listaEncadeada.RemoverFim();

            Assert.Equal(42, removido.valor);
            Assert.True(_listaEncadeada.IsEmpty());

            Console.WriteLine($"O nó removido possui o valor {removido.valor}.");
        }

        [Fact]
        public void RemoverFim_Deve_Remover_Ultimo_No()
        {            
            _listaEncadeada.AdicionarInicio(1);
            _listaEncadeada.AdicionarFim(2);
            _listaEncadeada.AdicionarFim(3);

            No removido = _listaEncadeada.RemoverFim();

            Assert.Equal(3, removido.valor);
            Assert.Equal(2, _listaEncadeada.Size());

            Console.WriteLine($"O nó removido possui o valor {removido.valor}.");
        }

        [Fact]
        public void RemoverFim_Em_Lista_Vazia_Deve_Retornar_Null()
        {
            No removido = _listaEncadeada.RemoverFim();

            Assert.Null(removido);

            Console.WriteLine($"A lista está vazia, portanto, o nó retornado é null.");
        }

        [Fact]
        public void Pesquisar_Valor_Existente_Deve_Retornar_No()
        {            
            _listaEncadeada.AdicionarInicio(7);
            _listaEncadeada.AdicionarFim(15);

            No resultado = _listaEncadeada.Pesquisar(15);

            Assert.NotNull(resultado);
            Assert.Equal(15, resultado.valor);

            Console.WriteLine($"O nó pesquisado possui o valor {resultado.valor}.");
        }

        [Fact]
        public void Pesquisar_Valor_Inexistente_Deve_Retornar_Null()
        {
            _listaEncadeada.AdicionarInicio(7);
            _listaEncadeada.AdicionarFim(15);

            No resultado = _listaEncadeada.Pesquisar(99);

            Assert.Null(resultado);

            Console.WriteLine($"O nó pesquisado não está na lista.");
        }

        [Fact]
        public void Size_Lista_Vazia_Deve_Ser_Zero()
        {  
            Assert.Equal(0, _listaEncadeada.Size());
            Console.WriteLine($"A lista está com 0 elementos.");
        }

        [Fact]
        public void Size_Apos_Insercoes_Deve_Retornar_Maior_Que_Zero()
        {
            _listaEncadeada.AdicionarInicio(1);
            _listaEncadeada.AdicionarFim(2);
            _listaEncadeada.AdicionarFim(3);

            Assert.Equal(3, _listaEncadeada.Size());

            Console.WriteLine($"A lista possui {_listaEncadeada.Size()} elementos.");            
        }

        [Fact]
        public void IsEmpty_Lista_Nova_Deve_Ser_Verdadeiro()
        {            
            Assert.True(_listaEncadeada.IsEmpty());

            Console.WriteLine($"A lista está vazia.");
        }

        [Fact]
        public void IsEmpty_AposInsercao_DeveSerFalso()
        {
            _listaEncadeada.AdicionarInicio(99);

            Assert.False(_listaEncadeada.IsEmpty());

            Console.WriteLine($"A lista possui elementos.");
        }       
    }
}