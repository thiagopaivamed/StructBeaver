﻿namespace StructBeaver.Ordenacao.Exercicios
{
    public class SelectionSortRecursivo
    {
        private SelectionSort _selectionSort;

        public SelectionSortRecursivo() 
            => _selectionSort = new();

        public int[] OrdenarRecursivamente(int[] vetor) 
            => _selectionSort.RecursiveSort(vetor, vetor.Length);
    }
}
