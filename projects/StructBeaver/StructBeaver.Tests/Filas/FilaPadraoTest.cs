using StructBeaver.Filas;

namespace StructBeaver.Tests.Filas
{
    public class FilaPadraoTest
    {
        private FilaPadrao _fila;

        public FilaPadraoTest()
            => _fila = new FilaPadrao();

        [Fact]
        public void Enqueue_Deve_Adicionar_Elemento_Na_Fila()
        {
            int item = 10;
            _fila.Enqueue(item);
            Assert.Equal(item, _fila.Peek());
        }

        [Fact]
        public void Dequeue_Deve_Excluir_Elemento_Na_Fila()
        {
            int item = 10;
            _fila.Enqueue(item);
            Assert.Equal(item, _fila.Peek());

            int itemRemovido = _fila.Dequeue();
            Assert.Equal(item, itemRemovido);
        }

        [Fact]
        public void Dequeue_Deve_Disparar_Excecao_Quando_Nao_Houver_Elemento_Na_Fila()
            => Assert.Throws<InvalidOperationException>(() => _fila.Dequeue());        

        [Fact]
        public void Peek_Deve_Verificar_Elemento_Na_Fila()
        {
            int item = 10;
            _fila.Enqueue(item);
            Assert.Equal(item, _fila.Peek());
        }

        [Fact]
        public void Peek_Deve_Disparar_Excecao_Quando_Nao_Houver_Elemento_Na_Fila()
            => Assert.Throws<InvalidOperationException>(() => _fila.Peek());
        
        [Fact]
        public void IsEmpty_Deve_Verificar_Pilha_Vazia()
        {
            _fila.Enqueue(10);
            _fila.Enqueue(20);
            _fila.Enqueue(30);

            _fila.Dequeue();
            _fila.Dequeue();
            _fila.Dequeue();

            Assert.True(_fila.IsEmpty());
        }
    }
}