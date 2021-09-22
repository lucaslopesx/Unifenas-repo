using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetodeMetodosdeOrdenacao
{
    class Metodos
    {
		int t1;
		int c1;

        public int T1 { get => t1; set => t1 = value; }
        public int C1 { get => c1; set => c1 = value; }

        public void QuickSort(int[] vet, int inicio, int fim)
		{
			int aux, pivo, i, j, pivoAux;
			pivoAux = (inicio + fim) / 2;
			pivo = vet[pivoAux];
			i = inicio;
			j = fim;

			while (i<=j)
			{
				C1++; 
				while (vet[i] < pivo)
				{
					
					i++;
				}
				while (vet[j] > pivo)
				{
					
					j--;
				}
				if (i <= j)
				{
					T1++;
					aux = vet[i];
					vet[i] = vet[j];
					vet[j] = aux;
					i++;
					j--;
				}
			}
			if (j > inicio)
			{
				QuickSort(vet, inicio, j);
			}
			if (i < fim)
			{
				QuickSort(vet, i, fim);
			}
		}
		public void BubbleSort(int[] vet)
		{
			int tam = vet.Length;
			for (int ultimo = tam - 1; ultimo > 0; ultimo--)
			{
				for (int i = 0; i < ultimo; i++)
				{
					C1++;
					if (vet[i] > vet[i + 1])
					{
                        T1++;
						int aux = vet[i];
						vet[i] = vet[i + 1];
						vet[i + 1] = aux;
					}
				}
			}
		}
		public void InsertSort(int[] vet)
		{
			int tam = vet.Length;
			int aux, j;
			for (int i = 0; i < tam; i++)
			{
				aux = vet[i];
				j = i - 1;
				while (j >= 0 && vet[j] > aux)
				{
					C1++;
					T1++;
					vet[j + 1] = vet[j];
					j--;
				}
				vet[j + 1] = aux;
			}
		}
		public void SelectSort(int[] vet)
		{
			int tam = vet.Length;
			for (int i = 0; i < tam - 1; i++)
			{
				int min = i;
				for (int j = i + 1; j < tam; j++)
				{
					C1++;
					if (vet[j] < vet[min])
					{
						min = j;
					}
				}
				if (vet[i] != vet[min])
				{
					T1++;
					int aux = vet[i];
					vet[i] = vet[min];
					vet[min] = aux;
				}
			}
		}
		
	}
}
