using StructBeaver.Filas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructBeaver.Tests.Filas
{
    public class FilaCSharpTest
    {
        private FilaCSharp _fila;

        public FilaCSharpTest()
            => _fila = new FilaCSharp();

        [Fact]
        public void Enqueue_Deve_Adicionar_Elemento_Na_Fila()
        {
            int item = 10;
            _fila.Enqueue(item);
            Assert.Equal(item, _fila.Peek());
            Console.WriteLine($"O elemento {item} foi adicionado na fila.");
        }

        [Fact]
        public void Dequeue_Deve_Excluir_Elemento_Na_Fila()
        {
            int item = 10;
            _fila.Enqueue(item);
            Assert.Equal(item, _fila.Peek());

            int itemRemovido = _fila.Dequeue();
            Assert.Equal(item, itemRemovido);
            Console.WriteLine($"O elemento {item} foi removido da fila.");
        }

        [Fact]
        public void Dequeue_Deve_Disparar_Excecao_Quando_Nao_Houver_Elemento_Na_Fila()
        {
            Assert.Throws<InvalidOperationException>(() => _fila.Dequeue());
            Console.WriteLine($"A fila está vazia. Não há elementos para serem removidos.");
        }

        [Fact]
        public void Peek_Deve_Verificar_Elemento_Na_Fila()
        {
            int item = 10;
            _fila.Enqueue(item);
            Assert.Equal(item, _fila.Peek());
            Console.WriteLine($"O elemento {item} está na fila.");
        }

        [Fact]
        public void Peek_Deve_Disparar_Excecao_Quando_Nao_Houver_Elemento_Na_Fila()
        {
            Assert.Throws<InvalidOperationException>(() => _fila.Peek());
            Console.WriteLine($"A fila está vazia. Não há elementos no topo.");
        }

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
            Console.WriteLine("A fila está vazia.");
        }
    }
}
